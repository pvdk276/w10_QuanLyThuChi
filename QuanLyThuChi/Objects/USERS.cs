using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuChi.Objects
{
    public class USERS
    {
        public string email { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string password { get; set; }
        public string type { get; set; }    //Loại: admin, user
        public bool status { get; set; }    //đã xác nhận mail hay chưa
        public string codeChangePassword { get; set; }  //khi đổi password sẽ tạo code

        /// <summary>
        /// Initializes a new instance of the <see cref="USERS"/> class.
        /// </summary>
        public USERS()
        {

        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Model_USERS"/> class.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="password">The password.</param>
        /// <param name="type">The type.</param>
        /// <param name="status">if set to <c>true</c> [status].</param>
        public USERS(string email,
            string firstName,
            string lastName,
            string password,
            string type,
            bool status)
        {
            this.email = email;
            this.firstName = firstName;
            this.lastName = lastName;
            this.password = password;
            this.type = type;
            this.status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="USERS"/> class.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="password">The password.</param>
        /// <param name="type">The type.</param>
        /// <param name="status">if set to <c>true</c> [status].</param>
        /// <param name="codeChangePassword">The code change password.</param>
        public USERS(string email,
            string firstName,
            string lastName,
            string password,
            string type,
            bool status,
            string codeChangePassword)
        {
            this.email = email;
            this.firstName = firstName;
            this.lastName = lastName;
            this.password = password;
            this.type = type;
            this.status = status;
            this.codeChangePassword = codeChangePassword;
        }
    }
}
