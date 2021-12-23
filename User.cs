using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiFaceRec
{
    public class User
    {
        public string id;
        public string firstname;
        public string lastname;
        public string username;
        public string password;
        public string image;

        public User() { }

        public User(string id, string firstname,string lastname, string username, string password, string image)
        {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            this.username = username;
            this.password = password;
            this.image = image;
        }

        public User(User u)
        {
            this.id = u.id;
            this.firstname = u.firstname;
            this.lastname = u.lastname;
            this.username = u.username;
            this.password =u.password;
            this.image = u.image;
        }

    }
}
