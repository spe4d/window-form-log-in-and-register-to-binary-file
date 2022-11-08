using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace read_text_file_into_array_of_objects
{
    [Serializable] 
    public class Player
    {
        string name;
        string password; 
        Image avatar;

        public Player()
        {
            name = "";
            password = "";
            avatar = null;
        }

        public Player(string name, string password, Image avatar)
        {
            Name = name;
            Password = password;
            Avatar = avatar;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public Image Avatar
        {
            get { return avatar; }
            set { avatar = value; }
        }
    }
}
