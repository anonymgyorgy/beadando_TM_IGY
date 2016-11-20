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
        Prog pr = new Prog();
        Random r = new Random();
        public MainWindow()
        {
            DispatcherTimer t;
            InitializeComponent();

            t = new DispatcherTimer();
            t.Interval = new TimeSpan(0, 0, 1);
            t.Tick += t_Tick;
            t.Start();
            //this.DataContext = this;
            this.ora.DataContext = this;

        }
        int sec;

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
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Pass p = new Pass();
            p.Show();
            this.Close();            
        }
      
       
    }
}
