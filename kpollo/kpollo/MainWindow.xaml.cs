using System;
using System.Collections.Generic;
using System.Media;
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
using System.Threading;
using System.ComponentModel;
using System.Windows.Threading;

namespace kpollo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window , INotifyPropertyChanged
    {
        
        public MainWindow()
        {
            
            DispatcherTimer t;
            t = new DispatcherTimer();
            t.Interval = new TimeSpan(0, 0, 0, 1);
            t.Tick += t_Tick;
            t.Start();
            InitializeComponent();
            //this.DataContext = this;
            this.ora.DataContext = this;
            
        }
       
        int sec = 0;
        
        int ybeka=300;
        int xbeka = 100;
       
       
        public int Sec
        {
            get { return sec; }
            set
            {
                sec = value;
                var pc = PropertyChanged;
                if (pc != null)
                    pc(this, new PropertyChangedEventArgs("Sec"));

            }
        }


        int xenemy = 300;
      
        private void t_Tick(object sender, EventArgs e)
        {
            Sec++;

            label_frog_left_value.Content = Canvas.GetLeft(Canvas_frog) + Canvas_frog.Width;
            label_enemy_righ_vule.Content = Canvas.GetLeft(enemy);

            

            //itt vizsgálja, hogy elérte-e
            if (Canvas.GetLeft(Canvas_frog)+Canvas_frog.Width >= Canvas.GetLeft(enemy) &&
               !(Canvas.GetTop(Canvas_frog) + Canvas_frog.Height <= Canvas.GetTop(enemy)) &&
               (Canvas.GetTop(Canvas_frog)  <= Canvas.GetTop(enemy)+enemy.Height) &&
               !(Canvas.GetLeft(Canvas_frog) >= Canvas.GetLeft(enemy)+enemy.Width)


               )                
            {               

                label_collusion.Content = "True";
            }

            else
            {
                label_collusion.Content = "False";
                // MessageBox.Show("Elérte", "Help");
            }




            Canvas.SetLeft(enemy, xenemy);
           // xenemy -= 10;

      
          


        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void buttonVege_Click(object sender, RoutedEventArgs e)
        {
            Prog.ulist()[Prog.jatekos].Score = Sec;
            this.Close();
        }
       

        

        private void Cv_KeyDown(object sender, KeyEventArgs e)
        {
           

            if (e.Key == Key.Left && xbeka>1)
            {
                xbeka -= 10;
                Canvas.SetLeft(Canvas_frog, xbeka);
            }
            if (e.Key == Key.Down)
            {
                ybeka += 10;
                Canvas.SetTop(Canvas_frog, ybeka);
            }
            if (e.Key == Key.Up)
            {
                ybeka -= 10;
                Canvas.SetTop(Canvas_frog, ybeka);

            }
           
            if (e.Key == Key.Right && xbeka < 700)
            {
                xbeka += 10;
                Canvas.SetLeft(Canvas_frog, xbeka);
            }
        }

       
    }
}
