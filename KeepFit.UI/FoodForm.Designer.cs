namespace KeepFit.UI
{
    partial class FoodForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvFoods = new System.Windows.Forms.DataGridView();
            this.metroSetContextMenuStrip1 = new MetroSet_UI.Controls.MetroSetContextMenuStrip();
            this.updateFoodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteFoodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFoodName = new MetroSet_UI.Controls.MetroSetTextBox();
            this.lblGram = new MetroSet_UI.Controls.MetroSetLabel();
            this.txtPicture = new MetroSet_UI.Controls.MetroSetTextBox();
            this.nudProtein = new System.Windows.Forms.NumericUpDown();
            this.metroSetLabel8 = new MetroSet_UI.Controls.MetroSetLabel();
            this.nudCarbonhydrate = new System.Windows.Forms.NumericUpDown();
            this.metroSetLabel7 = new MetroSet_UI.Controls.MetroSetLabel();
            this.nudFat = new System.Windows.Forms.NumericUpDown();
            this.metroSetLabel6 = new MetroSet_UI.Controls.MetroSetLabel();
            this.nudCalorie = new System.Windows.Forms.NumericUpDown();
            this.metroSetLabel5 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel4 = new MetroSet_UI.Controls.MetroSetLabel();
            this.pboFood = new System.Windows.Forms.PictureBox();
            this.btnAddFood = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetLabel3 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel2 = new MetroSet_UI.Controls.MetroSetLabel();
            this.cmbFoodType = new MetroSet_UI.Controls.MetroSetComboBox();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoods)).BeginInit();
            this.metroSetContextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudProtein)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCarbonhydrate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCalorie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboFood)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFoods
            // 
            this.dgvFoods.AllowUserToAddRows = false;
            this.dgvFoods.AllowUserToDeleteRows = false;
            this.dgvFoods.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFoods.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFoods.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFoods.Location = new System.Drawing.Point(350, 74);
            this.dgvFoods.Margin = new System.Windows.Forms.Padding(2);
            this.dgvFoods.Name = "dgvFoods";
            this.dgvFoods.ReadOnly = true;
            this.dgvFoods.RowHeadersVisible = false;
            this.dgvFoods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFoods.Size = new System.Drawing.Size(604, 461);
            this.dgvFoods.TabIndex = 0;
            this.dgvFoods.SelectionChanged += new System.EventHandler(this.dgvFoods_SelectionChanged);
            this.dgvFoods.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvFoods_MouseDown);
            // 
            // metroSetContextMenuStrip1
            // 
            this.metroSetContextMenuStrip1.IsDerivedStyle = true;
            this.metroSetContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateFoodToolStripMenuItem,
            this.deleteFoodToolStripMenuItem});
            this.metroSetContextMenuStrip1.Name = "metroSetContextMenuStrip1";
            this.metroSetContextMenuStrip1.Size = new System.Drawing.Size(143, 48);
            this.metroSetContextMenuStrip1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetContextMenuStrip1.StyleManager = null;
            this.metroSetContextMenuStrip1.ThemeAuthor = "Narwin";
            this.metroSetContextMenuStrip1.ThemeName = "MetroLite";
            // 
            // updateFoodToolStripMenuItem
            // 
            this.updateFoodToolStripMenuItem.Name = "updateFoodToolStripMenuItem";
            this.updateFoodToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.updateFoodToolStripMenuItem.Text = "Update Food";
            this.updateFoodToolStripMenuItem.Click += new System.EventHandler(this.updateFoodToolStripMenuItem_Click);
            // 
            // deleteFoodToolStripMenuItem
            // 
            this.deleteFoodToolStripMenuItem.Name = "deleteFoodToolStripMenuItem";
            this.deleteFoodToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.deleteFoodToolStripMenuItem.Text = "Delete Food";
            this.deleteFoodToolStripMenuItem.Click += new System.EventHandler(this.deleteFoodToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.txtFoodName);
            this.groupBox1.Controls.Add(this.lblGram);
            this.groupBox1.Controls.Add(this.txtPicture);
            this.groupBox1.Controls.Add(this.nudProtein);
            this.groupBox1.Controls.Add(this.metroSetLabel8);
            this.groupBox1.Controls.Add(this.nudCarbonhydrate);
            this.groupBox1.Controls.Add(this.metroSetLabel7);
            this.groupBox1.Controls.Add(this.nudFat);
            this.groupBox1.Controls.Add(this.metroSetLabel6);
            this.groupBox1.Controls.Add(this.nudCalorie);
            this.groupBox1.Controls.Add(this.metroSetLabel5);
            this.groupBox1.Controls.Add(this.metroSetLabel4);
            this.groupBox1.Controls.Add(this.pboFood);
            this.groupBox1.Controls.Add(this.btnAddFood);
            this.groupBox1.Controls.Add(this.metroSetLabel3);
            this.groupBox1.Controls.Add(this.metroSetLabel2);
            this.groupBox1.Controls.Add(this.cmbFoodType);
            this.groupBox1.Controls.Add(this.metroSetLabel1);
            this.groupBox1.Location = new System.Drawing.Point(16, 72);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(312, 461);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Food";
            // 
            // txtFoodName
            // 
            this.txtFoodName.AutoCompleteCustomSource = null;
            this.txtFoodName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtFoodName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtFoodName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtFoodName.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtFoodName.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtFoodName.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtFoodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtFoodName.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtFoodName.Image = null;
            this.txtFoodName.IsDerivedStyle = true;
            this.txtFoodName.Lines = null;
            this.txtFoodName.Location = new System.Drawing.Point(132, 164);
            this.txtFoodName.MaxLength = 32767;
            this.txtFoodName.Multiline = false;
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.ReadOnly = false;
            this.txtFoodName.Size = new System.Drawing.Size(162, 30);
            this.txtFoodName.Style = MetroSet_UI.Enums.Style.Light;
            this.txtFoodName.StyleManager = null;
            this.txtFoodName.TabIndex = 19;
            this.txtFoodName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFoodName.ThemeAuthor = "Narwin";
            this.txtFoodName.ThemeName = "MetroLite";
            this.txtFoodName.UseSystemPasswordChar = false;
            this.txtFoodName.WatermarkText = "";
            // 
            // lblGram
            // 
            this.lblGram.Enabled = false;
            this.lblGram.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblGram.IsDerivedStyle = true;
            this.lblGram.Location = new System.Drawing.Point(110, 242);
            this.lblGram.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGram.Name = "lblGram";
            this.lblGram.Size = new System.Drawing.Size(197, 21);
            this.lblGram.Style = MetroSet_UI.Enums.Style.Light;
            this.lblGram.StyleManager = null;
            this.lblGram.TabIndex = 18;
            this.lblGram.Text = "Evaluation will be made over 100 grams for food";
            this.lblGram.ThemeAuthor = "Narwin";
            this.lblGram.ThemeName = "MetroLite";
            // 
            // txtPicture
            // 
            this.txtPicture.AutoCompleteCustomSource = null;
            this.txtPicture.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPicture.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPicture.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtPicture.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtPicture.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtPicture.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPicture.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtPicture.Image = null;
            this.txtPicture.IsDerivedStyle = true;
            this.txtPicture.Lines = null;
            this.txtPicture.Location = new System.Drawing.Point(132, 201);
            this.txtPicture.Margin = new System.Windows.Forms.Padding(2);
            this.txtPicture.MaxLength = 32767;
            this.txtPicture.Multiline = false;
            this.txtPicture.Name = "txtPicture";
            this.txtPicture.ReadOnly = false;
            this.txtPicture.Size = new System.Drawing.Size(161, 30);
            this.txtPicture.Style = MetroSet_UI.Enums.Style.Light;
            this.txtPicture.StyleManager = null;
            this.txtPicture.TabIndex = 17;
            this.txtPicture.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPicture.ThemeAuthor = "Narwin";
            this.txtPicture.ThemeName = "MetroLite";
            this.txtPicture.UseSystemPasswordChar = false;
            this.txtPicture.WatermarkText = "";
            // 
            // nudProtein
            // 
            this.nudProtein.DecimalPlaces = 1;
            this.nudProtein.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudProtein.Location = new System.Drawing.Point(132, 370);
            this.nudProtein.Margin = new System.Windows.Forms.Padding(2);
            this.nudProtein.Name = "nudProtein";
            this.nudProtein.Size = new System.Drawing.Size(161, 27);
            this.nudProtein.TabIndex = 16;
            // 
            // metroSetLabel8
            // 
            this.metroSetLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel8.IsDerivedStyle = true;
            this.metroSetLabel8.Location = new System.Drawing.Point(6, 374);
            this.metroSetLabel8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroSetLabel8.Name = "metroSetLabel8";
            this.metroSetLabel8.Size = new System.Drawing.Size(91, 22);
            this.metroSetLabel8.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel8.StyleManager = null;
            this.metroSetLabel8.TabIndex = 15;
            this.metroSetLabel8.Text = "Protein :";
            this.metroSetLabel8.ThemeAuthor = "Narwin";
            this.metroSetLabel8.ThemeName = "MetroLite";
            // 
            // nudCarbonhydrate
            // 
            this.nudCarbonhydrate.DecimalPlaces = 1;
            this.nudCarbonhydrate.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudCarbonhydrate.Location = new System.Drawing.Point(132, 334);
            this.nudCarbonhydrate.Margin = new System.Windows.Forms.Padding(2);
            this.nudCarbonhydrate.Name = "nudCarbonhydrate";
            this.nudCarbonhydrate.Size = new System.Drawing.Size(161, 27);
            this.nudCarbonhydrate.TabIndex = 14;
            // 
            // metroSetLabel7
            // 
            this.metroSetLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel7.IsDerivedStyle = true;
            this.metroSetLabel7.Location = new System.Drawing.Point(6, 340);
            this.metroSetLabel7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroSetLabel7.Name = "metroSetLabel7";
            this.metroSetLabel7.Size = new System.Drawing.Size(100, 22);
            this.metroSetLabel7.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel7.StyleManager = null;
            this.metroSetLabel7.TabIndex = 13;
            this.metroSetLabel7.Text = "Carbohydrate :";
            this.metroSetLabel7.ThemeAuthor = "Narwin";
            this.metroSetLabel7.ThemeName = "MetroLite";
            // 
            // nudFat
            // 
            this.nudFat.DecimalPlaces = 1;
            this.nudFat.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudFat.Location = new System.Drawing.Point(132, 301);
            this.nudFat.Margin = new System.Windows.Forms.Padding(2);
            this.nudFat.Name = "nudFat";
            this.nudFat.Size = new System.Drawing.Size(161, 27);
            this.nudFat.TabIndex = 12;
            // 
            // metroSetLabel6
            // 
            this.metroSetLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel6.IsDerivedStyle = true;
            this.metroSetLabel6.Location = new System.Drawing.Point(6, 305);
            this.metroSetLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroSetLabel6.Name = "metroSetLabel6";
            this.metroSetLabel6.Size = new System.Drawing.Size(91, 22);
            this.metroSetLabel6.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel6.StyleManager = null;
            this.metroSetLabel6.TabIndex = 11;
            this.metroSetLabel6.Text = "Fat :";
            this.metroSetLabel6.ThemeAuthor = "Narwin";
            this.metroSetLabel6.ThemeName = "MetroLite";
            // 
            // nudCalorie
            // 
            this.nudCalorie.DecimalPlaces = 1;
            this.nudCalorie.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudCalorie.Location = new System.Drawing.Point(132, 268);
            this.nudCalorie.Margin = new System.Windows.Forms.Padding(2);
            this.nudCalorie.Name = "nudCalorie";
            this.nudCalorie.Size = new System.Drawing.Size(161, 27);
            this.nudCalorie.TabIndex = 10;
            // 
            // metroSetLabel5
            // 
            this.metroSetLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel5.IsDerivedStyle = true;
            this.metroSetLabel5.Location = new System.Drawing.Point(5, 272);
            this.metroSetLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroSetLabel5.Name = "metroSetLabel5";
            this.metroSetLabel5.Size = new System.Drawing.Size(91, 22);
            this.metroSetLabel5.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel5.StyleManager = null;
            this.metroSetLabel5.TabIndex = 9;
            this.metroSetLabel5.Text = "Calorie :";
            this.metroSetLabel5.ThemeAuthor = "Narwin";
            this.metroSetLabel5.ThemeName = "MetroLite";
            // 
            // metroSetLabel4
            // 
            this.metroSetLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel4.IsDerivedStyle = true;
            this.metroSetLabel4.Location = new System.Drawing.Point(6, 209);
            this.metroSetLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroSetLabel4.Name = "metroSetLabel4";
            this.metroSetLabel4.Size = new System.Drawing.Size(91, 22);
            this.metroSetLabel4.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel4.StyleManager = null;
            this.metroSetLabel4.TabIndex = 8;
            this.metroSetLabel4.Text = "Pictures :";
            this.metroSetLabel4.ThemeAuthor = "Narwin";
            this.metroSetLabel4.ThemeName = "MetroLite";
            // 
            // pboFood
            // 
            this.pboFood.Location = new System.Drawing.Point(78, 26);
            this.pboFood.Margin = new System.Windows.Forms.Padding(2);
            this.pboFood.Name = "pboFood";
            this.pboFood.Size = new System.Drawing.Size(142, 82);
            this.pboFood.TabIndex = 6;
            this.pboFood.TabStop = false;
            // 
            // btnAddFood
            // 
            this.btnAddFood.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAddFood.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAddFood.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnAddFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAddFood.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnAddFood.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnAddFood.HoverTextColor = System.Drawing.Color.White;
            this.btnAddFood.IsDerivedStyle = true;
            this.btnAddFood.Location = new System.Drawing.Point(6, 415);
            this.btnAddFood.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAddFood.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAddFood.NormalTextColor = System.Drawing.Color.White;
            this.btnAddFood.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnAddFood.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnAddFood.PressTextColor = System.Drawing.Color.White;
            this.btnAddFood.Size = new System.Drawing.Size(288, 28);
            this.btnAddFood.Style = MetroSet_UI.Enums.Style.Light;
            this.btnAddFood.StyleManager = null;
            this.btnAddFood.TabIndex = 5;
            this.btnAddFood.Text = "Add Food";
            this.btnAddFood.ThemeAuthor = "Narwin";
            this.btnAddFood.ThemeName = "MetroLite";
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // metroSetLabel3
            // 
            this.metroSetLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel3.IsDerivedStyle = true;
            this.metroSetLabel3.Location = new System.Drawing.Point(6, 241);
            this.metroSetLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroSetLabel3.Name = "metroSetLabel3";
            this.metroSetLabel3.Size = new System.Drawing.Size(100, 22);
            this.metroSetLabel3.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel3.StyleManager = null;
            this.metroSetLabel3.TabIndex = 4;
            this.metroSetLabel3.Text = "Gram :";
            this.metroSetLabel3.ThemeAuthor = "Narwin";
            this.metroSetLabel3.ThemeName = "MetroLite";
            // 
            // metroSetLabel2
            // 
            this.metroSetLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel2.IsDerivedStyle = true;
            this.metroSetLabel2.Location = new System.Drawing.Point(6, 172);
            this.metroSetLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroSetLabel2.Name = "metroSetLabel2";
            this.metroSetLabel2.Size = new System.Drawing.Size(100, 22);
            this.metroSetLabel2.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel2.StyleManager = null;
            this.metroSetLabel2.TabIndex = 2;
            this.metroSetLabel2.Text = "Food Name :";
            this.metroSetLabel2.ThemeAuthor = "Narwin";
            this.metroSetLabel2.ThemeName = "MetroLite";
            // 
            // cmbFoodType
            // 
            this.cmbFoodType.AllowDrop = true;
            this.cmbFoodType.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cmbFoodType.BackColor = System.Drawing.Color.Transparent;
            this.cmbFoodType.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cmbFoodType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cmbFoodType.CausesValidation = false;
            this.cmbFoodType.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cmbFoodType.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.cmbFoodType.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.cmbFoodType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFoodType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFoodType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbFoodType.FormattingEnabled = true;
            this.cmbFoodType.IsDerivedStyle = true;
            this.cmbFoodType.ItemHeight = 20;
            this.cmbFoodType.Location = new System.Drawing.Point(132, 130);
            this.cmbFoodType.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFoodType.Name = "cmbFoodType";
            this.cmbFoodType.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cmbFoodType.SelectedItemForeColor = System.Drawing.Color.White;
            this.cmbFoodType.Size = new System.Drawing.Size(162, 26);
            this.cmbFoodType.Style = MetroSet_UI.Enums.Style.Light;
            this.cmbFoodType.StyleManager = null;
            this.cmbFoodType.TabIndex = 1;
            this.cmbFoodType.ThemeAuthor = "Narwin";
            this.cmbFoodType.ThemeName = "MetroLite";
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel1.IsDerivedStyle = true;
            this.metroSetLabel1.Location = new System.Drawing.Point(6, 132);
            this.metroSetLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(100, 22);
            this.metroSetLabel1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel1.StyleManager = null;
            this.metroSetLabel1.TabIndex = 0;
            this.metroSetLabel1.Text = "Food Type :";
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroLite";
            // 
            // metroSetControlBox1
            // 
            this.metroSetControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroSetControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroSetControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.DisabledForeColor = System.Drawing.Color.DimGray;
            this.metroSetControlBox1.IsDerivedStyle = true;
            this.metroSetControlBox1.Location = new System.Drawing.Point(854, 17);
            this.metroSetControlBox1.MaximizeBox = true;
            this.metroSetControlBox1.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MaximizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MaximizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeBox = true;
            this.metroSetControlBox1.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MinimizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.Name = "metroSetControlBox1";
            this.metroSetControlBox1.Size = new System.Drawing.Size(100, 25);
            this.metroSetControlBox1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetControlBox1.StyleManager = null;
            this.metroSetControlBox1.TabIndex = 5;
            this.metroSetControlBox1.Text = "metroSetControlBox1";
            this.metroSetControlBox1.ThemeAuthor = "Narwin";
            this.metroSetControlBox1.ThemeName = "MetroLite";
            // 
            // FoodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(974, 549);
            this.Controls.Add(this.metroSetControlBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvFoods);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FoodForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Style = MetroSet_UI.Enums.Style.Dark;
            this.TextColor = System.Drawing.Color.White;
            this.ThemeName = "MetroDark";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FoodForm_FormClosing);
            this.Load += new System.EventHandler(this.FoodForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoods)).EndInit();
            this.metroSetContextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudProtein)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCarbonhydrate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCalorie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboFood)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFoods;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pboFood;
        private MetroSet_UI.Controls.MetroSetButton btnAddFood;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel2;
        private MetroSet_UI.Controls.MetroSetComboBox cmbFoodType;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel7;
        private System.Windows.Forms.NumericUpDown nudFat;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel6;
        private System.Windows.Forms.NumericUpDown nudCalorie;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel5;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel4;
        private System.Windows.Forms.NumericUpDown nudProtein;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel8;
        private System.Windows.Forms.NumericUpDown nudCarbonhydrate;
        private MetroSet_UI.Controls.MetroSetLabel lblGram;
        private MetroSet_UI.Controls.MetroSetTextBox txtPicture;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel3;
        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private MetroSet_UI.Controls.MetroSetTextBox txtFoodName;
        private MetroSet_UI.Controls.MetroSetContextMenuStrip metroSetContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem updateFoodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteFoodToolStripMenuItem;
    }
}