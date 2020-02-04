using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelToPGNConverter
{
    public class DefaultPosition
    {
        public decimal initRow { get; set; } = 0;
        public decimal wPlayerColumn { get; set; } = 1;
        public decimal wPlayerEloColumn { get; set; } = 0;
        public decimal bPlayerColumn { get; set; } = 0;
        public decimal bPlayerEloColumn { get; set; } = 0;

    }
}
