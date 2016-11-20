using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace kpollo
{
   
    /// <summary>
    /// Interaction logic for Pass.xaml
    /// </summary>
    public partial class Pass : Window
    {
      

        public Pass()
        {
            InitializeComponent();
        }

        public TextBlock tb = new TextBlock();

        private void button_Click(object sender, RoutedEventArgs e)
        {
            User u = new User(tbnev.Text, tbjel.Text);
            Prog.Users.Add(u);
                
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < Prog.Users.Count; i++)
            {
                if (Prog.Users[i].Name == tbnev.Text && Prog.Users[i].Pass == tbjel.Text)
                {
                    MainWindow m = new MainWindow();
                    Prog.jatekos = i;
                    m.ShowDialog();
                    this.Close();
                }
                if(i == Prog.Users.Count-1 && (Prog.Users[i].Name != tbnev.Text || Prog.Users[i].Pass != tbjel.Text))
                {
                    MessageBox.Show("Hibás Felhasználónév vagy jelszó");
                }
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Toplista tl = new Toplista();
            tl.ShowDialog();
            this.Close();
        }
    }
}
