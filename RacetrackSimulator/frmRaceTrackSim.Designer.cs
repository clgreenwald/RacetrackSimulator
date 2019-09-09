namespace RacetrackSimulator
{
    partial class frmRaceTrackSim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRaceTrackSim));
            this.pbRacetrack = new System.Windows.Forms.PictureBox();
            this.pbDog1 = new System.Windows.Forms.PictureBox();
            this.pbDog2 = new System.Windows.Forms.PictureBox();
            this.pbDog3 = new System.Windows.Forms.PictureBox();
            this.pbDog4 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMinBet = new System.Windows.Forms.Label();
            this.rdoJoe = new System.Windows.Forms.RadioButton();
            this.rdoBob = new System.Windows.Forms.RadioButton();
            this.rdoAl = new System.Windows.Forms.RadioButton();
            this.lblBettor = new System.Windows.Forms.Label();
            this.btnBets = new System.Windows.Forms.Button();
            this.nudBetAmt = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nudDogNum = new System.Windows.Forms.NumericUpDown();
            this.btnRace = new System.Windows.Forms.Button();
            this.lblBets = new System.Windows.Forms.Label();
            this.lblJoeBet = new System.Windows.Forms.Label();
            this.lblBobBet = new System.Windows.Forms.Label();
            this.lblAlBet = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbRacetrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog4)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBetAmt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDogNum)).BeginInit();
            this.SuspendLayout();
            // 
            // pbRacetrack
            // 
            this.pbRacetrack.Image = ((System.Drawing.Image)(resources.GetObject("pbRacetrack.Image")));
            this.pbRacetrack.Location = new System.Drawing.Point(12, 12);
            this.pbRacetrack.Name = "pbRacetrack";
            this.pbRacetrack.Size = new System.Drawing.Size(682, 230);
            this.pbRacetrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRacetrack.TabIndex = 0;
            this.pbRacetrack.TabStop = false;
            // 
            // pbDog1
            // 
            this.pbDog1.Image = ((System.Drawing.Image)(resources.GetObject("pbDog1.Image")));
            this.pbDog1.Location = new System.Drawing.Point(15, 24);
            this.pbDog1.Name = "pbDog1";
            this.pbDog1.Size = new System.Drawing.Size(100, 24);
            this.pbDog1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDog1.TabIndex = 1;
            this.pbDog1.TabStop = false;
            // 
            // pbDog2
            // 
            this.pbDog2.Image = ((System.Drawing.Image)(resources.GetObject("pbDog2.Image")));
            this.pbDog2.Location = new System.Drawing.Point(15, 76);
            this.pbDog2.Name = "pbDog2";
            this.pbDog2.Size = new System.Drawing.Size(100, 24);
            this.pbDog2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDog2.TabIndex = 2;
            this.pbDog2.TabStop = false;
            // 
            // pbDog3
            // 
            this.pbDog3.Image = ((System.Drawing.Image)(resources.GetObject("pbDog3.Image")));
            this.pbDog3.Location = new System.Drawing.Point(15, 136);
            this.pbDog3.Name = "pbDog3";
            this.pbDog3.Size = new System.Drawing.Size(100, 24);
            this.pbDog3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDog3.TabIndex = 3;
            this.pbDog3.TabStop = false;
            // 
            // pbDog4
            // 
            this.pbDog4.Image = ((System.Drawing.Image)(resources.GetObject("pbDog4.Image")));
            this.pbDog4.Location = new System.Drawing.Point(15, 196);
            this.pbDog4.Name = "pbDog4";
            this.pbDog4.Size = new System.Drawing.Size(100, 24);
            this.pbDog4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDog4.TabIndex = 4;
            this.pbDog4.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAlBet);
            this.groupBox1.Controls.Add(this.lblBobBet);
            this.groupBox1.Controls.Add(this.lblJoeBet);
            this.groupBox1.Controls.Add(this.lblBets);
            this.groupBox1.Controls.Add(this.btnRace);
            this.groupBox1.Controls.Add(this.nudDogNum);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nudBetAmt);
            this.groupBox1.Controls.Add(this.btnBets);
            this.groupBox1.Controls.Add(this.lblBettor);
            this.groupBox1.Controls.Add(this.rdoAl);
            this.groupBox1.Controls.Add(this.rdoBob);
            this.groupBox1.Controls.Add(this.rdoJoe);
            this.groupBox1.Controls.Add(this.lblMinBet);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 264);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(683, 176);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Betting Parlor";
            // 
            // lblMinBet
            // 
            this.lblMinBet.AutoSize = true;
            this.lblMinBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinBet.Location = new System.Drawing.Point(7, 26);
            this.lblMinBet.Name = "lblMinBet";
            this.lblMinBet.Size = new System.Drawing.Size(117, 20);
            this.lblMinBet.TabIndex = 0;
            this.lblMinBet.Text = "Minimum Bet:";
            // 
            // rdoJoe
            // 
            this.rdoJoe.AutoSize = true;
            this.rdoJoe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoJoe.Location = new System.Drawing.Point(11, 50);
            this.rdoJoe.Name = "rdoJoe";
            this.rdoJoe.Size = new System.Drawing.Size(49, 20);
            this.rdoJoe.TabIndex = 1;
            this.rdoJoe.TabStop = true;
            this.rdoJoe.Text = "Joe";
            this.rdoJoe.UseVisualStyleBackColor = true;
            this.rdoJoe.CheckedChanged += new System.EventHandler(this.rdoJoe_CheckedChanged);
            // 
            // rdoBob
            // 
            this.rdoBob.AutoSize = true;
            this.rdoBob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBob.Location = new System.Drawing.Point(11, 76);
            this.rdoBob.Name = "rdoBob";
            this.rdoBob.Size = new System.Drawing.Size(51, 20);
            this.rdoBob.TabIndex = 2;
            this.rdoBob.TabStop = true;
            this.rdoBob.Text = "Bob";
            this.rdoBob.UseVisualStyleBackColor = true;
            this.rdoBob.CheckedChanged += new System.EventHandler(this.rdoBob_CheckedChanged);
            // 
            // rdoAl
            // 
            this.rdoAl.AutoSize = true;
            this.rdoAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoAl.Location = new System.Drawing.Point(11, 102);
            this.rdoAl.Name = "rdoAl";
            this.rdoAl.Size = new System.Drawing.Size(38, 20);
            this.rdoAl.TabIndex = 3;
            this.rdoAl.TabStop = true;
            this.rdoAl.Text = "Al";
            this.rdoAl.UseVisualStyleBackColor = true;
            this.rdoAl.CheckedChanged += new System.EventHandler(this.rdoAl_CheckedChanged);
            // 
            // lblBettor
            // 
            this.lblBettor.AutoSize = true;
            this.lblBettor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBettor.Location = new System.Drawing.Point(8, 137);
            this.lblBettor.Name = "lblBettor";
            this.lblBettor.Size = new System.Drawing.Size(43, 16);
            this.lblBettor.TabIndex = 4;
            this.lblBettor.Text = "Bettor";
            // 
            // btnBets
            // 
            this.btnBets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBets.Location = new System.Drawing.Point(56, 133);
            this.btnBets.Name = "btnBets";
            this.btnBets.Size = new System.Drawing.Size(75, 25);
            this.btnBets.TabIndex = 5;
            this.btnBets.Text = "Bets";
            this.btnBets.UseVisualStyleBackColor = true;
            this.btnBets.Click += new System.EventHandler(this.btnBets_Click);
            // 
            // nudBetAmt
            // 
            this.nudBetAmt.Location = new System.Drawing.Point(153, 132);
            this.nudBetAmt.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudBetAmt.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudBetAmt.Name = "nudBetAmt";
            this.nudBetAmt.Size = new System.Drawing.Size(68, 26);
            this.nudBetAmt.TabIndex = 6;
            this.nudBetAmt.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "bucks on dog number";
            // 
            // nudDogNum
            // 
            this.nudDogNum.Location = new System.Drawing.Point(383, 132);
            this.nudDogNum.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudDogNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDogNum.Name = "nudDogNum";
            this.nudDogNum.Size = new System.Drawing.Size(62, 26);
            this.nudDogNum.TabIndex = 8;
            this.nudDogNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnRace
            // 
            this.btnRace.Location = new System.Drawing.Point(554, 133);
            this.btnRace.Name = "btnRace";
            this.btnRace.Size = new System.Drawing.Size(123, 37);
            this.btnRace.TabIndex = 9;
            this.btnRace.Text = "Race!";
            this.btnRace.UseVisualStyleBackColor = true;
            this.btnRace.Click += new System.EventHandler(this.btnRace_Click);
            // 
            // lblBets
            // 
            this.lblBets.AutoSize = true;
            this.lblBets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBets.Location = new System.Drawing.Point(379, 26);
            this.lblBets.Name = "lblBets";
            this.lblBets.Size = new System.Drawing.Size(46, 20);
            this.lblBets.TabIndex = 10;
            this.lblBets.Text = "Bets";
            // 
            // lblJoeBet
            // 
            this.lblJoeBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblJoeBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJoeBet.Location = new System.Drawing.Point(380, 51);
            this.lblJoeBet.Name = "lblJoeBet";
            this.lblJoeBet.Size = new System.Drawing.Size(297, 18);
            this.lblJoeBet.TabIndex = 11;
            this.lblJoeBet.Text = "Joe\'s Bet";
            // 
            // lblBobBet
            // 
            this.lblBobBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBobBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBobBet.Location = new System.Drawing.Point(380, 77);
            this.lblBobBet.Name = "lblBobBet";
            this.lblBobBet.Size = new System.Drawing.Size(297, 18);
            this.lblBobBet.TabIndex = 12;
            this.lblBobBet.Text = "Bob\'s Bet";
            // 
            // lblAlBet
            // 
            this.lblAlBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAlBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlBet.Location = new System.Drawing.Point(380, 103);
            this.lblAlBet.Name = "lblAlBet";
            this.lblAlBet.Size = new System.Drawing.Size(297, 18);
            this.lblAlBet.TabIndex = 13;
            this.lblAlBet.Text = "Al\'s Bet";
            // 
            // frmRaceTrackSim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 455);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbDog4);
            this.Controls.Add(this.pbDog3);
            this.Controls.Add(this.pbDog2);
            this.Controls.Add(this.pbDog1);
            this.Controls.Add(this.pbRacetrack);
            this.Name = "frmRaceTrackSim";
            this.Text = "A Day at the Races";
            this.Load += new System.EventHandler(this.frmRaceTrackSim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbRacetrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBetAmt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDogNum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbRacetrack;
        private System.Windows.Forms.PictureBox pbDog1;
        private System.Windows.Forms.PictureBox pbDog2;
        private System.Windows.Forms.PictureBox pbDog3;
        private System.Windows.Forms.PictureBox pbDog4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAlBet;
        private System.Windows.Forms.Label lblBobBet;
        private System.Windows.Forms.Label lblJoeBet;
        private System.Windows.Forms.Label lblBets;
        private System.Windows.Forms.Button btnRace;
        private System.Windows.Forms.NumericUpDown nudDogNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudBetAmt;
        private System.Windows.Forms.Button btnBets;
        private System.Windows.Forms.Label lblBettor;
        private System.Windows.Forms.RadioButton rdoAl;
        private System.Windows.Forms.RadioButton rdoBob;
        private System.Windows.Forms.RadioButton rdoJoe;
        private System.Windows.Forms.Label lblMinBet;
    }
}

