using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.IO;

namespace kpollo
{
    /// <summary>
    /// Interaction logic for Pass.xaml
    /// </summary>
    public partial class Pass : Window
    {

        private Prog pr = new Prog();

        public Pass()
        {
            
            InitializeComponent();
            /// deszerializáció
          
           pr.Beolvas();
        }

        public TextBlock tb = new TextBlock();

        internal Prog Pr
        {
            get
            {
                return pr;
            }

            set
            {
                pr = value;
            }
        }

        

        private void button_Click(object sender, RoutedEventArgs e)
        {
            
            User u = new User(tbnev.Text, tbjel.Text);
            Pr.Users.Add(u);
                
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            /// felhasználó keresése
            for (int i = 0; i < Pr.Users.Count; i++)
            {
                if (Pr.Users[i].Name == tbnev.Text && Pr.Users[i].Pass == tbjel.Text)
                {
                   
                   Prog.jatekos = i;
                   MainWindow m = new MainWindow();
                   m.ShowDialog();
                   
                }
                /// Ha nincs ilyen felhasználó
                if (i == Pr.Users.Count-1 && (Pr.Users[i].Name != tbnev.Text || Pr.Users[i].Pass != tbjel.Text))
                {
                    MessageBox.Show("Hibás Felhasználónév vagy jelszó");
                }
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Toplista tl = new Toplista();
           tl.ShowDialog();
            
          
        }
    }
}
