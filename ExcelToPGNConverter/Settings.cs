using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelToPGNConverter
{
    public partial class Settings : Form
    {
        public DefaultPosition df = new DefaultPosition();
        public Settings(DefaultPosition defaults)
        {
            InitializeComponent();
            //Show set values
            nUDInitialRow.Value = defaults.initRow;
            nUDWhitePlayer.Value = defaults.wPlayerColumn;
            nUDWhitePlayerElo.Value = defaults.wPlayerEloColumn;
            nUDBlackPlayer.Value = defaults.bPlayerColumn;
            nUDBlackPlayerElo.Value = defaults.bPlayerEloColumn;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            df.initRow = nUDInitialRow.Value;
            df.wPlayerColumn = nUDWhitePlayer.Value;
            df.wPlayerEloColumn = nUDWhitePlayerElo.Value;
            df.bPlayerColumn = nUDBlackPlayer.Value;
            df.bPlayerEloColumn = nUDBlackPlayerElo.Value;

            DialogResult = DialogResult.OK;

            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            
        }


    }
}
