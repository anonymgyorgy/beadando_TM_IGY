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
            DispatcherTimer g;
            g = new DispatcherTimer();
            g.Interval = new TimeSpan(0, 0, 1);
            g.Tick += g_Tick;
            g.Start();
            DispatcherTimer t;
            t = new DispatcherTimer();
            t.Interval = new TimeSpan(0, 0, 0, 0, 50);
            t.Tick += t_Tick;
            t.Start();
            InitializeComponent();
            //this.DataContext = this;
            this.ora.DataContext = this;
            Canvas.SetBottom(imageground, 1); 
        }
        int millisec=0;
        int sec = 0;
        
        int ybeka=300;
        int xbeka = 100;
        public int Millisec
        {
            get { return millisec; }
            set
            {
                millisec = value;
                var pc = PropertyChanged;
                if (pc != null)
                    pc(this, new PropertyChangedEventArgs("Millisec"));
                
            }
        }
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
            Millisec++;
            if (ybeka < 350)
            {
                ybeka = ybeka + 10;
                Canvas.SetTop(image, ybeka);
                           
            }
            
        }
        private void g_Tick(object sender, EventArgs e)
        {
            Sec++;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void buttonVege_Click(object sender, RoutedEventArgs e)
        {
            Prog.ulist()[Prog.jatekos].Score = Sec;
            this.Close();
        }
       

        bool jump = false;

        private void Cv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Left && xbeka>1)
            {
                xbeka -= 10;
                Canvas.SetLeft(image, xbeka);
            }
            if (e.Key == Key.Down)
            {
                //ybeka += 10;
                Canvas.SetTop(image, ybeka);
            }
            if (e.Key == Key.Up)
            {
                while(!jump && ybeka>=350)
                {
                    SystemSounds.Asterisk.Play();
                    jump = true;
                    ybeka -= 200;
                    Canvas.SetTop(image, ybeka);
                }
                jump = false;

            }
           
            if (e.Key == Key.Right && xbeka < 700)
            {
                xbeka += 10;
                Canvas.SetLeft(image, xbeka);
            }
        }
    }
}
