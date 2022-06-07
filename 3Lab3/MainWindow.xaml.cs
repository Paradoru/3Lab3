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

namespace _3Lab3
{
    public partial class MainWindow : Window
    {
        public partial class GG
        {
            public double r;
            public int t;
        }
        Silg silg = new Silg();
        GG gg = new GG();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Time_TextChanged(object sender, TextChangedEventArgs e)
        {
            gg.t = Convert.ToInt32(Time.Text);
        }

        private void Speed_TextChanged(object sender, TextChangedEventArgs e)
        {
            gg.r = double.Parse(Speed.Text);
        }

        private void Sila_TextChanged(object sender, TextChangedEventArgs e)
        {
            silg.s = Convert.ToInt32(Sila.Text);
        }
        private void Raschet_Click(object sender, RoutedEventArgs e)
        {
            if (silg.s == 0)
            {
                double z;
                z = gg.r;
                int x;
                x = gg.t;
                x *= 60;
                double c = z * x;
                Result.Text = Convert.ToString(c);
            }
            else
            {
                double y;
                y = silg.s;
                double z;
                z = gg.r;
                int x;
                x = gg.t;
                x *= 60;
                double c = z * x;
                c *= y;
                Result.Text = Convert.ToString(c);
            }
        }
    }
}
