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
        DispatcherTimer t;
        public MainWindow()
        {
            
            t = new DispatcherTimer();
            t.Interval = new TimeSpan(0, 0, 0, 0,100);
            t.Tick += t_Tick;
            t.Start();
            InitializeComponent();
            //this.DataContext = this;
            this.ora.DataContext = this;
            
        }
       
        int sec = 0;
        int xenemy=900;
        int ybeka;
        int xbeka;
        int move = 3;
        int xenemy2=900;
       
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

     
        
      
        private void t_Tick(object sender, EventArgs e)
        {
            Sec++;

            label_frog_left_value.Content = Canvas.GetLeft(Canvas_frog) + Canvas_frog.Width;
            label_enemy_righ_vule.Content = Canvas.GetLeft(enemy);
            //itt vizsgálja, hogy elérte-e
            if ((Canvas.GetLeft(Canvas_frog)+Canvas_frog.Width >= Canvas.GetLeft(enemy) &&
               !(Canvas.GetTop(Canvas_frog) + Canvas_frog.Height <= Canvas.GetTop(enemy)) &&
               (Canvas.GetTop(Canvas_frog)  <= Canvas.GetTop(enemy)+enemy.Height) &&
               !(Canvas.GetLeft(Canvas_frog) >= Canvas.GetLeft(enemy)+enemy.Width))||
               (Canvas.GetLeft(Canvas_frog) + Canvas_frog.Width >= Canvas.GetLeft(enemy2) &&
               !(Canvas.GetTop(Canvas_frog) + Canvas_frog.Height <= Canvas.GetTop(enemy2)) &&
               (Canvas.GetTop(Canvas_frog) <= Canvas.GetTop(enemy2) + enemy2.Height) &&
               !(Canvas.GetLeft(Canvas_frog) >= Canvas.GetLeft(enemy2) + enemy2.Width))
               )

            {   label_collusion.Content = "True";
                move = 0;
                t.Stop();               
            }
            else
            {
                label_collusion.Content = "False";
            }
            Canvas.SetLeft(enemy, xenemy);
            xenemy -= move;

            if (Sec> 100)
            {
                Canvas.SetLeft(enemy2, xenemy2);
                xenemy2 -= move;
            }
            if (Canvas.GetLeft(enemy)<0-enemy.Width)
            {
                xenemy = 900;
                
                move+=2;
                Random r = new Random();
                Canvas.SetTop(enemy, r.Next(100,460));                
            }
            if (Canvas.GetLeft(enemy2) < 0 - enemy2.Width)
            {
                xenemy2 = 900;
               
                Random r = new Random();
                Canvas.SetTop(enemy2, r.Next(100, 460));
            }

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
                xbeka -= move;
                Canvas.SetLeft(Canvas_frog, xbeka);
            }
            if (e.Key == Key.Down)
            {
                ybeka += move;
                Canvas.SetTop(Canvas_frog, ybeka);
            }
            if (e.Key == Key.Up)
            {
                ybeka -= move;
                Canvas.SetTop(Canvas_frog, ybeka);

            }
           
            if (e.Key == Key.Right && xbeka < 700)
            {
                xbeka += move;
                Canvas.SetLeft(Canvas_frog, xbeka);
            }
        }

       
    }
}
