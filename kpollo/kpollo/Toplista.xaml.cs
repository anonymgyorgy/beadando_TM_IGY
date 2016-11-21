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
        public Pass p ;
        

        public List<User> vmi;
        public List<User> rendez()
        {
           p = new Pass();
        vmi = (from a in p.Pr.Users
                   orderby a.Score descending
                   select a).ToList();
            return vmi;
        }

        public Toplista()
        {
            InitializeComponent();
            this.listBox.ItemsSource = rendez();
            

        }



           

        private void Vissza_Click(object sender, RoutedEventArgs e)
        {
           
            
            this.Close();
            
        }
    }
}
