
namespace Universe_on_fire
{
    partial class UniverseOnFire
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UniverseOnFire));
            this.txtAmmo = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.Label();
            this.txtHealth = new System.Windows.Forms.Label();
            this.healthBar = new System.Windows.Forms.ProgressBar();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.player = new System.Windows.Forms.PictureBox();
            this.panelPauseMenu = new System.Windows.Forms.Panel();
            this.txtPauseM = new System.Windows.Forms.Label();
            this.txtPauseResume = new System.Windows.Forms.Label();
            this.txtPauseHelp = new System.Windows.Forms.Label();
            this.txtPauseExit = new System.Windows.Forms.Label();
            this.txtPauseHistory = new System.Windows.Forms.Label();
            this.panelGameOver = new System.Windows.Forms.Panel();
            this.txtGameIsOver = new System.Windows.Forms.Label();
            this.txtRestart = new System.Windows.Forms.Label();
            this.txtGOScore = new System.Windows.Forms.Label();
            this.panelSettings = new System.Windows.Forms.Panel();
            this.txtSettings = new System.Windows.Forms.Label();
            this.txtSettingsRight = new System.Windows.Forms.Label();
            this.txtSettingsLeft = new System.Windows.Forms.Label();
            this.txtSettingsDown = new System.Windows.Forms.Label();
            this.txtSettingsUp = new System.Windows.Forms.Label();
            this.pictureBoxSettingsSide = new System.Windows.Forms.PictureBox();
            this.pictureBoxSettingsEnter = new System.Windows.Forms.PictureBox();
            this.txtSettingsEnter = new System.Windows.Forms.Label();
            this.pictureBoxSettingsEscape = new System.Windows.Forms.PictureBox();
            this.txtSettingsEscape = new System.Windows.Forms.Label();
            this.txtSettingsGoal = new System.Windows.Forms.Label();
            this.txtSettingsGoalExplain = new System.Windows.Forms.Label();
            this.txtSettingsGoBack = new System.Windows.Forms.Label();
            this.txtHistoryQuit = new System.Windows.Forms.Label();
            this.txtHistory_1 = new System.Windows.Forms.Label();
            this.pictureBoxHistory_1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxHistoryTheSavior = new System.Windows.Forms.PictureBox();
            this.txtHistoryTheSavior = new System.Windows.Forms.Label();
            this.pictureBoxHistoryProfile = new System.Windows.Forms.PictureBox();
            this.txtHistoryProfile = new System.Windows.Forms.Label();
            this.pictureBoxHistoryZombie = new System.Windows.Forms.PictureBox();
            this.txtHistoryZombie = new System.Windows.Forms.Label();
            this.panelHistory = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.panelPauseMenu.SuspendLayout();
            this.panelGameOver.SuspendLayout();
            this.panelSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSettingsSide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSettingsEnter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSettingsEscape)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHistory_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHistoryTheSavior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHistoryProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHistoryZombie)).BeginInit();
            this.panelHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAmmo
            // 
            this.txtAmmo.AutoSize = true;
            this.txtAmmo.BackColor = System.Drawing.Color.Transparent;
            this.txtAmmo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtAmmo.ForeColor = System.Drawing.Color.White;
            this.txtAmmo.Location = new System.Drawing.Point(12, 9);
            this.txtAmmo.Name = "txtAmmo";
            this.txtAmmo.Size = new System.Drawing.Size(107, 29);
            this.txtAmmo.TabIndex = 0;
            this.txtAmmo.Text = "Ammo: 0";
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.BackColor = System.Drawing.Color.Transparent;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtScore.ForeColor = System.Drawing.Color.White;
            this.txtScore.Location = new System.Drawing.Point(138, 9);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(148, 29);
            this.txtScore.TabIndex = 1;
            this.txtScore.Text = "Destroyed: 0";
            // 
            // txtHealth
            // 
            this.txtHealth.AutoSize = true;
            this.txtHealth.BackColor = System.Drawing.Color.Transparent;
            this.txtHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtHealth.ForeColor = System.Drawing.Color.White;
            this.txtHealth.Location = new System.Drawing.Point(620, 9);
            this.txtHealth.Name = "txtHealth";
            this.txtHealth.Size = new System.Drawing.Size(82, 29);
            this.txtHealth.TabIndex = 2;
            this.txtHealth.Text = "Health";
            // 
            // healthBar
            // 
            this.healthBar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.healthBar.Location = new System.Drawing.Point(708, 7);
            this.healthBar.Name = "healthBar";
            this.healthBar.Size = new System.Drawing.Size(264, 30);
            this.healthBar.TabIndex = 3;
            this.healthBar.Value = 100;
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 10;
            this.GameTimer.Tick += new System.EventHandler(this.MainTimerEvent);
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::Universe_on_fire.Properties.Resources.Up;
            this.player.Location = new System.Drawing.Point(419, 624);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(100, 100);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 4;
            this.player.TabStop = false;
            // 
            // panelPauseMenu
            // 
            this.panelPauseMenu.BackColor = System.Drawing.Color.Gray;
            this.panelPauseMenu.Controls.Add(this.txtPauseHistory);
            this.panelPauseMenu.Controls.Add(this.txtPauseExit);
            this.panelPauseMenu.Controls.Add(this.txtPauseHelp);
            this.panelPauseMenu.Controls.Add(this.txtPauseResume);
            this.panelPauseMenu.Controls.Add(this.txtPauseM);
            this.panelPauseMenu.Location = new System.Drawing.Point(588, 335);
            this.panelPauseMenu.Name = "panelPauseMenu";
            this.panelPauseMenu.Size = new System.Drawing.Size(393, 309);
            this.panelPauseMenu.TabIndex = 6;
            this.panelPauseMenu.Visible = false;
            // 
            // txtPauseM
            // 
            this.txtPauseM.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtPauseM.Location = new System.Drawing.Point(56, 2);
            this.txtPauseM.Name = "txtPauseM";
            this.txtPauseM.Size = new System.Drawing.Size(288, 44);
            this.txtPauseM.TabIndex = 0;
            this.txtPauseM.Text = "Pause";
            this.txtPauseM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtPauseM.Visible = false;
            // 
            // txtPauseResume
            // 
            this.txtPauseResume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPauseResume.Location = new System.Drawing.Point(101, 65);
            this.txtPauseResume.Name = "txtPauseResume";
            this.txtPauseResume.Size = new System.Drawing.Size(188, 27);
            this.txtPauseResume.TabIndex = 1;
            this.txtPauseResume.Text = "Hold out ESC to continue";
            this.txtPauseResume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtPauseResume.Visible = false;
            // 
            // txtPauseHelp
            // 
            this.txtPauseHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPauseHelp.Location = new System.Drawing.Point(101, 114);
            this.txtPauseHelp.Name = "txtPauseHelp";
            this.txtPauseHelp.Size = new System.Drawing.Size(188, 27);
            this.txtPauseHelp.TabIndex = 2;
            this.txtPauseHelp.Text = "Push H for help";
            this.txtPauseHelp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtPauseHelp.Visible = false;
            // 
            // txtPauseExit
            // 
            this.txtPauseExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPauseExit.Location = new System.Drawing.Point(101, 264);
            this.txtPauseExit.Name = "txtPauseExit";
            this.txtPauseExit.Size = new System.Drawing.Size(188, 27);
            this.txtPauseExit.TabIndex = 3;
            this.txtPauseExit.Text = "Push Q for Exit";
            this.txtPauseExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtPauseExit.Visible = false;
            // 
            // txtPauseHistory
            // 
            this.txtPauseHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPauseHistory.Location = new System.Drawing.Point(101, 162);
            this.txtPauseHistory.Name = "txtPauseHistory";
            this.txtPauseHistory.Size = new System.Drawing.Size(188, 27);
            this.txtPauseHistory.TabIndex = 4;
            this.txtPauseHistory.Text = "Push Tab for history";
            this.txtPauseHistory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtPauseHistory.Visible = false;
            // 
            // panelGameOver
            // 
            this.panelGameOver.BackColor = System.Drawing.Color.DimGray;
            this.panelGameOver.Controls.Add(this.txtGOScore);
            this.panelGameOver.Controls.Add(this.txtRestart);
            this.panelGameOver.Controls.Add(this.txtGameIsOver);
            this.panelGameOver.Location = new System.Drawing.Point(589, 71);
            this.panelGameOver.Name = "panelGameOver";
            this.panelGameOver.Size = new System.Drawing.Size(392, 217);
            this.panelGameOver.TabIndex = 5;
            this.panelGameOver.Visible = false;
            // 
            // txtGameIsOver
            // 
            this.txtGameIsOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtGameIsOver.Location = new System.Drawing.Point(27, 19);
            this.txtGameIsOver.Name = "txtGameIsOver";
            this.txtGameIsOver.Size = new System.Drawing.Size(343, 42);
            this.txtGameIsOver.TabIndex = 0;
            this.txtGameIsOver.Text = "Game Over!";
            this.txtGameIsOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtGameIsOver.Visible = false;
            // 
            // txtRestart
            // 
            this.txtRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtRestart.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtRestart.Location = new System.Drawing.Point(110, 155);
            this.txtRestart.Name = "txtRestart";
            this.txtRestart.Size = new System.Drawing.Size(168, 37);
            this.txtRestart.TabIndex = 1;
            this.txtRestart.Text = "Press Enter to Restart";
            this.txtRestart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtRestart.Visible = false;
            this.txtRestart.Click += new System.EventHandler(this.txtRestart_Click);
            // 
            // txtGOScore
            // 
            this.txtGOScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtGOScore.Location = new System.Drawing.Point(95, 76);
            this.txtGOScore.Name = "txtGOScore";
            this.txtGOScore.Size = new System.Drawing.Size(202, 33);
            this.txtGOScore.TabIndex = 2;
            this.txtGOScore.Text = "Score: ";
            this.txtGOScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtGOScore.Visible = false;
            // 
            // panelSettings
            // 
            this.panelSettings.BackColor = System.Drawing.Color.Silver;
            this.panelSettings.BackgroundImage = global::Universe_on_fire.Properties.Resources.Energy;
            this.panelSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSettings.Controls.Add(this.txtSettingsGoBack);
            this.panelSettings.Controls.Add(this.txtSettingsGoalExplain);
            this.panelSettings.Controls.Add(this.txtSettingsGoal);
            this.panelSettings.Controls.Add(this.txtSettingsEscape);
            this.panelSettings.Controls.Add(this.pictureBoxSettingsEscape);
            this.panelSettings.Controls.Add(this.txtSettingsEnter);
            this.panelSettings.Controls.Add(this.pictureBoxSettingsEnter);
            this.panelSettings.Controls.Add(this.pictureBoxSettingsSide);
            this.panelSettings.Controls.Add(this.txtSettingsUp);
            this.panelSettings.Controls.Add(this.txtSettingsDown);
            this.panelSettings.Controls.Add(this.txtSettingsLeft);
            this.panelSettings.Controls.Add(this.txtSettingsRight);
            this.panelSettings.Controls.Add(this.txtSettings);
            this.panelSettings.Location = new System.Drawing.Point(591, 71);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(390, 567);
            this.panelSettings.TabIndex = 7;
            this.panelSettings.Visible = false;
            this.panelSettings.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSettings_Paint);
            // 
            // txtSettings
            // 
            this.txtSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtSettings.Location = new System.Drawing.Point(111, 20);
            this.txtSettings.Name = "txtSettings";
            this.txtSettings.Size = new System.Drawing.Size(183, 47);
            this.txtSettings.TabIndex = 0;
            this.txtSettings.Text = "Settings";
            this.txtSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtSettings.Click += new System.EventHandler(this.txtSettings_Click);
            // 
            // txtSettingsRight
            // 
            this.txtSettingsRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSettingsRight.Location = new System.Drawing.Point(286, 163);
            this.txtSettingsRight.Name = "txtSettingsRight";
            this.txtSettingsRight.Size = new System.Drawing.Size(74, 23);
            this.txtSettingsRight.TabIndex = 1;
            this.txtSettingsRight.Text = "Go right";
            this.txtSettingsRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtSettingsRight.Visible = false;
            // 
            // txtSettingsLeft
            // 
            this.txtSettingsLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSettingsLeft.Location = new System.Drawing.Point(37, 163);
            this.txtSettingsLeft.Name = "txtSettingsLeft";
            this.txtSettingsLeft.Size = new System.Drawing.Size(72, 23);
            this.txtSettingsLeft.TabIndex = 2;
            this.txtSettingsLeft.Text = "Go left";
            this.txtSettingsLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtSettingsLeft.Visible = false;
            // 
            // txtSettingsDown
            // 
            this.txtSettingsDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSettingsDown.Location = new System.Drawing.Point(159, 215);
            this.txtSettingsDown.Name = "txtSettingsDown";
            this.txtSettingsDown.Size = new System.Drawing.Size(78, 23);
            this.txtSettingsDown.TabIndex = 3;
            this.txtSettingsDown.Text = "Go Down";
            this.txtSettingsDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtSettingsDown.Visible = false;
            // 
            // txtSettingsUp
            // 
            this.txtSettingsUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSettingsUp.Location = new System.Drawing.Point(159, 67);
            this.txtSettingsUp.Name = "txtSettingsUp";
            this.txtSettingsUp.Size = new System.Drawing.Size(69, 23);
            this.txtSettingsUp.TabIndex = 4;
            this.txtSettingsUp.Text = "Go Up";
            this.txtSettingsUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtSettingsUp.Visible = false;
            // 
            // pictureBoxSettingsSide
            // 
            this.pictureBoxSettingsSide.BackgroundImage = global::Universe_on_fire.Properties.Resources.SideSettings;
            this.pictureBoxSettingsSide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxSettingsSide.Location = new System.Drawing.Point(115, 105);
            this.pictureBoxSettingsSide.Name = "pictureBoxSettingsSide";
            this.pictureBoxSettingsSide.Size = new System.Drawing.Size(165, 107);
            this.pictureBoxSettingsSide.TabIndex = 5;
            this.pictureBoxSettingsSide.TabStop = false;
            this.pictureBoxSettingsSide.Visible = false;
            // 
            // pictureBoxSettingsEnter
            // 
            this.pictureBoxSettingsEnter.BackgroundImage = global::Universe_on_fire.Properties.Resources.Enter_removebg_preview;
            this.pictureBoxSettingsEnter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxSettingsEnter.Location = new System.Drawing.Point(30, 286);
            this.pictureBoxSettingsEnter.Name = "pictureBoxSettingsEnter";
            this.pictureBoxSettingsEnter.Size = new System.Drawing.Size(97, 65);
            this.pictureBoxSettingsEnter.TabIndex = 6;
            this.pictureBoxSettingsEnter.TabStop = false;
            this.pictureBoxSettingsEnter.Visible = false;
            // 
            // txtSettingsEnter
            // 
            this.txtSettingsEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSettingsEnter.Location = new System.Drawing.Point(40, 260);
            this.txtSettingsEnter.Name = "txtSettingsEnter";
            this.txtSettingsEnter.Size = new System.Drawing.Size(75, 23);
            this.txtSettingsEnter.TabIndex = 7;
            this.txtSettingsEnter.Text = "Restart Game";
            this.txtSettingsEnter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtSettingsEnter.Visible = false;
            this.txtSettingsEnter.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBoxSettingsEscape
            // 
            this.pictureBoxSettingsEscape.BackgroundImage = global::Universe_on_fire.Properties.Resources.Escape;
            this.pictureBoxSettingsEscape.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxSettingsEscape.Location = new System.Drawing.Point(264, 286);
            this.pictureBoxSettingsEscape.Name = "pictureBoxSettingsEscape";
            this.pictureBoxSettingsEscape.Size = new System.Drawing.Size(96, 65);
            this.pictureBoxSettingsEscape.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSettingsEscape.TabIndex = 8;
            this.pictureBoxSettingsEscape.TabStop = false;
            this.pictureBoxSettingsEscape.Visible = false;
            // 
            // txtSettingsEscape
            // 
            this.txtSettingsEscape.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSettingsEscape.Location = new System.Drawing.Point(261, 263);
            this.txtSettingsEscape.Name = "txtSettingsEscape";
            this.txtSettingsEscape.Size = new System.Drawing.Size(110, 23);
            this.txtSettingsEscape.TabIndex = 9;
            this.txtSettingsEscape.Text = "Hold for pause";
            this.txtSettingsEscape.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtSettingsEscape.Visible = false;
            // 
            // txtSettingsGoal
            // 
            this.txtSettingsGoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSettingsGoal.Location = new System.Drawing.Point(139, 364);
            this.txtSettingsGoal.Name = "txtSettingsGoal";
            this.txtSettingsGoal.Size = new System.Drawing.Size(110, 23);
            this.txtSettingsGoal.TabIndex = 10;
            this.txtSettingsGoal.Text = "Goal";
            this.txtSettingsGoal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtSettingsGoal.Visible = false;
            // 
            // txtSettingsGoalExplain
            // 
            this.txtSettingsGoalExplain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSettingsGoalExplain.Location = new System.Drawing.Point(40, 400);
            this.txtSettingsGoalExplain.Name = "txtSettingsGoalExplain";
            this.txtSettingsGoalExplain.Size = new System.Drawing.Size(307, 23);
            this.txtSettingsGoalExplain.TabIndex = 11;
            this.txtSettingsGoalExplain.Text = "Destroy 100 zombie ships";
            this.txtSettingsGoalExplain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtSettingsGoalExplain.Visible = false;
            this.txtSettingsGoalExplain.Click += new System.EventHandler(this.txtSettingsGoalExplain_Click);
            // 
            // txtSettingsGoBack
            // 
            this.txtSettingsGoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSettingsGoBack.Location = new System.Drawing.Point(101, 477);
            this.txtSettingsGoBack.Name = "txtSettingsGoBack";
            this.txtSettingsGoBack.Size = new System.Drawing.Size(183, 45);
            this.txtSettingsGoBack.TabIndex = 12;
            this.txtSettingsGoBack.Text = "Hold out H to go back";
            this.txtSettingsGoBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtHistoryQuit
            // 
            this.txtHistoryQuit.BackColor = System.Drawing.Color.DimGray;
            this.txtHistoryQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtHistoryQuit.ForeColor = System.Drawing.Color.White;
            this.txtHistoryQuit.Location = new System.Drawing.Point(356, 501);
            this.txtHistoryQuit.Name = "txtHistoryQuit";
            this.txtHistoryQuit.Size = new System.Drawing.Size(314, 31);
            this.txtHistoryQuit.TabIndex = 8;
            this.txtHistoryQuit.Text = "Hold out TAB to go back";
            this.txtHistoryQuit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtHistoryQuit.Visible = false;
            // 
            // txtHistory_1
            // 
            this.txtHistory_1.BackColor = System.Drawing.Color.DimGray;
            this.txtHistory_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtHistory_1.ForeColor = System.Drawing.Color.White;
            this.txtHistory_1.Location = new System.Drawing.Point(353, 18);
            this.txtHistory_1.Name = "txtHistory_1";
            this.txtHistory_1.Size = new System.Drawing.Size(317, 418);
            this.txtHistory_1.TabIndex = 0;
            this.txtHistory_1.Text = resources.GetString("txtHistory_1.Text");
            this.txtHistory_1.Visible = false;
            // 
            // pictureBoxHistory_1
            // 
            this.pictureBoxHistory_1.BackgroundImage = global::Universe_on_fire.Properties.Resources.HistoryPicture_1;
            this.pictureBoxHistory_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxHistory_1.Location = new System.Drawing.Point(5, 18);
            this.pictureBoxHistory_1.Name = "pictureBoxHistory_1";
            this.pictureBoxHistory_1.Size = new System.Drawing.Size(334, 224);
            this.pictureBoxHistory_1.TabIndex = 1;
            this.pictureBoxHistory_1.TabStop = false;
            this.pictureBoxHistory_1.Visible = false;
            // 
            // pictureBoxHistoryTheSavior
            // 
            this.pictureBoxHistoryTheSavior.BackgroundImage = global::Universe_on_fire.Properties.Resources.Up;
            this.pictureBoxHistoryTheSavior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxHistoryTheSavior.Location = new System.Drawing.Point(31, 432);
            this.pictureBoxHistoryTheSavior.Name = "pictureBoxHistoryTheSavior";
            this.pictureBoxHistoryTheSavior.Size = new System.Drawing.Size(80, 80);
            this.pictureBoxHistoryTheSavior.TabIndex = 2;
            this.pictureBoxHistoryTheSavior.TabStop = false;
            this.pictureBoxHistoryTheSavior.Visible = false;
            this.pictureBoxHistoryTheSavior.Click += new System.EventHandler(this.pictureBoxHistoryTheSavior_Click);
            // 
            // txtHistoryTheSavior
            // 
            this.txtHistoryTheSavior.BackColor = System.Drawing.Color.DimGray;
            this.txtHistoryTheSavior.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtHistoryTheSavior.ForeColor = System.Drawing.Color.White;
            this.txtHistoryTheSavior.Location = new System.Drawing.Point(28, 515);
            this.txtHistoryTheSavior.Name = "txtHistoryTheSavior";
            this.txtHistoryTheSavior.Size = new System.Drawing.Size(83, 17);
            this.txtHistoryTheSavior.TabIndex = 3;
            this.txtHistoryTheSavior.Text = "The Savior";
            this.txtHistoryTheSavior.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtHistoryTheSavior.Visible = false;
            // 
            // pictureBoxHistoryProfile
            // 
            this.pictureBoxHistoryProfile.BackgroundImage = global::Universe_on_fire.Properties.Resources.Profile;
            this.pictureBoxHistoryProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxHistoryProfile.Location = new System.Drawing.Point(16, 252);
            this.pictureBoxHistoryProfile.Name = "pictureBoxHistoryProfile";
            this.pictureBoxHistoryProfile.Size = new System.Drawing.Size(120, 138);
            this.pictureBoxHistoryProfile.TabIndex = 4;
            this.pictureBoxHistoryProfile.TabStop = false;
            this.pictureBoxHistoryProfile.Visible = false;
            this.pictureBoxHistoryProfile.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtHistoryProfile
            // 
            this.txtHistoryProfile.BackColor = System.Drawing.Color.DimGray;
            this.txtHistoryProfile.ForeColor = System.Drawing.Color.White;
            this.txtHistoryProfile.Location = new System.Drawing.Point(157, 259);
            this.txtHistoryProfile.Name = "txtHistoryProfile";
            this.txtHistoryProfile.Size = new System.Drawing.Size(182, 130);
            this.txtHistoryProfile.TabIndex = 5;
            this.txtHistoryProfile.Text = "Name:  Ali Ibn De Sabir\r\nMinistry: Admiral\r\nAge: 523\r\nSpaceship: The Savior\r\n\r\n\r\n" +
    "\r\n\r\nDestination: Save another measurements at any cost\r\n\r\n";
            this.txtHistoryProfile.Visible = false;
            // 
            // pictureBoxHistoryZombie
            // 
            this.pictureBoxHistoryZombie.BackgroundImage = global::Universe_on_fire.Properties.Resources.enUp;
            this.pictureBoxHistoryZombie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxHistoryZombie.Location = new System.Drawing.Point(180, 432);
            this.pictureBoxHistoryZombie.Name = "pictureBoxHistoryZombie";
            this.pictureBoxHistoryZombie.Size = new System.Drawing.Size(80, 80);
            this.pictureBoxHistoryZombie.TabIndex = 6;
            this.pictureBoxHistoryZombie.TabStop = false;
            this.pictureBoxHistoryZombie.Visible = false;
            this.pictureBoxHistoryZombie.Click += new System.EventHandler(this.pictureBoxHistoryZombie_Click);
            // 
            // txtHistoryZombie
            // 
            this.txtHistoryZombie.BackColor = System.Drawing.Color.DimGray;
            this.txtHistoryZombie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtHistoryZombie.ForeColor = System.Drawing.Color.White;
            this.txtHistoryZombie.Location = new System.Drawing.Point(168, 515);
            this.txtHistoryZombie.Name = "txtHistoryZombie";
            this.txtHistoryZombie.Size = new System.Drawing.Size(107, 17);
            this.txtHistoryZombie.TabIndex = 7;
            this.txtHistoryZombie.Text = "The zombieShip";
            this.txtHistoryZombie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtHistoryZombie.Visible = false;
            // 
            // panelHistory
            // 
            this.panelHistory.BackColor = System.Drawing.Color.Black;
            this.panelHistory.Controls.Add(this.txtHistoryProfile);
            this.panelHistory.Controls.Add(this.txtHistory_1);
            this.panelHistory.Controls.Add(this.txtHistoryZombie);
            this.panelHistory.Controls.Add(this.pictureBoxHistoryZombie);
            this.panelHistory.Controls.Add(this.pictureBoxHistoryProfile);
            this.panelHistory.Controls.Add(this.txtHistoryTheSavior);
            this.panelHistory.Controls.Add(this.pictureBoxHistoryTheSavior);
            this.panelHistory.Controls.Add(this.pictureBoxHistory_1);
            this.panelHistory.Controls.Add(this.txtHistoryQuit);
            this.panelHistory.Location = new System.Drawing.Point(17, 85);
            this.panelHistory.Name = "panelHistory";
            this.panelHistory.Size = new System.Drawing.Size(702, 560);
            this.panelHistory.TabIndex = 8;
            this.panelHistory.Visible = false;
            // 
            // UniverseOnFire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 861);
            this.Controls.Add(this.panelSettings);
            this.Controls.Add(this.panelPauseMenu);
            this.Controls.Add(this.panelGameOver);
            this.Controls.Add(this.healthBar);
            this.Controls.Add(this.txtHealth);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.txtAmmo);
            this.Controls.Add(this.panelHistory);
            this.Controls.Add(this.player);
            this.DoubleBuffered = true;
            this.Enabled = false;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "UniverseOnFire";
            this.Text = "Universe On Fire";
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.panelPauseMenu.ResumeLayout(false);
            this.panelGameOver.ResumeLayout(false);
            this.panelSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSettingsSide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSettingsEnter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSettingsEscape)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHistory_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHistoryTheSavior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHistoryProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHistoryZombie)).EndInit();
            this.panelHistory.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtAmmo;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label txtHealth;
        private System.Windows.Forms.ProgressBar healthBar;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Panel panelPauseMenu;
        private System.Windows.Forms.Label txtPauseHistory;
        private System.Windows.Forms.Label txtPauseExit;
        private System.Windows.Forms.Label txtPauseHelp;
        private System.Windows.Forms.Label txtPauseResume;
        private System.Windows.Forms.Label txtPauseM;
        private System.Windows.Forms.Panel panelGameOver;
        private System.Windows.Forms.Label txtGOScore;
        private System.Windows.Forms.Label txtRestart;
        private System.Windows.Forms.Label txtGameIsOver;
        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.Label txtSettingsGoBack;
        private System.Windows.Forms.Label txtSettingsGoalExplain;
        private System.Windows.Forms.Label txtSettingsGoal;
        private System.Windows.Forms.Label txtSettingsEscape;
        private System.Windows.Forms.PictureBox pictureBoxSettingsEscape;
        private System.Windows.Forms.Label txtSettingsEnter;
        private System.Windows.Forms.PictureBox pictureBoxSettingsEnter;
        private System.Windows.Forms.PictureBox pictureBoxSettingsSide;
        private System.Windows.Forms.Label txtSettingsUp;
        private System.Windows.Forms.Label txtSettingsDown;
        private System.Windows.Forms.Label txtSettingsLeft;
        private System.Windows.Forms.Label txtSettingsRight;
        private System.Windows.Forms.Label txtSettings;
        private System.Windows.Forms.Label txtHistoryQuit;
        private System.Windows.Forms.Label txtHistory_1;
        private System.Windows.Forms.PictureBox pictureBoxHistory_1;
        private System.Windows.Forms.PictureBox pictureBoxHistoryTheSavior;
        private System.Windows.Forms.Label txtHistoryTheSavior;
        private System.Windows.Forms.PictureBox pictureBoxHistoryProfile;
        private System.Windows.Forms.Label txtHistoryProfile;
        private System.Windows.Forms.PictureBox pictureBoxHistoryZombie;
        private System.Windows.Forms.Label txtHistoryZombie;
        private System.Windows.Forms.Panel panelHistory;
    }
}

