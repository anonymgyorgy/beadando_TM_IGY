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
    /// Interaction logic for Toplista.xaml
    /// </summary>
    public partial class Toplista : Window
    {
        
        public List<User> vmi;
        public List<User> rendez()
        {
            vmi = (from p in Prog.Users
                   orderby p.Score descending
                   select p).ToList();
            return vmi;
        }

        public Toplista()
        {
            InitializeComponent();
            this.listBox.ItemsSource = rendez();

        }



           

        private void Vissza_Click(object sender, RoutedEventArgs e)
        {
            Pass p = new Pass();
            p.Show();
            this.Close();
            
        }
    }
}
