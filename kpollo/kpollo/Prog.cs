using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace kpollo
{
    class Prog
    {
        private static List<User> users = new List<User>();
        public static List<User> Users
        {
            get
            {
                return users;
            }

            set
            {
                users = value;
            }
        }
        public static int jatekos = 0;
        public List<User> ulist ()
        { return users; }
       

        }
    }

