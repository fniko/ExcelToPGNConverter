namespace ExcelToPGNConverter
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.label1 = new System.Windows.Forms.Label();
            this.nUDInitialRow = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nUDWhitePlayer = new System.Windows.Forms.NumericUpDown();
            this.nUDWhitePlayerElo = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nUDBlackPlayerElo = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nUDBlackPlayer = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nUDInitialRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDWhitePlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDWhitePlayerElo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDBlackPlayerElo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDBlackPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Initial Row";
            // 
            // nUDInitialRow
            // 
            this.nUDInitialRow.Location = new System.Drawing.Point(165, 42);
            this.nUDInitialRow.Name = "nUDInitialRow";
            this.nUDInitialRow.Size = new System.Drawing.Size(54, 20);
            this.nUDInitialRow.TabIndex = 1;
            this.nUDInitialRow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "White Player";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "COLUMNS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(90, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "ROWS";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // nUDWhitePlayer
            // 
            this.nUDWhitePlayer.Location = new System.Drawing.Point(165, 112);
            this.nUDWhitePlayer.Name = "nUDWhitePlayer";
            this.nUDWhitePlayer.Size = new System.Drawing.Size(54, 20);
            this.nUDWhitePlayer.TabIndex = 5;
            this.nUDWhitePlayer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nUDWhitePlayerElo
            // 
            this.nUDWhitePlayerElo.Location = new System.Drawing.Point(165, 138);
            this.nUDWhitePlayerElo.Name = "nUDWhitePlayerElo";
            this.nUDWhitePlayerElo.Size = new System.Drawing.Size(54, 20);
            this.nUDWhitePlayerElo.TabIndex = 7;
            this.nUDWhitePlayerElo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nUDWhitePlayerElo.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "White Player ELO";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // nUDBlackPlayerElo
            // 
            this.nUDBlackPlayerElo.Location = new System.Drawing.Point(165, 202);
            this.nUDBlackPlayerElo.Name = "nUDBlackPlayerElo";
            this.nUDBlackPlayerElo.Size = new System.Drawing.Size(54, 20);
            this.nUDBlackPlayerElo.TabIndex = 11;
            this.nUDBlackPlayerElo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Black Player ELO";
            // 
            // nUDBlackPlayer
            // 
            this.nUDBlackPlayer.Location = new System.Drawing.Point(165, 176);
            this.nUDBlackPlayer.Name = "nUDBlackPlayer";
            this.nUDBlackPlayer.Size = new System.Drawing.Size(54, 20);
            this.nUDBlackPlayer.TabIndex = 9;
            this.nUDBlackPlayer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Black Player";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "A=1; B=2; C=3; D=4; E=5; F=6; H=7 ...";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(54, 274);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(137, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 309);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nUDBlackPlayerElo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nUDBlackPlayer);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nUDWhitePlayerElo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nUDWhitePlayer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nUDInitialRow);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.nUDInitialRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDWhitePlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDWhitePlayerElo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDBlackPlayerElo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDBlackPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nUDInitialRow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nUDWhitePlayer;
        private System.Windows.Forms.NumericUpDown nUDWhitePlayerElo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nUDBlackPlayerElo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nUDBlackPlayer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSave;
    }
}