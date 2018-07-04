using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserRepository.Classes;

namespace UserRepository
{
    public partial class UsersForm : Form
    {
        private string dbdLink;
        private SqlConnection conn;
        private SqlDataAdapter adapter;
        private DataSet ds;
        private SqlCommandBuilder cmd;
        private bool showAdmin;
        private User user;

        public Dictionary<string, string> lang;
        public UsersForm()
        {
            InitializeComponent();

            this.Load += UsersForm_Load;
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            showAdmin = false;

            lang = new Dictionary<string, string>
            {
                { "id", "ID"},
                { "login", "Логин" },
                { "password", "Пароль" },
                { "address", "Адрес" },
                { "phone", "Телефон" },
                { "is_admin", "Администратор" }
            };

            dbdLink = ConfigurationManager.ConnectionStrings["LocalConnectionString"].ConnectionString;
            conn = new SqlConnection(dbdLink);

            if (!SearchTable("users"))
            {
                CreateUsersTable();   
            }

            GetUsers(showAdmin);

            dView.CellDoubleClick += DView_CellDoubleClick;
        }

        /// <summary>
        /// двойной клинк в таблице - редактирование пользователя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            user = new User();

            
            try
            {
                DataGridViewRow dr = dView.CurrentRow;

                user.Id = (int)dr.Cells[0]?.Value;
                user.Login = dr.Cells[1].Value?.ToString();
                user.Password = (int)dr.Cells[2]?.Value;
                user.Address = dr.Cells[3].Value?.ToString();
                user.Phone = dr.Cells[4].Value?.ToString();
                user.IsAdmin = (int)dr.Cells[5].Value;

                UsersFields f = new UsersFields(user, false);

                if (f.ShowDialog() == DialogResult.OK)
                {
                    for (int i = 1; i < ds.Tables["Users"].Columns.Count; i++)
                    {
                        try
                        {
                            ds.Tables["Users"].Rows[dView.CurrentRow.Index][i] = typeof(User).GetProperties()[i].GetValue(user);
                        }
                        catch (Exception ex)
                        {
                            ShowMessage(ex.Message);
                        }

                    }
                    adapter.Update(ds, "Users");
                    GetUsers(showAdmin);
                }

            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message);
            }
            
        }

        /// <summary>
        /// Получение списка пользователей из БД
        /// </summary>
        /// <param name="all"></param>
        private void GetUsers(bool admin)
        {
            string sql;
            try
            {
                ds = new DataSet();

                if (!admin)
                {
                    sql = "SELECT * FROM users";
                }
                else
                {
                    sql = "SELECT * FROM users WHERE is_admin = 1";
                }
                
                conn.Open();

                adapter = new SqlDataAdapter(sql, conn);
                dView.DataSource = null;

                cmd = new SqlCommandBuilder(adapter);
                adapter.Fill(ds,"Users");

                dView.DataSource = ds.Tables["Users"];

                foreach (DataGridViewColumn col in dView.Columns)
                {

                    if (lang.ContainsKey(col.HeaderText))
                    {
                        col.HeaderText = lang[col.HeaderText];
                    }

                }

            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message);
            }

            conn?.Close();
        }

        /// <summary>
        /// Создание таблицы users
        /// </summary>
        private void CreateUsersTable()
        {
            try
            {
                string sql = @"CREATE TABLE users
                                        (
                                            id INT IDENTITY(0, 1) PRIMARY KEY,
                                            login NVARCHAR(25) NOT NULL,
                                            password INT NOT NULL,
                                            address NVARCHAR(25) NOT NULL,
                                            phone NVARCHAR(12) NOT NULL,
                                            is_admin INT  NOT NULL DEFAULT 0,
                                            UNIQUE (login)
                                        ); ";
                conn.Open();

                SqlCommand sqlCommand = new SqlCommand(sql, conn);
                sqlCommand.ExecuteNonQuery();

                sql = "INSERT INTO users VALUES" +
                    $"('user', {"testpassword".GetHashCode()}, 'new address', '380000000000', 0)," +
                    $"('usr', {"newPass".GetHashCode()}, 'new address', '380000000000', 0);";

                sqlCommand.CommandText = sql;

                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message);
            }
        }


        /// <summary>
        /// Проверка существования таблицы
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        private bool SearchTable(string tableName)
        {
            bool res = false;

            conn?.Close();

            //Запрос проверки существования базы данных
            string sql = "SELECT name FROM sys.objects WHERE type in (N'U') AND name = @table";

            SqlParameter p = new SqlParameter();
            p.ParameterName = "@table";
            p.SqlDbType = SqlDbType.NVarChar;
            p.Value = tableName;

            conn = new SqlConnection(dbdLink);

            conn.Open();

            SqlCommand sqlCommand = new SqlCommand(sql, conn);

            sqlCommand.Parameters.Add(p);

            SqlDataReader r = sqlCommand.ExecuteReader();

            if (r.HasRows)
            {
                res = true;
            }

            r?.Close();
            conn?.Close();
            return res;
        }

        /// <summary>
        /// Отображение сообщения
        /// </summary>
        /// <param name="msg"></param>
        private void ShowMessage(string msg)
        {
            MessageBox.Show(msg, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Обработка нажатия кнопки создать пользователя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bCreateUser_Click(object sender, EventArgs e)
        {
            user = new User();

            UsersFields f = new UsersFields(user, true);

            if(f.ShowDialog() == DialogResult.OK)
            {
                if (SearchLogin(user.Login))
                {
                    ShowMessage("Введенный логин уже существует");
                    f.ShowDialog();
                }
                else
                {
                    DataRow row = ds.Tables["Users"].NewRow();

                    for (int i = 1; i < ds.Tables["Users"].Columns.Count; i++)
                    {
                        try
                        {
                            row[i] = typeof(User).GetProperties()[i].GetValue(user);
                        }
                        catch (Exception ex)
                        {
                            ShowMessage(ex.Message);
                        }

                    }

                    ds.Tables["Users"].Rows.Add(row);

                    adapter.Update(ds, "Users");

                    GetUsers(showAdmin);
                }
               
            }

        }

        private bool SearchLogin(string login)
        {
            //если была фильтрация по администраторам то для проверки логина получаем всех пользователей
            if (showAdmin)
            {
                GetUsers(false);
            }

            foreach (DataRow row in ds.Tables["Users"].Rows)
            {
                if (row[1].ToString() == login)
                {
                    return true;
                }
            }

            //если была фильтрация по администраторам, то возвращаем фильтрацию
            if (showAdmin)
            {
                GetUsers(showAdmin);
            }

            return false;
        }

        /// <summary>
        /// Обработка нажатия кнопки фильтрации пользователей
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            if (showAdmin)
            {
                showAdmin = false;
                bShowAdmin.Text = "Показать Администраторов";
            }
            else
            {
                showAdmin = true;
                bShowAdmin.Text = "Показать всех пользователей";
            }

            GetUsers(showAdmin);
        }

        /// <summary>
        /// Обработка нажатия кнопки удаления пользователя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bDeleteUser_Click(object sender, EventArgs e)
        {
           if (dView.CurrentRow != null)
            {
                string msg = $"Вы действительно удалить пользователя {dView.CurrentRow.Cells[1].Value}?"; 
                if (MessageBox.Show(msg, this.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    ds.Tables["Users"].Rows[dView.CurrentRow.Index].Delete();
                    adapter.Update(ds, "Users");
                    GetUsers(showAdmin);
                }
            }
        }
    }
}
