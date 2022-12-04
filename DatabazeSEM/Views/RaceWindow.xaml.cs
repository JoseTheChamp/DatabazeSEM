using DatabazeSEM.Models;
using DatabazeSEM.Models.Entities;
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
        private Program program;
        public string RaceName { get; set; }
        public RaceWindow(string raceName)
        {
            program = ProgramSingleton.Instance;
            RaceName = raceName;
            InitializeComponent();
            txtRaceName.Text = raceName;
            txtRaceInfo.Text = program.GetRaceInfo(RaceName);
            txtRaceDate.Text = program.GetRaceDate(RaceName);
            List<Start> starts = program.GetAllStarts(RaceName);
            foreach (Start start in starts)
            {
                lbStarts.Items.Add(start);
            }
            starts = program.GetAllStartsFinished(RaceName);
            foreach (Start start in starts)
            {
                lbStartsFinished.Items.Add(start);
            }
            List<Track> tracks = program.GetAllTracks(RaceName);
            foreach (Track track in tracks)
            {
                lbTracks.Items.Add(track);
            }
            List<string> racers = program.GetAllRacers(RaceName);
            foreach (string racer in racers)
            {
                lbRacers.Items.Add(racer);
            }
        }

        private void txtRaceName_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Change name of race to xxx
        }

        private void lbStarts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            txtIdNewTime.Text = ((Start)lbStarts.SelectedItem).Id.ToString();
        }
    }
}
