using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRepository.Classes
{
    public class User
    {
        private int id;
        private string login;
        private int password;
        private string address;
        private string phone;
        private int isAdmin;

        /// <summary>
        /// User ID
        /// </summary>
        public int Id { get => id; set => id = value; }

        /// <summary>
        /// User login
        /// </summary>
        public string Login { get => login; set => login = value; }

        /// <summary>
        /// User password
        /// </summary>
        public int Password { get => password; set => password = value.GetHashCode(); }

        /// <summary>
        /// User Address
        /// </summary>
        public string Address { get => address; set => address = value; }

        /// <summary>
        /// User phone
        /// </summary>
        public string Phone { get => phone; set => phone = value; }

        /// <summary>
        /// Is user admin
        /// </summary>
        public int IsAdmin { get => isAdmin; set => isAdmin = value; }
    }
}
