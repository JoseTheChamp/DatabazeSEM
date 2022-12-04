using DatabazeSEM.Models.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabazeSEM.Models
{
    public class Program
    {
        private string connectionString = "";


        public void EstablishConnection() { 
            
        }

        public List<string> GetAllRaces()
        {
            return TestDataRepository.getAllRaces();
        }

        public string GetRaceInfo(string raceName) {
            return "Lorem ipsum dolor sit amet.";
        }
        public string GetRaceDate(string raceName)
        {
            return "18.5.2023";

        }
        public string GetTypeOfRace(string raceName)
        {
            return "domaci";
        }
        public List<Start> GetAllStarts(string raceName)
        {
            //pozor na logiku v UI rozd2lit na s casem a bez casu
            List<Start> starts = new List<Start>
            {
                new Start(8, 1500),
                new Start(9, 1500),
                new Start(10, 5000),
                new Start(12, 1500),
                new Start(15, 10000)
            };
            return starts;
        }

        public List<Start> GetAllStartsFinished(string raceName)
        {
            //pozor na logiku v UI rozd2lit na s casem a bez casu
            List<Start> starts = new List<Start>
            {
                new Start(11, 1500,184.4),
                new Start(7, 1500,145.65),
                new Start(22, 5000, 647.0)
            };
            return starts;
        }

        public List<Track> GetAllTracks(string raceName)
        {
            //pozor na logiku v UI rozd2lit na s casem a bez casu
            List<Track> tracks = new List<Track>
            {
                new Track(4,1500),
                new Track(6,5000,2),
                new Track(9,10000,4)
            };
            return tracks;
        }

        public List<string> GetAllRacers(string raceName)
        {
            //pozor na logiku v UI rozd2lit na s casem a bez casu
            List<string> tracks = new List<string>
            {
                "Karel Novotný 11.2.1988",
                "Petr Knotek 11.2.2004",
                "Irena Pálivá 19.12.1997",
                "Karel Zahradník 11.2.1988",
            };
            return tracks;
        }








    }
}
