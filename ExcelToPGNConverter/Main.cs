using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using XLS = Microsoft.Office.Interop.Excel;

namespace ExcelToPGNConverter
{
    public partial class Main : Form
    {
        string exportPath = "";
        public DefaultPosition defaultValue = new DefaultPosition();

        public Variables var = new Variables();
        public Main()
        {
            InitializeComponent();
            labelExported.Text = "";
        }

        private void button_export_Click(object sender, EventArgs e)
        {
            if (exportPath == "")
            {
                MessageBox.Show("Destination folder is not set! Please use 'Set destination button' and pick a destination folder.",
                                        "Destination not set!", MessageBoxButtons.OK);
                return;
            }
            else if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No data has been detected. Please import them first!",
                            "No data!", MessageBoxButtons.OK);
                return;
            }
            else if (textBoxTournament.Text == "")
            {
                MessageBox.Show("Turnament has no name, please type one",
                "No tournament name!", MessageBoxButtons.OK);
                return;
            }
            else if (numUDRound.Value == 0)
            {
                MessageBox.Show("Round number should be greater than zero, please increase round number.",
                "Wrong round number!", MessageBoxButtons.OK);
                return;
            }

            //export the PGN
            var.Day = dateTimerPick.Value.Day;
            var.Month = dateTimerPick.Value.Month;
            var.Year = dateTimerPick.Value.Year;
            var.Round = numUDRound.Value;
            var.TournamentName = textBoxTournament.Text;
            var.Tables = numUDTables.Value;

            RemoveDiacritics(var.whitePlayer);
            RemoveDiacritics(var.blackPlayer);

            using (StreamWriter writetext = new StreamWriter(exportPath + "\\round_" + var.Round + ".pgn"))
            {
                for (int i = 0; i <= var.Tables - 1; i++)
                {
                    writetext.Write("[Event " + (char)034 + var.TournamentName + (char)034 + "]\n");
                    writetext.Write("[Site " + (char)034 + "?" + (char)034 + "]\n");
                    writetext.Write("[Date " + (char)034 + var.Year + "." + var.Month + "." + var.Day + (char)034 + "]\n");
                    writetext.Write("[Round " + (char)034 + var.Round + "." + (i + 1) + (char)034 + "]\n");

                    writetext.Write("[White " + (char)034 + var.whitePlayer[i] + (char)034 + "]\n");
                    writetext.Write("[Black " + (char)034 + var.blackPlayer[i] + (char)034 + "]\n");

                    writetext.Write("[Result " + (char)034 + "*" + (char)034 + "]\n");

                    writetext.Write("[WhiteElo " + (char)034 + var.eloWhitePlayer[i] + (char)034 + "]\n");
                    writetext.Write("[BlackElo " + (char)034 + var.eloBlackPlayer[i] + (char)034 + "]\n");

                    writetext.Write("[LiveChessVersion " + (char)034 + "1.4.8" + (char)034 + "]\n");

                    writetext.Write("\n");
                    writetext.Write("*\n");
                    writetext.Write("\n");
                }
            }

            labelExported.Text = String.Format("Round {0} was exported!", var.Round);
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        public void button_import_Click(object sender, EventArgs e)
        {
            XLS.Application xlApp = new XLS.Application();
            OpenFileDialog openFD = new OpenFileDialog();
            string filePath = "";

            // Add 0 tables exception
            var.Tables = numUDTables.Value;
            if (var.Tables == 0)
            {
                MessageBox.Show("Zero tables set, so no tables would be imported, please increase the number of tables at least to one.",
                                        "No tables set!", MessageBoxButtons.OK);
                return;
            }
            else if (defaultValue.initRow == 0)
            {
                MessageBox.Show("Warning, no initial read location is set! Please go to Edit/Settings and provide with default location where the program should start reading! Please note all values should differ from ZERO",
                                            "Warning, no init location set!", MessageBoxButtons.OK);
                return;
            }
            else
                if (openFD.ShowDialog() == DialogResult.OK)
            {
                filePath = openFD.FileName;
            }

            XLS.Workbook xlWorkbook = xlApp.Workbooks.Open(filePath);

            XLS._Worksheet xlWorksheet = xlWorkbook.Sheets[1];

            XLS.Range xlRange = xlWorksheet.UsedRange;

            #region ALTERNATIVE + LOAD
            // Initial ROW, where to start reading data
            decimal row = defaultValue.initRow;

            #region cleanTheList
            var.whitePlayer.Clear();
            var.blackPlayer.Clear();
            var.eloWhitePlayer.Clear();
            var.eloBlackPlayer.Clear();
            #endregion

            for (int i = 0; i <= var.Tables; i++)
            {
                var.whitePlayer.Add(Convert.ToString(((XLS.Range)xlWorksheet.Cells[row + i, defaultValue.wPlayerColumn]).Value2)); //WHITE
                var.blackPlayer.Add(Convert.ToString(((XLS.Range)xlWorksheet.Cells[row + i, defaultValue.bPlayerColumn]).Value2)); //BLACK
                var.eloWhitePlayer.Add(Convert.ToString(((XLS.Range)xlWorksheet.Cells[row + i, defaultValue.wPlayerEloColumn]).Value2)); //WHITE ELO
                var.eloBlackPlayer.Add(Convert.ToString(((XLS.Range)xlWorksheet.Cells[row + i, defaultValue.bPlayerEloColumn]).Value2)); //BLACK ELO
            }

            #endregion

            #region CLEANUP
            //cleanups
            GC.Collect();
            GC.WaitForPendingFinalizers();

            //release com objects to fully kill excel process from running in the background
            Marshal.ReleaseComObject(xlWorkbook);
            Marshal.ReleaseComObject(xlWorksheet);

            //close and release
            //xlWorkbook.Close();
            Marshal.ReleaseComObject(xlWorkbook);

            //quit and release
            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);

            dataGridView1.Rows.Clear();
            #endregion

            for (int i = 0; i < var.Tables; i++)
                dataGridView1.Rows.Add(i + 1, var.whitePlayer[i], var.eloWhitePlayer[i], var.blackPlayer[i], var.eloBlackPlayer[i]);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public static string[] RemoveDiacritics(List<string> text)
        {
            for (int i = 0; i < text.Count; i++)
            {
                string tt = text[i];
                string stringFormD = tt.Normalize(System.Text.NormalizationForm.FormD);
                System.Text.StringBuilder retVal = new System.Text.StringBuilder();
                for (int index = 0; index < stringFormD.Length; index++)
                {
                    if (System.Globalization.CharUnicodeInfo.GetUnicodeCategory(stringFormD[index]) != System.Globalization.UnicodeCategory.NonSpacingMark)
                        retVal.Append(stringFormD[index]);
                }
                text[i] = retVal.ToString().Normalize(System.Text.NormalizationForm.FormC);
            }
            return text.ToArray();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void setExportPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBD = new FolderBrowserDialog();

            DialogResult result = folderBD.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBD.SelectedPath))
            {
                exportPath = folderBD.SelectedPath;
                setExportPath.BackColor = Color.LightGray;
                toolTipPath.SetToolTip(button_export, exportPath);
                toolTipPath.SetToolTip(setExportPath, exportPath);
            }
        }

        private void labelExportPath_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void setupFieldsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Settings form = new Settings(defaultValue))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    defaultValue.initRow = form.df.initRow;
                    defaultValue.wPlayerColumn = form.df.wPlayerColumn;
                    defaultValue.wPlayerEloColumn = form.df.wPlayerEloColumn;
                    defaultValue.bPlayerColumn = form.df.bPlayerColumn;
                    defaultValue.bPlayerEloColumn = form.df.bPlayerEloColumn;
                }
            }
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Info form = new Info();
            form.Show();
     
        }
    }
}
