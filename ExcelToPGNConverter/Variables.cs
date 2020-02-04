using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelToPGNConverter
{
    public class Variables
    {
        public decimal Day { get; set; }
        public decimal Month { get; set; }
        public decimal Year { get; set; }
        public decimal Round { get; set; }
        public string TournamentName { get; set; }
        public decimal Tables { get; set; }

        //TODO: Move to lists
        //public string[] WhitePlayer = new string[20];
        //public string[] BlackPlayer = new string[20];

        //public string[] eloWhitePlayer = new string[20];
        //public string[] eloBlackPlayer = new string[20];

        public List<string> whitePlayer = new List<string>();
        public List<string> blackPlayer = new List<string>();

        public List<string> eloWhitePlayer = new List<string>();
        public List<string> eloBlackPlayer = new List<string>();
    }
}
