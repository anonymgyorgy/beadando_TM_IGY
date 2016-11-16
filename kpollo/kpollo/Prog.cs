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
        private static Game ng = new Game(0, 0);
        internal Game Ng
        {
            get
            {
                return ng;
            }

            set
            {
                ng = value;
            }
        }

       public void pontozas()
        {
            if(ng.User==1)
            {
                if (ng.Gep==2)
                { users[jatekos].lose++; }
                if (ng.Gep==3)
                { users[jatekos].score++; }
            }

            if(ng.User==2)
            {
                if (ng.Gep == 3)
                { users[jatekos].lose++; }
                if (ng.Gep == 1)
                { users[jatekos].score++; }


            }

            if (ng.User==3)
            {
                if (ng.Gep == 1)
                { users[jatekos].lose++; }
                if (ng.Gep == 2)
                { users[jatekos].score++; }
            }


        }

        public BitmapImage kepek()
        {
            BitmapImage myBitmapImage1 = new BitmapImage();
            myBitmapImage1.BeginInit();
            myBitmapImage1.UriSource = new Uri(@"C:\Users\tothm\documents\visual studio 2015\Projects\kpollo\kpollo\kog.png");
            myBitmapImage1.EndInit();

            BitmapImage myBitmapImage2 = new BitmapImage();
            myBitmapImage2.BeginInit();
            myBitmapImage2.UriSource = new Uri(@"C:\Users\tothm\documents\visual studio 2015\Projects\kpollo\kpollo\ollog.png");
            myBitmapImage2.EndInit();

            BitmapImage myBitmapImage3 = new BitmapImage();
            myBitmapImage3.BeginInit();
            myBitmapImage3.UriSource = new Uri(@"C:\Users\tothm\documents\visual studio 2015\Projects\kpollo\kpollo\paperg.png");
            myBitmapImage3.EndInit();

            if (Ng.Gep==1)
            {
                return myBitmapImage1;
                
            }

            if (Ng.Gep == 2)
            {
                return myBitmapImage2;
            }

           else
            {
                return myBitmapImage3;
            }

        }
    }
}
