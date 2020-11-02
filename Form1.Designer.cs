namespace RacingAssessment
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
            this.pbx1 = new System.Windows.Forms.PictureBox();
            this.pbx4 = new System.Windows.Forms.PictureBox();
            this.pbx3 = new System.Windows.Forms.PictureBox();
            this.pbx2 = new System.Windows.Forms.PictureBox();
            this.udBet = new System.Windows.Forms.NumericUpDown();
            this.rbKaren = new System.Windows.Forms.RadioButton();
            this.rbBecky = new System.Windows.Forms.RadioButton();
            this.rbBrad = new System.Windows.Forms.RadioButton();
            this.rbJordan = new System.Windows.Forms.RadioButton();
            this.lblBetting = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnBet = new System.Windows.Forms.Button();
            this.lblWinner = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblParty = new System.Windows.Forms.Label();
            this.cbxParty = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblKaren = new System.Windows.Forms.Label();
            this.lblBecky = new System.Windows.Forms.Label();
            this.lblBrad = new System.Windows.Forms.Label();
            this.lblJordan = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udBet)).BeginInit();
            this.SuspendLayout();
            // 
            // pbx1
            // 
            this.pbx1.Location = new System.Drawing.Point(10, 10);
            this.pbx1.Name = "pbx1";
            this.pbx1.Size = new System.Drawing.Size(70, 70);
            this.pbx1.TabIndex = 0;
            this.pbx1.TabStop = false;
            // 
            // pbx4
            // 
            this.pbx4.Location = new System.Drawing.Point(10, 238);
            this.pbx4.Name = "pbx4";
            this.pbx4.Size = new System.Drawing.Size(70, 70);
            this.pbx4.TabIndex = 1;
            this.pbx4.TabStop = false;
            // 
            // pbx3
            // 
            this.pbx3.Location = new System.Drawing.Point(10, 162);
            this.pbx3.Name = "pbx3";
            this.pbx3.Size = new System.Drawing.Size(70, 70);
            this.pbx3.TabIndex = 2;
            this.pbx3.TabStop = false;
            // 
            // pbx2
            // 
            this.pbx2.Location = new System.Drawing.Point(10, 86);
            this.pbx2.Name = "pbx2";
            this.pbx2.Size = new System.Drawing.Size(70, 70);
            this.pbx2.TabIndex = 3;
            this.pbx2.TabStop = false;
            // 
            // udBet
            // 
            this.udBet.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.udBet.Location = new System.Drawing.Point(741, 408);
            this.udBet.Name = "udBet";
            this.udBet.Size = new System.Drawing.Size(85, 20);
            this.udBet.TabIndex = 4;
            // 
            // rbKaren
            // 
            this.rbKaren.AutoSize = true;
            this.rbKaren.Location = new System.Drawing.Point(362, 388);
            this.rbKaren.Name = "rbKaren";
            this.rbKaren.Size = new System.Drawing.Size(53, 17);
            this.rbKaren.TabIndex = 5;
            this.rbKaren.TabStop = true;
            this.rbKaren.Text = "Karen";
            this.rbKaren.UseVisualStyleBackColor = true;
            this.rbKaren.CheckedChanged += new System.EventHandler(this.AllRB_CheckedChanged);
            // 
            // rbBecky
            // 
            this.rbBecky.AutoSize = true;
            this.rbBecky.Location = new System.Drawing.Point(362, 409);
            this.rbBecky.Name = "rbBecky";
            this.rbBecky.Size = new System.Drawing.Size(55, 17);
            this.rbBecky.TabIndex = 6;
            this.rbBecky.TabStop = true;
            this.rbBecky.Text = "Becky";
            this.rbBecky.UseVisualStyleBackColor = true;
            this.rbBecky.CheckedChanged += new System.EventHandler(this.AllRB_CheckedChanged);
            // 
            // rbBrad
            // 
            this.rbBrad.AutoSize = true;
            this.rbBrad.Location = new System.Drawing.Point(362, 431);
            this.rbBrad.Name = "rbBrad";
            this.rbBrad.Size = new System.Drawing.Size(47, 17);
            this.rbBrad.TabIndex = 7;
            this.rbBrad.TabStop = true;
            this.rbBrad.Text = "Brad";
            this.rbBrad.UseVisualStyleBackColor = true;
            this.rbBrad.CheckedChanged += new System.EventHandler(this.AllRB_CheckedChanged);
            // 
            // rbJordan
            // 
            this.rbJordan.AutoSize = true;
            this.rbJordan.Location = new System.Drawing.Point(362, 452);
            this.rbJordan.Name = "rbJordan";
            this.rbJordan.Size = new System.Drawing.Size(57, 17);
            this.rbJordan.TabIndex = 8;
            this.rbJordan.TabStop = true;
            this.rbJordan.Text = "Jordan";
            this.rbJordan.UseVisualStyleBackColor = true;
            this.rbJordan.CheckedChanged += new System.EventHandler(this.AllRB_CheckedChanged);
            // 
            // lblBetting
            // 
            this.lblBetting.AutoSize = true;
            this.lblBetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBetting.Location = new System.Drawing.Point(358, 354);
            this.lblBetting.Name = "lblBetting";
            this.lblBetting.Size = new System.Drawing.Size(86, 25);
            this.lblBetting.TabIndex = 9;
            this.lblBetting.Text = "Betting";
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.PaleGreen;
            this.btnGo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnGo.Location = new System.Drawing.Point(3, 369);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(70, 70);
            this.btnGo.TabIndex = 10;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.LightSalmon;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Red;
            this.btnReset.Location = new System.Drawing.Point(93, 369);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(70, 70);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = " Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnBet
            // 
            this.btnBet.BackColor = System.Drawing.Color.Gold;
            this.btnBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBet.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnBet.Location = new System.Drawing.Point(896, 388);
            this.btnBet.Name = "btnBet";
            this.btnBet.Size = new System.Drawing.Size(90, 90);
            this.btnBet.TabIndex = 13;
            this.btnBet.Text = "Place Bet";
            this.btnBet.UseVisualStyleBackColor = false;
            this.btnBet.Click += new System.EventHandler(this.btnBet_Click);
            // 
            // lblWinner
            // 
            this.lblWinner.BackColor = System.Drawing.SystemColors.Window;
            this.lblWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.Location = new System.Drawing.Point(205, 385);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(100, 54);
            this.lblWinner.TabIndex = 14;
            this.lblWinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(204, 354);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(93, 25);
            this.lblResults.TabIndex = 15;
            this.lblResults.Text = "Winner:";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(738, 390);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(43, 13);
            this.lblAmount.TabIndex = 16;
            this.lblAmount.Text = "Amount";
            // 
            // lblParty
            // 
            this.lblParty.AutoSize = true;
            this.lblParty.Location = new System.Drawing.Point(738, 438);
            this.lblParty.Name = "lblParty";
            this.lblParty.Size = new System.Drawing.Size(31, 13);
            this.lblParty.TabIndex = 17;
            this.lblParty.Text = "Party";
            // 
            // cbxParty
            // 
            this.cbxParty.FormattingEnabled = true;
            this.cbxParty.Items.AddRange(new object[] {
            "Labour",
            "National",
            "Act",
            "NZ First"});
            this.cbxParty.Location = new System.Drawing.Point(741, 455);
            this.cbxParty.Name = "cbxParty";
            this.cbxParty.Size = new System.Drawing.Size(121, 21);
            this.cbxParty.TabIndex = 18;
            this.cbxParty.Text = "Select a party...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(804, 390);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Max Bet:";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(860, 390);
            this.lblMax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(10, 13);
            this.lblMax.TabIndex = 20;
            this.lblMax.Text = "-";
            // 
            // lblKaren
            // 
            this.lblKaren.BackColor = System.Drawing.Color.White;
            this.lblKaren.Location = new System.Drawing.Point(428, 385);
            this.lblKaren.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKaren.Name = "lblKaren";
            this.lblKaren.Size = new System.Drawing.Size(293, 18);
            this.lblKaren.TabIndex = 21;
            // 
            // lblBecky
            // 
            this.lblBecky.BackColor = System.Drawing.Color.White;
            this.lblBecky.Location = new System.Drawing.Point(428, 406);
            this.lblBecky.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBecky.Name = "lblBecky";
            this.lblBecky.Size = new System.Drawing.Size(293, 18);
            this.lblBecky.TabIndex = 22;
            // 
            // lblBrad
            // 
            this.lblBrad.BackColor = System.Drawing.Color.White;
            this.lblBrad.Location = new System.Drawing.Point(428, 427);
            this.lblBrad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBrad.Name = "lblBrad";
            this.lblBrad.Size = new System.Drawing.Size(293, 18);
            this.lblBrad.TabIndex = 23;
            // 
            // lblJordan
            // 
            this.lblJordan.BackColor = System.Drawing.Color.White;
            this.lblJordan.Location = new System.Drawing.Point(428, 449);
            this.lblJordan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJordan.Name = "lblJordan";
            this.lblJordan.Size = new System.Drawing.Size(293, 18);
            this.lblJordan.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1040, 494);
            this.Controls.Add(this.lblJordan);
            this.Controls.Add(this.lblBrad);
            this.Controls.Add(this.lblBecky);
            this.Controls.Add(this.lblKaren);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxParty);
            this.Controls.Add(this.lblParty);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.btnBet);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.lblBetting);
            this.Controls.Add(this.rbJordan);
            this.Controls.Add(this.rbBrad);
            this.Controls.Add(this.rbBecky);
            this.Controls.Add(this.rbKaren);
            this.Controls.Add(this.udBet);
            this.Controls.Add(this.pbx2);
            this.Controls.Add(this.pbx3);
            this.Controls.Add(this.pbx4);
            this.Controls.Add(this.pbx1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udBet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx1;
        private System.Windows.Forms.PictureBox pbx4;
        private System.Windows.Forms.PictureBox pbx3;
        private System.Windows.Forms.PictureBox pbx2;
        private System.Windows.Forms.NumericUpDown udBet;
        private System.Windows.Forms.RadioButton rbKaren;
        private System.Windows.Forms.RadioButton rbBecky;
        private System.Windows.Forms.RadioButton rbBrad;
        private System.Windows.Forms.RadioButton rbJordan;
        private System.Windows.Forms.Label lblBetting;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnBet;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblParty;
        private System.Windows.Forms.ComboBox cbxParty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblKaren;
        private System.Windows.Forms.Label lblBecky;
        private System.Windows.Forms.Label lblBrad;
        private System.Windows.Forms.Label lblJordan;
    }
}

