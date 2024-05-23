namespace Race
{
	partial class RaceGame
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RaceGame));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            timerRoad = new System.Windows.Forms.Timer(components);
            panelGame = new Panel();
            panelPause = new Panel();
            panelMenu = new Panel();
            nameButton = new Button();
            resultsButton = new Button();
            buttonHelp = new Button();
            buttonMenuExit = new Button();
            buttonStart = new Button();
            label3 = new Label();
            menuCar1 = new PictureBox();
            menuCar3 = new PictureBox();
            menuCar2 = new PictureBox();
            menuTwoLane5 = new Label();
            menuTwoLane4 = new Label();
            menuTwoLane3 = new Label();
            menuTwoLane2 = new Label();
            menuTwoLane1 = new Label();
            menuOneLane5 = new Label();
            menuOneLane4 = new Label();
            menuOneLane3 = new Label();
            menuOneLane2 = new Label();
            menuOneLane1 = new Label();
            label12 = new Label();
            resultsPanel = new Panel();
            resultsDataGridView = new DataGridView();
            userName = new DataGridViewTextBoxColumn();
            UserScore = new DataGridViewTextBoxColumn();
            CoinsNumber = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            backButton = new Button();
            buttonExit = new Button();
            buttonResume = new Button();
            pictureFlag = new PictureBox();
            labelPause = new Label();
            labelScore = new Label();
            labelCoins = new Label();
            label = new Label();
            towardCar2 = new PictureBox();
            towardCar1 = new PictureBox();
            towardCar3 = new PictureBox();
            coin3 = new PictureBox();
            coin2 = new PictureBox();
            coin1 = new PictureBox();
            buttonPause = new Button();
            mainCar = new PictureBox();
            laneTwo5 = new Label();
            laneTwo4 = new Label();
            laneTwo3 = new Label();
            laneTwo2 = new Label();
            laneTwo1 = new Label();
            laneOne5 = new Label();
            laneOne4 = new Label();
            laneOne3 = new Label();
            laneOne2 = new Label();
            laneOne1 = new Label();
            middleLane = new Label();
            timerTowardCars = new System.Windows.Forms.Timer(components);
            timerMenu = new System.Windows.Forms.Timer(components);
            panelGame.SuspendLayout();
            panelPause.SuspendLayout();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menuCar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)menuCar3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)menuCar2).BeginInit();
            resultsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)resultsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureFlag).BeginInit();
            ((System.ComponentModel.ISupportInitialize)towardCar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)towardCar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)towardCar3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coin3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coin2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coin1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mainCar).BeginInit();
            SuspendLayout();
            // 
            // timerRoad
            // 
            timerRoad.Enabled = true;
            timerRoad.Interval = 1;
            timerRoad.Tick += timerRoad_Tick;
            // 
            // panelGame
            // 
            panelGame.BackColor = SystemColors.ControlDarkDark;
            panelGame.Controls.Add(panelPause);
            panelGame.Controls.Add(labelScore);
            panelGame.Controls.Add(labelCoins);
            panelGame.Controls.Add(label);
            panelGame.Controls.Add(towardCar2);
            panelGame.Controls.Add(towardCar1);
            panelGame.Controls.Add(towardCar3);
            panelGame.Controls.Add(coin3);
            panelGame.Controls.Add(coin2);
            panelGame.Controls.Add(coin1);
            panelGame.Controls.Add(buttonPause);
            panelGame.Controls.Add(mainCar);
            panelGame.Controls.Add(laneTwo5);
            panelGame.Controls.Add(laneTwo4);
            panelGame.Controls.Add(laneTwo3);
            panelGame.Controls.Add(laneTwo2);
            panelGame.Controls.Add(laneTwo1);
            panelGame.Controls.Add(laneOne5);
            panelGame.Controls.Add(laneOne4);
            panelGame.Controls.Add(laneOne3);
            panelGame.Controls.Add(laneOne2);
            panelGame.Controls.Add(laneOne1);
            panelGame.Controls.Add(middleLane);
            panelGame.Location = new Point(0, 0);
            panelGame.Margin = new Padding(4);
            panelGame.Name = "panelGame";
            panelGame.Size = new Size(448, 650);
            panelGame.TabIndex = 0;
            // 
            // panelPause
            // 
            panelPause.BackColor = SystemColors.ControlDarkDark;
            panelPause.Controls.Add(panelMenu);
            panelPause.Controls.Add(resultsPanel);
            panelPause.Controls.Add(buttonExit);
            panelPause.Controls.Add(buttonResume);
            panelPause.Controls.Add(pictureFlag);
            panelPause.Controls.Add(labelPause);
            panelPause.Location = new Point(0, 0);
            panelPause.Margin = new Padding(4);
            panelPause.Name = "panelPause";
            panelPause.Size = new Size(451, 654);
            panelPause.TabIndex = 57;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = SystemColors.ControlDarkDark;
            panelMenu.Controls.Add(nameButton);
            panelMenu.Controls.Add(resultsButton);
            panelMenu.Controls.Add(buttonHelp);
            panelMenu.Controls.Add(buttonMenuExit);
            panelMenu.Controls.Add(buttonStart);
            panelMenu.Controls.Add(label3);
            panelMenu.Controls.Add(menuCar1);
            panelMenu.Controls.Add(menuCar3);
            panelMenu.Controls.Add(menuCar2);
            panelMenu.Controls.Add(menuTwoLane5);
            panelMenu.Controls.Add(menuTwoLane4);
            panelMenu.Controls.Add(menuTwoLane3);
            panelMenu.Controls.Add(menuTwoLane2);
            panelMenu.Controls.Add(menuTwoLane1);
            panelMenu.Controls.Add(menuOneLane5);
            panelMenu.Controls.Add(menuOneLane4);
            panelMenu.Controls.Add(menuOneLane3);
            panelMenu.Controls.Add(menuOneLane2);
            panelMenu.Controls.Add(menuOneLane1);
            panelMenu.Controls.Add(label12);
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(4);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(451, 650);
            panelMenu.TabIndex = 57;
            // 
            // nameButton
            // 
            nameButton.Font = new Font("Microsoft YaHei", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            nameButton.Location = new Point(139, 300);
            nameButton.Margin = new Padding(4);
            nameButton.Name = "nameButton";
            nameButton.Size = new Size(186, 49);
            nameButton.TabIndex = 86;
            nameButton.Text = "Enter name";
            nameButton.UseVisualStyleBackColor = true;
            nameButton.Click += nameButton_Click;
            // 
            // resultsButton
            // 
            resultsButton.Font = new Font("Microsoft YaHei", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            resultsButton.Location = new Point(150, 367);
            resultsButton.Margin = new Padding(4);
            resultsButton.Name = "resultsButton";
            resultsButton.Size = new Size(161, 43);
            resultsButton.TabIndex = 83;
            resultsButton.Text = "Results";
            resultsButton.UseVisualStyleBackColor = true;
            resultsButton.Click += resultsButton_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.Font = new Font("Microsoft YaHei", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buttonHelp.Location = new Point(361, 609);
            buttonHelp.Margin = new Padding(4);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(81, 37);
            buttonHelp.TabIndex = 82;
            buttonHelp.Text = "Help";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonMenuExit
            // 
            buttonMenuExit.Font = new Font("Microsoft YaHei", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonMenuExit.Location = new Point(149, 429);
            buttonMenuExit.Margin = new Padding(4);
            buttonMenuExit.Name = "buttonMenuExit";
            buttonMenuExit.Size = new Size(161, 39);
            buttonMenuExit.TabIndex = 67;
            buttonMenuExit.Text = "Exit";
            buttonMenuExit.UseVisualStyleBackColor = true;
            buttonMenuExit.Click += buttonMenuExit_Click;
            // 
            // buttonStart
            // 
            buttonStart.Font = new Font("Microsoft YaHei", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonStart.Location = new Point(139, 215);
            buttonStart.Margin = new Padding(4);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(186, 68);
            buttonStart.TabIndex = 65;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(64, 64, 64);
            label3.Font = new Font("Microsoft Tai Le", 105F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(0, 0);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(384, 178);
            label3.TabIndex = 66;
            label3.Text = "Race";
            // 
            // menuCar1
            // 
            menuCar1.BackColor = Color.Transparent;
            menuCar1.Image = (Image)resources.GetObject("menuCar1.Image");
            menuCar1.Location = new Point(14, 15);
            menuCar1.Margin = new Padding(4);
            menuCar1.Name = "menuCar1";
            menuCar1.Size = new Size(59, 127);
            menuCar1.SizeMode = PictureBoxSizeMode.Zoom;
            menuCar1.TabIndex = 80;
            menuCar1.TabStop = false;
            // 
            // menuCar3
            // 
            menuCar3.BackColor = Color.Transparent;
            menuCar3.Image = (Image)resources.GetObject("menuCar3.Image");
            menuCar3.Location = new Point(375, 30);
            menuCar3.Margin = new Padding(4);
            menuCar3.Name = "menuCar3";
            menuCar3.Size = new Size(59, 127);
            menuCar3.SizeMode = PictureBoxSizeMode.Zoom;
            menuCar3.TabIndex = 81;
            menuCar3.TabStop = false;
            // 
            // menuCar2
            // 
            menuCar2.BackColor = Color.Transparent;
            menuCar2.Image = (Image)resources.GetObject("menuCar2.Image");
            menuCar2.Location = new Point(150, 4);
            menuCar2.Margin = new Padding(4);
            menuCar2.Name = "menuCar2";
            menuCar2.Size = new Size(59, 127);
            menuCar2.SizeMode = PictureBoxSizeMode.Zoom;
            menuCar2.TabIndex = 79;
            menuCar2.TabStop = false;
            // 
            // menuTwoLane5
            // 
            menuTwoLane5.BackColor = Color.White;
            menuTwoLane5.ForeColor = SystemColors.Control;
            menuTwoLane5.Location = new Point(337, 598);
            menuTwoLane5.Margin = new Padding(4, 0, 4, 0);
            menuTwoLane5.Name = "menuTwoLane5";
            menuTwoLane5.Size = new Size(18, 104);
            menuTwoLane5.TabIndex = 78;
            menuTwoLane5.TextAlign = ContentAlignment.TopCenter;
            // 
            // menuTwoLane4
            // 
            menuTwoLane4.BackColor = Color.White;
            menuTwoLane4.ForeColor = SystemColors.Control;
            menuTwoLane4.Location = new Point(337, 436);
            menuTwoLane4.Margin = new Padding(4, 0, 4, 0);
            menuTwoLane4.Name = "menuTwoLane4";
            menuTwoLane4.Size = new Size(18, 104);
            menuTwoLane4.TabIndex = 77;
            menuTwoLane4.TextAlign = ContentAlignment.TopCenter;
            // 
            // menuTwoLane3
            // 
            menuTwoLane3.BackColor = Color.White;
            menuTwoLane3.ForeColor = SystemColors.Control;
            menuTwoLane3.Location = new Point(337, 274);
            menuTwoLane3.Margin = new Padding(4, 0, 4, 0);
            menuTwoLane3.Name = "menuTwoLane3";
            menuTwoLane3.Size = new Size(18, 104);
            menuTwoLane3.TabIndex = 76;
            menuTwoLane3.TextAlign = ContentAlignment.TopCenter;
            // 
            // menuTwoLane2
            // 
            menuTwoLane2.BackColor = Color.White;
            menuTwoLane2.ForeColor = SystemColors.Control;
            menuTwoLane2.Location = new Point(337, 113);
            menuTwoLane2.Margin = new Padding(4, 0, 4, 0);
            menuTwoLane2.Name = "menuTwoLane2";
            menuTwoLane2.Size = new Size(18, 104);
            menuTwoLane2.TabIndex = 75;
            menuTwoLane2.TextAlign = ContentAlignment.TopCenter;
            // 
            // menuTwoLane1
            // 
            menuTwoLane1.BackColor = Color.White;
            menuTwoLane1.ForeColor = SystemColors.Control;
            menuTwoLane1.Location = new Point(337, -49);
            menuTwoLane1.Margin = new Padding(4, 0, 4, 0);
            menuTwoLane1.Name = "menuTwoLane1";
            menuTwoLane1.Size = new Size(18, 104);
            menuTwoLane1.TabIndex = 74;
            menuTwoLane1.TextAlign = ContentAlignment.TopCenter;
            // 
            // menuOneLane5
            // 
            menuOneLane5.BackColor = Color.White;
            menuOneLane5.ForeColor = SystemColors.Control;
            menuOneLane5.Location = new Point(104, 598);
            menuOneLane5.Margin = new Padding(4, 0, 4, 0);
            menuOneLane5.Name = "menuOneLane5";
            menuOneLane5.Size = new Size(18, 104);
            menuOneLane5.TabIndex = 73;
            menuOneLane5.TextAlign = ContentAlignment.TopCenter;
            // 
            // menuOneLane4
            // 
            menuOneLane4.BackColor = Color.White;
            menuOneLane4.ForeColor = SystemColors.Control;
            menuOneLane4.Location = new Point(104, 436);
            menuOneLane4.Margin = new Padding(4, 0, 4, 0);
            menuOneLane4.Name = "menuOneLane4";
            menuOneLane4.Size = new Size(18, 104);
            menuOneLane4.TabIndex = 72;
            menuOneLane4.TextAlign = ContentAlignment.TopCenter;
            // 
            // menuOneLane3
            // 
            menuOneLane3.BackColor = Color.White;
            menuOneLane3.ForeColor = SystemColors.Control;
            menuOneLane3.Location = new Point(104, 274);
            menuOneLane3.Margin = new Padding(4, 0, 4, 0);
            menuOneLane3.Name = "menuOneLane3";
            menuOneLane3.Size = new Size(18, 104);
            menuOneLane3.TabIndex = 71;
            menuOneLane3.TextAlign = ContentAlignment.TopCenter;
            // 
            // menuOneLane2
            // 
            menuOneLane2.BackColor = Color.White;
            menuOneLane2.ForeColor = SystemColors.Control;
            menuOneLane2.Location = new Point(104, 113);
            menuOneLane2.Margin = new Padding(4, 0, 4, 0);
            menuOneLane2.Name = "menuOneLane2";
            menuOneLane2.Size = new Size(18, 104);
            menuOneLane2.TabIndex = 70;
            menuOneLane2.TextAlign = ContentAlignment.TopCenter;
            // 
            // menuOneLane1
            // 
            menuOneLane1.BackColor = Color.White;
            menuOneLane1.ForeColor = SystemColors.Control;
            menuOneLane1.Location = new Point(104, -49);
            menuOneLane1.Margin = new Padding(4, 0, 4, 0);
            menuOneLane1.Name = "menuOneLane1";
            menuOneLane1.Size = new Size(18, 104);
            menuOneLane1.TabIndex = 69;
            menuOneLane1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label12
            // 
            label12.BackColor = Color.White;
            label12.ForeColor = SystemColors.Control;
            label12.Location = new Point(214, -4);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(20, 654);
            label12.TabIndex = 68;
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // resultsPanel
            // 
            resultsPanel.AllowDrop = true;
            resultsPanel.Controls.Add(resultsDataGridView);
            resultsPanel.Controls.Add(backButton);
            resultsPanel.Location = new Point(3, 224);
            resultsPanel.Name = "resultsPanel";
            resultsPanel.Size = new Size(433, 381);
            resultsPanel.TabIndex = 88;
            // 
            // resultsDataGridView
            // 
            resultsDataGridView.AllowUserToAddRows = false;
            resultsDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlLight;
            resultsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            resultsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            resultsDataGridView.BackgroundColor = SystemColors.ControlDarkDark;
            resultsDataGridView.BorderStyle = BorderStyle.None;
            resultsDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            resultsDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Font = new Font("Microsoft Tai Le", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlLight;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            resultsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            resultsDataGridView.ColumnHeadersHeight = 20;
            resultsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            resultsDataGridView.Columns.AddRange(new DataGridViewColumn[] { userName, UserScore, CoinsNumber, Date });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlLight;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlLight;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            resultsDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            resultsDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            resultsDataGridView.EnableHeadersVisualStyles = false;
            resultsDataGridView.Location = new Point(3, 21);
            resultsDataGridView.Name = "resultsDataGridView";
            resultsDataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            resultsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = SystemColors.ControlDarkDark;
            resultsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            resultsDataGridView.RowTemplate.DefaultCellStyle.BackColor = SystemColors.ControlDarkDark;
            resultsDataGridView.RowTemplate.DefaultCellStyle.ForeColor = SystemColors.ControlLight;
            resultsDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = SystemColors.ControlDarkDark;
            resultsDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = SystemColors.ControlLight;
            resultsDataGridView.RowTemplate.Height = 25;
            resultsDataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            resultsDataGridView.Size = new Size(427, 285);
            resultsDataGridView.TabIndex = 84;
            // 
            // userName
            // 
            userName.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            userName.HeaderText = "Name";
            userName.Name = "userName";
            userName.ReadOnly = true;
            userName.Width = 63;
            // 
            // UserScore
            // 
            UserScore.HeaderText = "Score";
            UserScore.Name = "UserScore";
            UserScore.ReadOnly = true;
            // 
            // CoinsNumber
            // 
            CoinsNumber.HeaderText = "Coins";
            CoinsNumber.Name = "CoinsNumber";
            CoinsNumber.ReadOnly = true;
            // 
            // Date
            // 
            Date.HeaderText = "Date";
            Date.Name = "Date";
            Date.ReadOnly = true;
            // 
            // backButton
            // 
            backButton.Font = new Font("Microsoft YaHei", 10F, FontStyle.Bold, GraphicsUnit.Point);
            backButton.Location = new Point(134, 325);
            backButton.Margin = new Padding(4);
            backButton.Name = "backButton";
            backButton.Size = new Size(148, 37);
            backButton.TabIndex = 85;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // buttonExit
            // 
            buttonExit.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonExit.Location = new Point(139, 555);
            buttonExit.Margin = new Padding(4);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(178, 46);
            buttonExit.TabIndex = 53;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // buttonResume
            // 
            buttonResume.Font = new Font("Microsoft YaHei", 22F, FontStyle.Bold, GraphicsUnit.Point);
            buttonResume.Location = new Point(139, 469);
            buttonResume.Margin = new Padding(4);
            buttonResume.Name = "buttonResume";
            buttonResume.Size = new Size(178, 67);
            buttonResume.TabIndex = 52;
            buttonResume.Text = "Resume";
            buttonResume.UseVisualStyleBackColor = true;
            buttonResume.Click += buttonResume_Click;
            // 
            // pictureFlag
            // 
            pictureFlag.BackColor = SystemColors.ControlDarkDark;
            pictureFlag.Image = (Image)resources.GetObject("pictureFlag.Image");
            pictureFlag.Location = new Point(-3, 124);
            pictureFlag.Margin = new Padding(4);
            pictureFlag.Name = "pictureFlag";
            pictureFlag.Size = new Size(451, 364);
            pictureFlag.SizeMode = PictureBoxSizeMode.Zoom;
            pictureFlag.TabIndex = 55;
            pictureFlag.TabStop = false;
            // 
            // labelPause
            // 
            labelPause.AutoSize = true;
            labelPause.Font = new Font("Microsoft YaHei", 90F, FontStyle.Bold, GraphicsUnit.Point);
            labelPause.Location = new Point(0, 0);
            labelPause.Margin = new Padding(4, 0, 4, 0);
            labelPause.Name = "labelPause";
            labelPause.Size = new Size(422, 159);
            labelPause.TabIndex = 54;
            labelPause.Text = "Pause";
            // 
            // labelScore
            // 
            labelScore.AutoSize = true;
            labelScore.BackColor = Color.Black;
            labelScore.Font = new Font("Microsoft YaHei", 22F, FontStyle.Bold, GraphicsUnit.Point);
            labelScore.ForeColor = SystemColors.ButtonHighlight;
            labelScore.Location = new Point(14, 10);
            labelScore.Margin = new Padding(4, 0, 4, 0);
            labelScore.Name = "labelScore";
            labelScore.Size = new Size(110, 40);
            labelScore.TabIndex = 56;
            labelScore.Text = "Score:";
            // 
            // labelCoins
            // 
            labelCoins.AutoSize = true;
            labelCoins.BackColor = Color.Black;
            labelCoins.Font = new Font("Microsoft YaHei", 22F, FontStyle.Bold, GraphicsUnit.Point);
            labelCoins.ForeColor = SystemColors.ButtonHighlight;
            labelCoins.Location = new Point(242, 10);
            labelCoins.Margin = new Padding(4, 0, 4, 0);
            labelCoins.Name = "labelCoins";
            labelCoins.Size = new Size(109, 40);
            labelCoins.TabIndex = 57;
            labelCoins.Text = "Coins:";
            // 
            // label
            // 
            label.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label.BackColor = SystemColors.ActiveCaptionText;
            label.Font = new Font("Microsoft Sans Serif", 100F, FontStyle.Regular, GraphicsUnit.Point);
            label.ForeColor = SystemColors.ControlText;
            label.Location = new Point(-3, 0);
            label.Margin = new Padding(4, 0, 4, 0);
            label.Name = "label";
            label.Size = new Size(451, 68);
            label.TabIndex = 55;
            // 
            // towardCar2
            // 
            towardCar2.BackColor = Color.Transparent;
            towardCar2.Image = (Image)resources.GetObject("towardCar2.Image");
            towardCar2.Location = new Point(14, 26);
            towardCar2.Margin = new Padding(4);
            towardCar2.Name = "towardCar2";
            towardCar2.Size = new Size(59, 127);
            towardCar2.SizeMode = PictureBoxSizeMode.Zoom;
            towardCar2.TabIndex = 49;
            towardCar2.TabStop = false;
            // 
            // towardCar1
            // 
            towardCar1.BackColor = Color.Transparent;
            towardCar1.Image = (Image)resources.GetObject("towardCar1.Image");
            towardCar1.Location = new Point(150, 15);
            towardCar1.Margin = new Padding(4);
            towardCar1.Name = "towardCar1";
            towardCar1.Size = new Size(59, 127);
            towardCar1.SizeMode = PictureBoxSizeMode.Zoom;
            towardCar1.TabIndex = 48;
            towardCar1.TabStop = false;
            // 
            // towardCar3
            // 
            towardCar3.BackColor = Color.Transparent;
            towardCar3.Image = (Image)resources.GetObject("towardCar3.Image");
            towardCar3.Location = new Point(375, 41);
            towardCar3.Margin = new Padding(4);
            towardCar3.Name = "towardCar3";
            towardCar3.Size = new Size(59, 127);
            towardCar3.SizeMode = PictureBoxSizeMode.Zoom;
            towardCar3.TabIndex = 50;
            towardCar3.TabStop = false;
            // 
            // coin3
            // 
            coin3.BackColor = Color.Transparent;
            coin3.Image = (Image)resources.GetObject("coin3.Image");
            coin3.Location = new Point(375, 257);
            coin3.Margin = new Padding(4);
            coin3.Name = "coin3";
            coin3.Size = new Size(39, 37);
            coin3.SizeMode = PictureBoxSizeMode.Zoom;
            coin3.TabIndex = 54;
            coin3.TabStop = false;
            // 
            // coin2
            // 
            coin2.BackColor = Color.Transparent;
            coin2.Image = (Image)resources.GetObject("coin2.Image");
            coin2.Location = new Point(258, 180);
            coin2.Margin = new Padding(4);
            coin2.Name = "coin2";
            coin2.Size = new Size(39, 37);
            coin2.SizeMode = PictureBoxSizeMode.Zoom;
            coin2.TabIndex = 53;
            coin2.TabStop = false;
            // 
            // coin1
            // 
            coin1.BackColor = Color.Transparent;
            coin1.Image = (Image)resources.GetObject("coin1.Image");
            coin1.Location = new Point(129, 291);
            coin1.Margin = new Padding(4);
            coin1.Name = "coin1";
            coin1.Size = new Size(39, 37);
            coin1.SizeMode = PictureBoxSizeMode.Zoom;
            coin1.TabIndex = 52;
            coin1.TabStop = false;
            // 
            // buttonPause
            // 
            buttonPause.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPause.Location = new Point(0, 602);
            buttonPause.Margin = new Padding(4);
            buttonPause.Name = "buttonPause";
            buttonPause.Size = new Size(95, 44);
            buttonPause.TabIndex = 1;
            buttonPause.Text = "Pause";
            buttonPause.UseVisualStyleBackColor = true;
            buttonPause.Click += buttonPause_Click;
            // 
            // mainCar
            // 
            mainCar.BackColor = Color.Transparent;
            mainCar.BackgroundImageLayout = ImageLayout.None;
            mainCar.Image = (Image)resources.GetObject("mainCar.Image");
            mainCar.Location = new Point(258, 508);
            mainCar.Margin = new Padding(4);
            mainCar.Name = "mainCar";
            mainCar.Size = new Size(59, 127);
            mainCar.SizeMode = PictureBoxSizeMode.Zoom;
            mainCar.TabIndex = 47;
            mainCar.TabStop = false;
            // 
            // laneTwo5
            // 
            laneTwo5.BackColor = Color.White;
            laneTwo5.ForeColor = SystemColors.Control;
            laneTwo5.Location = new Point(337, 609);
            laneTwo5.Margin = new Padding(4, 0, 4, 0);
            laneTwo5.Name = "laneTwo5";
            laneTwo5.Size = new Size(18, 104);
            laneTwo5.TabIndex = 43;
            laneTwo5.TextAlign = ContentAlignment.TopCenter;
            // 
            // laneTwo4
            // 
            laneTwo4.BackColor = Color.White;
            laneTwo4.ForeColor = SystemColors.Control;
            laneTwo4.Location = new Point(337, 447);
            laneTwo4.Margin = new Padding(4, 0, 4, 0);
            laneTwo4.Name = "laneTwo4";
            laneTwo4.Size = new Size(18, 104);
            laneTwo4.TabIndex = 42;
            laneTwo4.TextAlign = ContentAlignment.TopCenter;
            // 
            // laneTwo3
            // 
            laneTwo3.BackColor = Color.White;
            laneTwo3.ForeColor = SystemColors.Control;
            laneTwo3.Location = new Point(337, 286);
            laneTwo3.Margin = new Padding(4, 0, 4, 0);
            laneTwo3.Name = "laneTwo3";
            laneTwo3.Size = new Size(18, 104);
            laneTwo3.TabIndex = 41;
            laneTwo3.TextAlign = ContentAlignment.TopCenter;
            // 
            // laneTwo2
            // 
            laneTwo2.BackColor = Color.White;
            laneTwo2.ForeColor = SystemColors.Control;
            laneTwo2.Location = new Point(337, 124);
            laneTwo2.Margin = new Padding(4, 0, 4, 0);
            laneTwo2.Name = "laneTwo2";
            laneTwo2.Size = new Size(18, 104);
            laneTwo2.TabIndex = 40;
            laneTwo2.TextAlign = ContentAlignment.TopCenter;
            // 
            // laneTwo1
            // 
            laneTwo1.BackColor = Color.White;
            laneTwo1.ForeColor = SystemColors.Control;
            laneTwo1.Location = new Point(337, -37);
            laneTwo1.Margin = new Padding(4, 0, 4, 0);
            laneTwo1.Name = "laneTwo1";
            laneTwo1.Size = new Size(18, 104);
            laneTwo1.TabIndex = 39;
            laneTwo1.TextAlign = ContentAlignment.TopCenter;
            // 
            // laneOne5
            // 
            laneOne5.BackColor = Color.White;
            laneOne5.ForeColor = SystemColors.Control;
            laneOne5.Location = new Point(104, 609);
            laneOne5.Margin = new Padding(4, 0, 4, 0);
            laneOne5.Name = "laneOne5";
            laneOne5.Size = new Size(18, 104);
            laneOne5.TabIndex = 38;
            laneOne5.TextAlign = ContentAlignment.TopCenter;
            // 
            // laneOne4
            // 
            laneOne4.BackColor = Color.White;
            laneOne4.ForeColor = SystemColors.Control;
            laneOne4.Location = new Point(104, 448);
            laneOne4.Margin = new Padding(4, 0, 4, 0);
            laneOne4.Name = "laneOne4";
            laneOne4.Size = new Size(18, 104);
            laneOne4.TabIndex = 37;
            laneOne4.TextAlign = ContentAlignment.TopCenter;
            // 
            // laneOne3
            // 
            laneOne3.BackColor = Color.White;
            laneOne3.ForeColor = SystemColors.Control;
            laneOne3.Location = new Point(104, 286);
            laneOne3.Margin = new Padding(4, 0, 4, 0);
            laneOne3.Name = "laneOne3";
            laneOne3.Size = new Size(18, 104);
            laneOne3.TabIndex = 36;
            laneOne3.TextAlign = ContentAlignment.TopCenter;
            // 
            // laneOne2
            // 
            laneOne2.BackColor = Color.White;
            laneOne2.ForeColor = SystemColors.Control;
            laneOne2.Location = new Point(104, 124);
            laneOne2.Margin = new Padding(4, 0, 4, 0);
            laneOne2.Name = "laneOne2";
            laneOne2.Size = new Size(18, 104);
            laneOne2.TabIndex = 35;
            laneOne2.TextAlign = ContentAlignment.TopCenter;
            // 
            // laneOne1
            // 
            laneOne1.BackColor = Color.White;
            laneOne1.ForeColor = SystemColors.Control;
            laneOne1.Location = new Point(104, -37);
            laneOne1.Margin = new Padding(4, 0, 4, 0);
            laneOne1.Name = "laneOne1";
            laneOne1.Size = new Size(18, 104);
            laneOne1.TabIndex = 34;
            laneOne1.TextAlign = ContentAlignment.TopCenter;
            // 
            // middleLane
            // 
            middleLane.BackColor = Color.White;
            middleLane.ForeColor = SystemColors.Control;
            middleLane.Location = new Point(214, -4);
            middleLane.Margin = new Padding(4, 0, 4, 0);
            middleLane.Name = "middleLane";
            middleLane.Size = new Size(20, 654);
            middleLane.TabIndex = 33;
            middleLane.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timerTowardCars
            // 
            timerTowardCars.Enabled = true;
            timerTowardCars.Interval = 1;
            timerTowardCars.Tick += timerTowardCars_Tick;
            // 
            // timerMenu
            // 
            timerMenu.Enabled = true;
            timerMenu.Interval = 1;
            timerMenu.Tick += timerMenu_Tick;
            // 
            // RaceGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(448, 649);
            Controls.Add(panelGame);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            KeyPreview = true;
            Margin = new Padding(4);
            Name = "RaceGame";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Race";
            Load += RaceGame_Load;
            KeyDown += RaceGame_KeyDown;
            panelGame.ResumeLayout(false);
            panelGame.PerformLayout();
            panelPause.ResumeLayout(false);
            panelPause.PerformLayout();
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)menuCar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)menuCar3).EndInit();
            ((System.ComponentModel.ISupportInitialize)menuCar2).EndInit();
            resultsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)resultsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureFlag).EndInit();
            ((System.ComponentModel.ISupportInitialize)towardCar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)towardCar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)towardCar3).EndInit();
            ((System.ComponentModel.ISupportInitialize)coin3).EndInit();
            ((System.ComponentModel.ISupportInitialize)coin2).EndInit();
            ((System.ComponentModel.ISupportInitialize)coin1).EndInit();
            ((System.ComponentModel.ISupportInitialize)mainCar).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer timerRoad;
		private System.Windows.Forms.Panel panelGame;
		private System.Windows.Forms.Label laneTwo5;
		private System.Windows.Forms.Label laneTwo4;
		private System.Windows.Forms.Label laneTwo3;
		private System.Windows.Forms.Label laneTwo2;
		private System.Windows.Forms.Label laneTwo1;
		private System.Windows.Forms.Label laneOne5;
		private System.Windows.Forms.Label laneOne4;
		private System.Windows.Forms.Label laneOne3;
		private System.Windows.Forms.Label laneOne2;
		private System.Windows.Forms.Label laneOne1;
		private System.Windows.Forms.Label middleLane;
		private System.Windows.Forms.PictureBox towardCar2;
		private System.Windows.Forms.PictureBox towardCar3;
		private System.Windows.Forms.PictureBox towardCar1;
		private System.Windows.Forms.PictureBox mainCar;
		private System.Windows.Forms.Timer timerTowardCars;
		private System.Windows.Forms.Timer timerMenu;
		private System.Windows.Forms.Label labelPause;
		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.Button buttonResume;
		private System.Windows.Forms.Button buttonPause;
		private System.Windows.Forms.PictureBox coin1;
		private System.Windows.Forms.PictureBox coin3;
		private System.Windows.Forms.PictureBox coin2;
		private System.Windows.Forms.Panel panelPause;
		private System.Windows.Forms.PictureBox pictureFlag;
		private System.Windows.Forms.Label labelCoins;
		private System.Windows.Forms.Label labelScore;
		private System.Windows.Forms.Label label;
		private Panel panelMenu;
		private Button buttonHelp;
		private Button buttonMenuExit;
		private Button buttonStart;
		private PictureBox menuCar1;
		private PictureBox menuCar3;
		private PictureBox menuCar2;
		private Label menuTwoLane5;
		private Label menuTwoLane4;
		private Label menuTwoLane3;
		private Label menuTwoLane2;
		private Label menuTwoLane1;
		private Label menuOneLane5;
		private Label menuOneLane4;
		private Label menuOneLane3;
		private Label menuOneLane2;
		private Label menuOneLane1;
		private Label label12;
        private Button resultsButton;
        private Button nameButton;
        private Panel resultsPanel;
        private DataGridView resultsDataGridView;
        private Button backButton;
        private Label label3;
        private DataGridViewTextBoxColumn userName;
        private DataGridViewTextBoxColumn UserScore;
        private DataGridViewTextBoxColumn CoinsNumber;
        private DataGridViewTextBoxColumn Date;
    }
}