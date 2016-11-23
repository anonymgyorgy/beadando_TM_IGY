using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using System.IO;
using System.Xml.Serialization;

namespace kpollo
{
    class Prog
    {
        
        
        private static List<User> users = new List<User>();

        public void Beolvas()
        {
/*
            StreamReader be = new StreamReader("userialization.xml");
            XmlSerializer xs = new XmlSerializer(typeof(User));

            User u = (User)xs.Deserialize(be);

          
            /*

            /*StreamReader be = new StreamReader("users.txt", Encoding.UTF7);
            while (!be.EndOfStream)
            {
                string nev = be.ReadLine();
                string jelszo = be.ReadLine();
                string score = be.ReadLine();
                User u = new User(nev, jelszo);
                u.Score = Convert.ToInt32(score);
            users.Add(u);

            }
            be.Close();*/

        }
        public void Serialize()
        {
            FileStream fs = new FileStream("userialization.xml", FileMode.Create);
            XmlSerializer xs = new XmlSerializer(typeof(User));
            for (int i = 0; i < users.Count; i++)
            {               
                xs.Serialize(fs, users[i]);
            }

        }
        static public List<User> ulist()
        { return users; }
        public  List<User> Users
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
        
    }
   
}

