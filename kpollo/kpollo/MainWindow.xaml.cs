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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace kpollo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Prog pr = new Prog();
        Random r = new Random();
        public MainWindow()
        {
            InitializeComponent();          
           
        }
             
        private void button_Click(object sender, RoutedEventArgs e)
        {
            Pass p = new Pass();
            p.Show();
            this.Close();            
        }
      
        private void image_MouseDown(object sender, MouseButtonEventArgs e)
        {            
            valasztas.Source = image.Source;
            pr.Ng.User = 1;
            pr.Ng.Gep = r.Next(1, 4);
            gepkep.Source = pr.kepek();
            pr.pontozas();
            tballas.Text = pr.ulist()[Prog.jatekos].score.ToString() + "-" + pr.ulist()[Prog.jatekos].lose.ToString();
        }        
        private void image_Copy_MouseDown(object sender, MouseButtonEventArgs e)
        {
            valasztas.Source = image2.Source;
            pr.Ng.User = 2;
            pr.Ng.Gep = r.Next(1, 4);
            gepkep.Source = pr.kepek();
            pr.pontozas();
            tballas.Text = pr.ulist()[Prog.jatekos].score.ToString() + "-" + pr.ulist()[Prog.jatekos].lose.ToString();
           
        }
        private void image3_MouseDown(object sender, MouseButtonEventArgs e)
        {
            valasztas.Source = image3.Source;
            pr.Ng.User = 3;
            pr.Ng.Gep = r.Next(1, 4);
            gepkep.Source = pr.kepek();
            pr.pontozas();
            tballas.Text = pr.ulist()[Prog.jatekos].score.ToString() +"-"+ pr.ulist()[Prog.jatekos].lose.ToString(); 
            
        }
    }
}
