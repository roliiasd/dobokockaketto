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

namespace fí
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int diceRoll;

        public MainWindow()
        {
            InitializeComponent();
        }


        private void kepernyo_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Random r = new Random();
            int dobokockaDobas = r.Next(1,7);

            dobokockaKep.Source = new BitmapImage(new Uri($"{dobokockaDobas}.png",UriKind.Relative));
        }
    }
}
