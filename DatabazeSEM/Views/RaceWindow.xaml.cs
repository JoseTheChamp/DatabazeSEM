using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace DatabazeSEM
{
    /// <summary>
    /// Interaction logic for RaceWindow.xaml
    /// </summary>
    public partial class RaceWindow : Window
    {
        public string RaceName { get; set; }
        public RaceWindow(string raceName)
        {
            RaceName = raceName;
            InitializeComponent();
            Debug.WriteLine("NASTAVENI NAZVU  " + raceName);
            Debug.WriteLine("puvodni NAZev  " + txtRaceName.Text);
            txtRaceName.Text = raceName;
            Debug.WriteLine("novy NAZev  " + txtRaceName.Text);
        }

        private void txtRaceName_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Change name of race to xxx
        }
    }
}
