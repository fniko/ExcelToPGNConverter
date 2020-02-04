namespace ExcelToPGNConverter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_import = new System.Windows.Forms.Button();
            this.button_export = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTournament = new System.Windows.Forms.TextBox();
            this.numUDRound = new System.Windows.Forms.NumericUpDown();
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            this.numUDTables = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cisloStolu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bilyHrac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eloBily = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cernyHrac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eloCerny = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimerPick = new System.Windows.Forms.DateTimePicker();
            this.folderBD = new System.Windows.Forms.FolderBrowserDialog();
            this.setExportPath = new System.Windows.Forms.Button();
            this.toolTipPath = new System.Windows.Forms.ToolTip(this.components);
            this.variablesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.variablesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numUDRound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDTables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.variablesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.variablesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_import
            // 
            this.button_import.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_import.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_import.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_import.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_import.Location = new System.Drawing.Point(13, 13);
            this.button_import.Name = "button_import";
            this.button_import.Size = new System.Drawing.Size(113, 23);
            this.button_import.TabIndex = 1;
            this.button_import.Text = "IMPORT DATA";
            this.button_import.UseVisualStyleBackColor = false;
            this.button_import.Click += new System.EventHandler(this.button_import_Click);
            // 
            // button_export
            // 
            this.button_export.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_export.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_export.Location = new System.Drawing.Point(381, 12);
            this.button_export.Name = "button_export";
            this.button_export.Size = new System.Drawing.Size(116, 23);
            this.button_export.TabIndex = 1;
            this.button_export.Text = "EXPORT PGN";
            this.button_export.UseVisualStyleBackColor = false;
            this.button_export.Click += new System.EventHandler(this.button_export_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(411, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ROUND";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(410, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "EVENT NAME";
            // 
            // textBoxTournament
            // 
            this.textBoxTournament.Location = new System.Drawing.Point(13, 47);
            this.textBoxTournament.Name = "textBoxTournament";
            this.textBoxTournament.Size = new System.Drawing.Size(391, 20);
            this.textBoxTournament.TabIndex = 5;
            // 
            // numUDRound
            // 
            this.numUDRound.Location = new System.Drawing.Point(345, 99);
            this.numUDRound.Name = "numUDRound";
            this.numUDRound.Size = new System.Drawing.Size(59, 20);
            this.numUDRound.TabIndex = 6;
            this.numUDRound.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // openFD
            // 
            this.openFD.DefaultExt = "xlsx";
            this.openFD.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // numUDTables
            // 
            this.numUDTables.Location = new System.Drawing.Point(345, 73);
            this.numUDTables.Name = "numUDTables";
            this.numUDTables.Size = new System.Drawing.Size(59, 20);
            this.numUDTables.TabIndex = 13;
            this.numUDTables.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(410, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "TABLES";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cisloStolu,
            this.bilyHrac,
            this.eloBily,
            this.cernyHrac,
            this.eloCerny});
            this.dataGridView1.Location = new System.Drawing.Point(12, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(485, 326);
            this.dataGridView1.TabIndex = 38;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cisloStolu
            // 
            this.cisloStolu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cisloStolu.HeaderText = "Stul";
            this.cisloStolu.Name = "cisloStolu";
            this.cisloStolu.ReadOnly = true;
            this.cisloStolu.Width = 50;
            // 
            // bilyHrac
            // 
            this.bilyHrac.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.bilyHrac.HeaderText = "Bily";
            this.bilyHrac.Name = "bilyHrac";
            this.bilyHrac.ReadOnly = true;
            this.bilyHrac.Width = 48;
            // 
            // eloBily
            // 
            this.eloBily.HeaderText = "Elo";
            this.eloBily.Name = "eloBily";
            this.eloBily.ReadOnly = true;
            this.eloBily.Width = 50;
            // 
            // cernyHrac
            // 
            this.cernyHrac.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cernyHrac.HeaderText = "Cerny";
            this.cernyHrac.Name = "cernyHrac";
            this.cernyHrac.ReadOnly = true;
            this.cernyHrac.Width = 59;
            // 
            // eloCerny
            // 
            this.eloCerny.HeaderText = "Elo";
            this.eloCerny.Name = "eloCerny";
            this.eloCerny.ReadOnly = true;
            this.eloCerny.Width = 50;
            // 
            // dateTimerPick
            // 
            this.dateTimerPick.Location = new System.Drawing.Point(12, 75);
            this.dateTimerPick.Name = "dateTimerPick";
            this.dateTimerPick.Size = new System.Drawing.Size(214, 20);
            this.dateTimerPick.TabIndex = 39;
            // 
            // setExportPath
            // 
            this.setExportPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.setExportPath.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.setExportPath.Location = new System.Drawing.Point(284, 12);
            this.setExportPath.Name = "setExportPath";
            this.setExportPath.Size = new System.Drawing.Size(91, 23);
            this.setExportPath.TabIndex = 40;
            this.setExportPath.Text = "Set destination";
            this.setExportPath.UseVisualStyleBackColor = false;
            this.setExportPath.Click += new System.EventHandler(this.setExportPath_Click);
            // 
            // variablesBindingSource
            // 
            this.variablesBindingSource.DataSource = typeof(ExcelToPGNConverter.Variables);
            // 
            // variablesBindingSource1
            // 
            this.variablesBindingSource1.DataSource = typeof(ExcelToPGNConverter.Variables);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 496);
            this.Controls.Add(this.setExportPath);
            this.Controls.Add(this.dateTimerPick);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numUDTables);
            this.Controls.Add(this.numUDRound);
            this.Controls.Add(this.textBoxTournament);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_export);
            this.Controls.Add(this.button_import);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(525, 535);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(525, 535);
            this.Name = "Form1";
            this.Text = ".xlsx to .png";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUDRound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDTables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.variablesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.variablesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_import;
        private System.Windows.Forms.Button button_export;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTournament;
        private System.Windows.Forms.NumericUpDown numUDRound;
        private System.Windows.Forms.OpenFileDialog openFD;
        private System.Windows.Forms.NumericUpDown numUDTables;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource variablesBindingSource;
        private System.Windows.Forms.BindingSource variablesBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimerPick;
        private System.Windows.Forms.DataGridViewTextBoxColumn cisloStolu;
        private System.Windows.Forms.DataGridViewTextBoxColumn bilyHrac;
        private System.Windows.Forms.DataGridViewTextBoxColumn eloBily;
        private System.Windows.Forms.DataGridViewTextBoxColumn cernyHrac;
        private System.Windows.Forms.DataGridViewTextBoxColumn eloCerny;
        private System.Windows.Forms.FolderBrowserDialog folderBD;
        private System.Windows.Forms.Button setExportPath;
        private System.Windows.Forms.ToolTip toolTipPath;
    }
}

