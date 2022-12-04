using DatabazeSEM.Models;
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

namespace DatabazeSEM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Program program;

        public MainWindow()
        {
            InitializeComponent();
            program = ProgramSingleton.Instance;
            List<string> races = program.GetAllRaces();
            foreach (var race in races)
            {
                cbRaces.Items.Add(race);
            }
            cbRaces.SelectedIndex= 0;
        }

        private void btnNewRace_Click(object sender, RoutedEventArgs e)
        {
            string name = txtName.Text;
            //TODO create new race in database. 
            //Open racewindow with that race.
            RaceWindow raceWindow = new RaceWindow(name);
            raceWindow.Show();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            // dialog really delete? - not permited
            //Remove selected race
            //reselect combo box
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            //open selected race in RaceWindow
            RaceWindow raceWindow = new RaceWindow(cbRaces.Text);
            raceWindow.Show();
        }

        private void btnAllRacers_Click(object sender, RoutedEventArgs e)
        {
            AllRacers allRacers = new AllRacers();
            allRacers.Show();
        }
    }
}
