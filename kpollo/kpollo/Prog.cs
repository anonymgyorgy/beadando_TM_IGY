using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using System.IO;

namespace kpollo
{
    class Prog
    {
        
        
        public void Beolvas()
        {
            StreamReader be = new StreamReader("users.txt",Encoding.UTF7);
            while(!be.EndOfStream)
            {
                string nev = be.ReadLine();
                string jelszo = be.ReadLine();
                string score = be.ReadLine();
                User u = new User(nev, jelszo);
                u.Score = Convert.ToInt32(score);
                users.Add(u);

            }
            be.Close();

        } 

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


        public List<User> vmi;
        public List<User> rendez()
        {
            vmi = (from p in Prog.Users
                   orderby p.Score
                   select p).ToList();
            return vmi;
        }

    }
   
}

