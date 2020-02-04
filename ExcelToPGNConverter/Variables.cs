using System.Collections.Generic;

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

        public List<string> whitePlayer = new List<string>();
        public List<string> blackPlayer = new List<string>();

        public List<string> eloWhitePlayer = new List<string>();
        public List<string> eloBlackPlayer = new List<string>();
    }
}
