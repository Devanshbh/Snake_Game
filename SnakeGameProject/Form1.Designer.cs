namespace SnakeGameProject
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
            this.btnStart = new System.Windows.Forms.Button();
            this.pbPlayArea = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.ColDialog = new System.Windows.Forms.ColorDialog();
            this.btnChangeCol = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.gbSpeed = new System.Windows.Forms.GroupBox();
            this.rbDefaultSpeed = new System.Windows.Forms.RadioButton();
            this.rb100Interval = new System.Windows.Forms.RadioButton();
            this.rb150Interval = new System.Windows.Forms.RadioButton();
            this.btnChangeSpeed = new System.Windows.Forms.Button();
            this.lblSoloHighScore = new System.Windows.Forms.Label();
            this.txtSoloHighScore = new System.Windows.Forms.TextBox();
            this.rbApple = new System.Windows.Forms.RadioButton();
            this.rbSnake = new System.Windows.Forms.RadioButton();
            this.gbColChange = new System.Windows.Forms.GroupBox();
            this.btnColReset = new System.Windows.Forms.Button();
            this.rbSnakeP2 = new System.Windows.Forms.RadioButton();
            this.gbPlayerMode = new System.Windows.Forms.GroupBox();
            this.rbSinglePlayer = new System.Windows.Forms.RadioButton();
            this.rb2Player = new System.Windows.Forms.RadioButton();
            this.txtSoloRoundScore = new System.Windows.Forms.TextBox();
            this.gbSoloScore = new System.Windows.Forms.GroupBox();
            this.lblRoundScore = new System.Windows.Forms.Label();
            this.gb2PScore = new System.Windows.Forms.GroupBox();
            this.lblP2Wins = new System.Windows.Forms.Label();
            this.lblTies = new System.Windows.Forms.Label();
            this.lblP1Wins = new System.Windows.Forms.Label();
            this.btn2PResetScore = new System.Windows.Forms.Button();
            this.txtTies = new System.Windows.Forms.TextBox();
            this.txtP1Wins = new System.Windows.Forms.TextBox();
            this.txtP2Wins = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayArea)).BeginInit();
            this.gbSpeed.SuspendLayout();
            this.gbColChange.SuspendLayout();
            this.gbPlayerMode.SuspendLayout();
            this.gbSoloScore.SuspendLayout();
            this.gb2PScore.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(636, 52);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(81, 33);
            this.btnStart.TabIndex = 0;
            this.btnStart.TabStop = false;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pbPlayArea
            // 
            this.pbPlayArea.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbPlayArea.Location = new System.Drawing.Point(12, 10);
            this.pbPlayArea.Name = "pbPlayArea";
            this.pbPlayArea.Size = new System.Drawing.Size(600, 600);
            this.pbPlayArea.TabIndex = 1;
            this.pbPlayArea.TabStop = false;
            this.pbPlayArea.Paint += new System.Windows.Forms.PaintEventHandler(this.pbPlayArea_Paint);
            // 
            // timer
            // 
            this.timer.Interval = 200;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnChangeCol
            // 
            this.btnChangeCol.Location = new System.Drawing.Point(9, 19);
            this.btnChangeCol.Name = "btnChangeCol";
            this.btnChangeCol.Size = new System.Drawing.Size(124, 37);
            this.btnChangeCol.TabIndex = 2;
            this.btnChangeCol.TabStop = false;
            this.btnChangeCol.Text = "Change Colour";
            this.btnChangeCol.UseVisualStyleBackColor = true;
            this.btnChangeCol.Click += new System.EventHandler(this.btnChangeCol_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(636, 92);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(186, 33);
            this.btnPause.TabIndex = 3;
            this.btnPause.TabStop = false;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(741, 53);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(81, 33);
            this.btnReset.TabIndex = 4;
            this.btnReset.TabStop = false;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // gbSpeed
            // 
            this.gbSpeed.Controls.Add(this.rbDefaultSpeed);
            this.gbSpeed.Controls.Add(this.rb100Interval);
            this.gbSpeed.Controls.Add(this.rb150Interval);
            this.gbSpeed.Controls.Add(this.btnChangeSpeed);
            this.gbSpeed.Location = new System.Drawing.Point(663, 148);
            this.gbSpeed.Name = "gbSpeed";
            this.gbSpeed.Size = new System.Drawing.Size(139, 126);
            this.gbSpeed.TabIndex = 5;
            this.gbSpeed.TabStop = false;
            this.gbSpeed.Text = "Change Speed";
            // 
            // rbDefaultSpeed
            // 
            this.rbDefaultSpeed.AutoSize = true;
            this.rbDefaultSpeed.Location = new System.Drawing.Point(30, 19);
            this.rbDefaultSpeed.Name = "rbDefaultSpeed";
            this.rbDefaultSpeed.Size = new System.Drawing.Size(36, 17);
            this.rbDefaultSpeed.TabIndex = 9;
            this.rbDefaultSpeed.Text = "1x";
            this.rbDefaultSpeed.UseVisualStyleBackColor = true;
            this.rbDefaultSpeed.CheckedChanged += new System.EventHandler(this.rbDefaultSpeed_CheckedChanged);
            // 
            // rb100Interval
            // 
            this.rb100Interval.AutoSize = true;
            this.rb100Interval.Location = new System.Drawing.Point(30, 64);
            this.rb100Interval.Name = "rb100Interval";
            this.rb100Interval.Size = new System.Drawing.Size(39, 17);
            this.rb100Interval.TabIndex = 8;
            this.rb100Interval.Text = "2x ";
            this.rb100Interval.UseVisualStyleBackColor = true;
            this.rb100Interval.CheckedChanged += new System.EventHandler(this.rb100Interval_CheckedChanged);
            // 
            // rb150Interval
            // 
            this.rb150Interval.AutoSize = true;
            this.rb150Interval.Location = new System.Drawing.Point(30, 41);
            this.rb150Interval.Name = "rb150Interval";
            this.rb150Interval.Size = new System.Drawing.Size(45, 17);
            this.rb150Interval.TabIndex = 7;
            this.rb150Interval.Text = "1.5x";
            this.rb150Interval.UseVisualStyleBackColor = true;
            this.rb150Interval.CheckedChanged += new System.EventHandler(this.rb150Interval_CheckedChanged);
            // 
            // btnChangeSpeed
            // 
            this.btnChangeSpeed.Enabled = false;
            this.btnChangeSpeed.Location = new System.Drawing.Point(18, 87);
            this.btnChangeSpeed.Name = "btnChangeSpeed";
            this.btnChangeSpeed.Size = new System.Drawing.Size(98, 33);
            this.btnChangeSpeed.TabIndex = 6;
            this.btnChangeSpeed.TabStop = false;
            this.btnChangeSpeed.Text = "Change Speed";
            this.btnChangeSpeed.UseVisualStyleBackColor = true;
            this.btnChangeSpeed.Click += new System.EventHandler(this.btnChangeSpeed_Click);
            // 
            // lblSoloHighScore
            // 
            this.lblSoloHighScore.AutoSize = true;
            this.lblSoloHighScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblSoloHighScore.Location = new System.Drawing.Point(6, 18);
            this.lblSoloHighScore.Name = "lblSoloHighScore";
            this.lblSoloHighScore.Size = new System.Drawing.Size(63, 15);
            this.lblSoloHighScore.TabIndex = 0;
            this.lblSoloHighScore.Text = "Highscore";
            // 
            // txtSoloHighScore
            // 
            this.txtSoloHighScore.Location = new System.Drawing.Point(88, 18);
            this.txtSoloHighScore.Name = "txtSoloHighScore";
            this.txtSoloHighScore.ReadOnly = true;
            this.txtSoloHighScore.Size = new System.Drawing.Size(51, 20);
            this.txtSoloHighScore.TabIndex = 6;
            this.txtSoloHighScore.TabStop = false;
            this.txtSoloHighScore.Text = "1";
            // 
            // rbApple
            // 
            this.rbApple.AutoSize = true;
            this.rbApple.Location = new System.Drawing.Point(89, 68);
            this.rbApple.Name = "rbApple";
            this.rbApple.Size = new System.Drawing.Size(52, 17);
            this.rbApple.TabIndex = 10;
            this.rbApple.Text = "Apple";
            this.rbApple.UseVisualStyleBackColor = true;
            // 
            // rbSnake
            // 
            this.rbSnake.AutoSize = true;
            this.rbSnake.Location = new System.Drawing.Point(13, 68);
            this.rbSnake.Name = "rbSnake";
            this.rbSnake.Size = new System.Drawing.Size(56, 17);
            this.rbSnake.TabIndex = 11;
            this.rbSnake.Text = "Snake";
            this.rbSnake.UseVisualStyleBackColor = true;
            // 
            // gbColChange
            // 
            this.gbColChange.Controls.Add(this.btnColReset);
            this.gbColChange.Controls.Add(this.rbSnakeP2);
            this.gbColChange.Controls.Add(this.rbSnake);
            this.gbColChange.Controls.Add(this.rbApple);
            this.gbColChange.Controls.Add(this.btnChangeCol);
            this.gbColChange.Location = new System.Drawing.Point(663, 296);
            this.gbColChange.Name = "gbColChange";
            this.gbColChange.Size = new System.Drawing.Size(159, 145);
            this.gbColChange.TabIndex = 12;
            this.gbColChange.TabStop = false;
            this.gbColChange.Text = "Change Colour";
            // 
            // btnColReset
            // 
            this.btnColReset.Location = new System.Drawing.Point(6, 110);
            this.btnColReset.Name = "btnColReset";
            this.btnColReset.Size = new System.Drawing.Size(124, 29);
            this.btnColReset.TabIndex = 13;
            this.btnColReset.TabStop = false;
            this.btnColReset.Text = "Reset Colours";
            this.btnColReset.UseVisualStyleBackColor = true;
            this.btnColReset.Click += new System.EventHandler(this.btnColReset_Click);
            // 
            // rbSnakeP2
            // 
            this.rbSnakeP2.AutoSize = true;
            this.rbSnakeP2.Location = new System.Drawing.Point(13, 87);
            this.rbSnakeP2.Name = "rbSnakeP2";
            this.rbSnakeP2.Size = new System.Drawing.Size(72, 17);
            this.rbSnakeP2.TabIndex = 12;
            this.rbSnakeP2.Text = "Snake P2";
            this.rbSnakeP2.UseVisualStyleBackColor = true;
            this.rbSnakeP2.Visible = false;
            // 
            // gbPlayerMode
            // 
            this.gbPlayerMode.Controls.Add(this.rbSinglePlayer);
            this.gbPlayerMode.Controls.Add(this.rb2Player);
            this.gbPlayerMode.Location = new System.Drawing.Point(663, 447);
            this.gbPlayerMode.Name = "gbPlayerMode";
            this.gbPlayerMode.Size = new System.Drawing.Size(139, 72);
            this.gbPlayerMode.TabIndex = 14;
            this.gbPlayerMode.TabStop = false;
            this.gbPlayerMode.Text = "Player Mode";
            // 
            // rbSinglePlayer
            // 
            this.rbSinglePlayer.AutoSize = true;
            this.rbSinglePlayer.Location = new System.Drawing.Point(18, 19);
            this.rbSinglePlayer.Name = "rbSinglePlayer";
            this.rbSinglePlayer.Size = new System.Drawing.Size(86, 17);
            this.rbSinglePlayer.TabIndex = 1;
            this.rbSinglePlayer.Text = "Single Player";
            this.rbSinglePlayer.UseVisualStyleBackColor = true;
            this.rbSinglePlayer.CheckedChanged += new System.EventHandler(this.rbSinglePlayer_CheckedChanged);
            // 
            // rb2Player
            // 
            this.rb2Player.AutoSize = true;
            this.rb2Player.Location = new System.Drawing.Point(18, 42);
            this.rb2Player.Name = "rb2Player";
            this.rb2Player.Size = new System.Drawing.Size(63, 17);
            this.rb2Player.TabIndex = 14;
            this.rb2Player.Text = "2 Player";
            this.rb2Player.UseVisualStyleBackColor = true;
            this.rb2Player.CheckedChanged += new System.EventHandler(this.rb2Player_CheckedChanged);
            // 
            // txtSoloRoundScore
            // 
            this.txtSoloRoundScore.Location = new System.Drawing.Point(88, 52);
            this.txtSoloRoundScore.Name = "txtSoloRoundScore";
            this.txtSoloRoundScore.ReadOnly = true;
            this.txtSoloRoundScore.Size = new System.Drawing.Size(42, 20);
            this.txtSoloRoundScore.TabIndex = 15;
            this.txtSoloRoundScore.TabStop = false;
            this.txtSoloRoundScore.Text = "1";
            // 
            // gbSoloScore
            // 
            this.gbSoloScore.Controls.Add(this.lblRoundScore);
            this.gbSoloScore.Controls.Add(this.lblSoloHighScore);
            this.gbSoloScore.Controls.Add(this.txtSoloHighScore);
            this.gbSoloScore.Controls.Add(this.txtSoloRoundScore);
            this.gbSoloScore.Location = new System.Drawing.Point(865, 53);
            this.gbSoloScore.Name = "gbSoloScore";
            this.gbSoloScore.Size = new System.Drawing.Size(139, 85);
            this.gbSoloScore.TabIndex = 19;
            this.gbSoloScore.TabStop = false;
            this.gbSoloScore.Text = "Solo Scoreboard";
            // 
            // lblRoundScore
            // 
            this.lblRoundScore.AutoSize = true;
            this.lblRoundScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblRoundScore.Location = new System.Drawing.Point(6, 52);
            this.lblRoundScore.Name = "lblRoundScore";
            this.lblRoundScore.Size = new System.Drawing.Size(79, 15);
            this.lblRoundScore.TabIndex = 17;
            this.lblRoundScore.Text = "Round Score";
            // 
            // gb2PScore
            // 
            this.gb2PScore.Controls.Add(this.lblP2Wins);
            this.gb2PScore.Controls.Add(this.lblTies);
            this.gb2PScore.Controls.Add(this.lblP1Wins);
            this.gb2PScore.Controls.Add(this.btn2PResetScore);
            this.gb2PScore.Controls.Add(this.txtTies);
            this.gb2PScore.Controls.Add(this.txtP1Wins);
            this.gb2PScore.Controls.Add(this.txtP2Wins);
            this.gb2PScore.Location = new System.Drawing.Point(865, 157);
            this.gb2PScore.Name = "gb2PScore";
            this.gb2PScore.Size = new System.Drawing.Size(139, 166);
            this.gb2PScore.TabIndex = 20;
            this.gb2PScore.TabStop = false;
            this.gb2PScore.Text = "2P Scoreboard";
            this.gb2PScore.Visible = false;
            // 
            // lblP2Wins
            // 
            this.lblP2Wins.AutoSize = true;
            this.lblP2Wins.Location = new System.Drawing.Point(13, 59);
            this.lblP2Wins.Name = "lblP2Wins";
            this.lblP2Wins.Size = new System.Drawing.Size(47, 13);
            this.lblP2Wins.TabIndex = 19;
            this.lblP2Wins.Text = "P2 Wins";
            // 
            // lblTies
            // 
            this.lblTies.AutoSize = true;
            this.lblTies.Location = new System.Drawing.Point(13, 94);
            this.lblTies.Name = "lblTies";
            this.lblTies.Size = new System.Drawing.Size(27, 13);
            this.lblTies.TabIndex = 18;
            this.lblTies.Text = "Ties";
            // 
            // lblP1Wins
            // 
            this.lblP1Wins.AutoSize = true;
            this.lblP1Wins.Location = new System.Drawing.Point(13, 29);
            this.lblP1Wins.Name = "lblP1Wins";
            this.lblP1Wins.Size = new System.Drawing.Size(47, 13);
            this.lblP1Wins.TabIndex = 17;
            this.lblP1Wins.Text = "P1 Wins";
            // 
            // btn2PResetScore
            // 
            this.btn2PResetScore.Enabled = false;
            this.btn2PResetScore.Location = new System.Drawing.Point(13, 126);
            this.btn2PResetScore.Name = "btn2PResetScore";
            this.btn2PResetScore.Size = new System.Drawing.Size(117, 29);
            this.btn2PResetScore.TabIndex = 14;
            this.btn2PResetScore.Text = "Reset Scores";
            this.btn2PResetScore.UseVisualStyleBackColor = true;
            this.btn2PResetScore.Click += new System.EventHandler(this.btn2PResetScore_Click);
            // 
            // txtTies
            // 
            this.txtTies.Location = new System.Drawing.Point(88, 91);
            this.txtTies.Name = "txtTies";
            this.txtTies.ReadOnly = true;
            this.txtTies.Size = new System.Drawing.Size(42, 20);
            this.txtTies.TabIndex = 16;
            this.txtTies.TabStop = false;
            this.txtTies.Text = "0";
            // 
            // txtP1Wins
            // 
            this.txtP1Wins.Location = new System.Drawing.Point(88, 26);
            this.txtP1Wins.Name = "txtP1Wins";
            this.txtP1Wins.ReadOnly = true;
            this.txtP1Wins.Size = new System.Drawing.Size(42, 20);
            this.txtP1Wins.TabIndex = 6;
            this.txtP1Wins.TabStop = false;
            this.txtP1Wins.Text = "0";
            // 
            // txtP2Wins
            // 
            this.txtP2Wins.Location = new System.Drawing.Point(88, 56);
            this.txtP2Wins.Name = "txtP2Wins";
            this.txtP2Wins.ReadOnly = true;
            this.txtP2Wins.Size = new System.Drawing.Size(42, 20);
            this.txtP2Wins.TabIndex = 15;
            this.txtP2Wins.TabStop = false;
            this.txtP2Wins.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1045, 622);
            this.Controls.Add(this.gb2PScore);
            this.Controls.Add(this.gbSoloScore);
            this.Controls.Add(this.gbPlayerMode);
            this.Controls.Add(this.gbColChange);
            this.Controls.Add(this.gbSpeed);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.pbPlayArea);
            this.Controls.Add(this.btnStart);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Snake Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing_1);
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayArea)).EndInit();
            this.gbSpeed.ResumeLayout(false);
            this.gbSpeed.PerformLayout();
            this.gbColChange.ResumeLayout(false);
            this.gbColChange.PerformLayout();
            this.gbPlayerMode.ResumeLayout(false);
            this.gbPlayerMode.PerformLayout();
            this.gbSoloScore.ResumeLayout(false);
            this.gbSoloScore.PerformLayout();
            this.gb2PScore.ResumeLayout(false);
            this.gb2PScore.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox pbPlayArea;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ColorDialog ColDialog;
        private System.Windows.Forms.Button btnChangeCol;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox gbSpeed;
        private System.Windows.Forms.RadioButton rb100Interval;
        private System.Windows.Forms.RadioButton rb150Interval;
        private System.Windows.Forms.Button btnChangeSpeed;
        private System.Windows.Forms.RadioButton rbDefaultSpeed;
        private System.Windows.Forms.Label lblSoloHighScore;
        private System.Windows.Forms.TextBox txtSoloHighScore;
        private System.Windows.Forms.RadioButton rbApple;
        private System.Windows.Forms.RadioButton rbSnake;
        private System.Windows.Forms.GroupBox gbColChange;
        private System.Windows.Forms.GroupBox gbPlayerMode;
        private System.Windows.Forms.RadioButton rbSinglePlayer;
        private System.Windows.Forms.RadioButton rb2Player;
        private System.Windows.Forms.RadioButton rbSnakeP2;
        private System.Windows.Forms.Button btnColReset;
        private System.Windows.Forms.TextBox txtSoloRoundScore;
        private System.Windows.Forms.GroupBox gbSoloScore;
        private System.Windows.Forms.GroupBox gb2PScore;
        private System.Windows.Forms.TextBox txtP1Wins;
        private System.Windows.Forms.TextBox txtP2Wins;
        private System.Windows.Forms.Label lblP2Wins;
        private System.Windows.Forms.Label lblTies;
        private System.Windows.Forms.Label lblP1Wins;
        private System.Windows.Forms.Button btn2PResetScore;
        private System.Windows.Forms.TextBox txtTies;
        private System.Windows.Forms.Label lblRoundScore;
    }
}

