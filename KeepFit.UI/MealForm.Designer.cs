namespace KeepFit.UI
{
    partial class MealForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAddMeal = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.cmbMealType = new MetroSet_UI.Controls.MetroSetComboBox();
            this.dtpMealDate = new System.Windows.Forms.DateTimePicker();
            this.txtMealName = new MetroSet_UI.Controls.MetroSetTextBox();
            this.btnAddFood = new MetroSet_UI.Controls.MetroSetButton();
            this.dgvOgunListele = new System.Windows.Forms.DataGridView();
            this.FoodId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Picture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Protein = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carbohydrate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gram = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEklenenOgun = new System.Windows.Forms.DataGridView();
            this.FoodId1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Picture1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calorie1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Protein1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carbohydrate1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fat1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gram1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalCalorie = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblTotalProtein = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblTotalFat = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblTotalCarbohydrate = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblTotalGram = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblGelenCalorie = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblGelenProtein = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblGelenFat = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblGelenCarbohydrate = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblGelenGram = new MetroSet_UI.Controls.MetroSetLabel();
            this.cmbUnit = new MetroSet_UI.Controls.MetroSetComboBox();
            this.btnDelete = new MetroSet_UI.Controls.MetroSetButton();
            this.btnDeleteUpdate = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetLabel6 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel7 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel2 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel5 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel4 = new MetroSet_UI.Controls.MetroSetLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgunListele)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEklenenOgun)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddMeal
            // 
            this.btnAddMeal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddMeal.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAddMeal.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAddMeal.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnAddMeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAddMeal.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnAddMeal.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnAddMeal.HoverTextColor = System.Drawing.Color.White;
            this.btnAddMeal.IsDerivedStyle = true;
            this.btnAddMeal.Location = new System.Drawing.Point(1124, 845);
            this.btnAddMeal.Name = "btnAddMeal";
            this.btnAddMeal.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAddMeal.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAddMeal.NormalTextColor = System.Drawing.Color.White;
            this.btnAddMeal.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnAddMeal.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnAddMeal.PressTextColor = System.Drawing.Color.White;
            this.btnAddMeal.Size = new System.Drawing.Size(123, 24);
            this.btnAddMeal.Style = MetroSet_UI.Enums.Style.Light;
            this.btnAddMeal.StyleManager = null;
            this.btnAddMeal.TabIndex = 0;
            this.btnAddMeal.Text = "Add Meal";
            this.btnAddMeal.ThemeAuthor = "Narwin";
            this.btnAddMeal.ThemeName = "MetroLite";
            this.btnAddMeal.Click += new System.EventHandler(this.btnAddMeal_Click);
            // 
            // metroSetControlBox1
            // 
            this.metroSetControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroSetControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroSetControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.DisabledForeColor = System.Drawing.Color.DimGray;
            this.metroSetControlBox1.IsDerivedStyle = true;
            this.metroSetControlBox1.Location = new System.Drawing.Point(1168, 15);
            this.metroSetControlBox1.MaximizeBox = false;
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
            this.metroSetControlBox1.TabIndex = 1;
            this.metroSetControlBox1.Text = "metroSetControlBox1";
            this.metroSetControlBox1.ThemeAuthor = "Narwin";
            this.metroSetControlBox1.ThemeName = "MetroLite";
            // 
            // cmbMealType
            // 
            this.cmbMealType.AllowDrop = true;
            this.cmbMealType.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cmbMealType.BackColor = System.Drawing.Color.Transparent;
            this.cmbMealType.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cmbMealType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cmbMealType.CausesValidation = false;
            this.cmbMealType.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cmbMealType.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.cmbMealType.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.cmbMealType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMealType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMealType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbMealType.FormattingEnabled = true;
            this.cmbMealType.IsDerivedStyle = true;
            this.cmbMealType.ItemHeight = 20;
            this.cmbMealType.Location = new System.Drawing.Point(145, 160);
            this.cmbMealType.Name = "cmbMealType";
            this.cmbMealType.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cmbMealType.SelectedItemForeColor = System.Drawing.Color.White;
            this.cmbMealType.Size = new System.Drawing.Size(161, 26);
            this.cmbMealType.Style = MetroSet_UI.Enums.Style.Light;
            this.cmbMealType.StyleManager = null;
            this.cmbMealType.TabIndex = 2;
            this.cmbMealType.ThemeAuthor = "Narwin";
            this.cmbMealType.ThemeName = "MetroLite";
            // 
            // dtpMealDate
            // 
            this.dtpMealDate.Location = new System.Drawing.Point(982, 242);
            this.dtpMealDate.Name = "dtpMealDate";
            this.dtpMealDate.Size = new System.Drawing.Size(265, 27);
            this.dtpMealDate.TabIndex = 3;
            this.dtpMealDate.ValueChanged += new System.EventHandler(this.dtpMealDate_ValueChanged);
            // 
            // txtMealName
            // 
            this.txtMealName.AutoCompleteCustomSource = null;
            this.txtMealName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtMealName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtMealName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtMealName.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtMealName.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtMealName.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtMealName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtMealName.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtMealName.Image = null;
            this.txtMealName.IsDerivedStyle = true;
            this.txtMealName.Lines = null;
            this.txtMealName.Location = new System.Drawing.Point(145, 104);
            this.txtMealName.MaxLength = 32767;
            this.txtMealName.Multiline = false;
            this.txtMealName.Name = "txtMealName";
            this.txtMealName.ReadOnly = false;
            this.txtMealName.Size = new System.Drawing.Size(161, 30);
            this.txtMealName.Style = MetroSet_UI.Enums.Style.Light;
            this.txtMealName.StyleManager = null;
            this.txtMealName.TabIndex = 5;
            this.txtMealName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMealName.ThemeAuthor = "Narwin";
            this.txtMealName.ThemeName = "MetroLite";
            this.txtMealName.UseSystemPasswordChar = false;
            this.txtMealName.WatermarkText = "";
            // 
            // btnAddFood
            // 
            this.btnAddFood.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddFood.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAddFood.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAddFood.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnAddFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAddFood.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnAddFood.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnAddFood.HoverTextColor = System.Drawing.Color.White;
            this.btnAddFood.IsDerivedStyle = true;
            this.btnAddFood.Location = new System.Drawing.Point(559, 536);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAddFood.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAddFood.NormalTextColor = System.Drawing.Color.White;
            this.btnAddFood.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnAddFood.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnAddFood.PressTextColor = System.Drawing.Color.White;
            this.btnAddFood.Size = new System.Drawing.Size(134, 23);
            this.btnAddFood.Style = MetroSet_UI.Enums.Style.Light;
            this.btnAddFood.StyleManager = null;
            this.btnAddFood.TabIndex = 6;
            this.btnAddFood.Text = "Add";
            this.btnAddFood.ThemeAuthor = "Narwin";
            this.btnAddFood.ThemeName = "MetroLite";
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // dgvOgunListele
            // 
            this.dgvOgunListele.AllowUserToAddRows = false;
            this.dgvOgunListele.AllowUserToDeleteRows = false;
            this.dgvOgunListele.AllowUserToResizeColumns = false;
            this.dgvOgunListele.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.dgvOgunListele.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvOgunListele.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOgunListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOgunListele.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FoodId,
            this.FoodName,
            this.Picture,
            this.Calorie,
            this.Protein,
            this.Carbohydrate,
            this.Fat,
            this.Gram});
            this.dgvOgunListele.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvOgunListele.Location = new System.Drawing.Point(3, 282);
            this.dgvOgunListele.Name = "dgvOgunListele";
            this.dgvOgunListele.ReadOnly = true;
            this.dgvOgunListele.RowHeadersVisible = false;
            this.dgvOgunListele.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOgunListele.Size = new System.Drawing.Size(523, 547);
            this.dgvOgunListele.TabIndex = 8;
            // 
            // FoodId
            // 
            this.FoodId.HeaderText = "Food Id";
            this.FoodId.Name = "FoodId";
            this.FoodId.ReadOnly = true;
            this.FoodId.Visible = false;
            // 
            // FoodName
            // 
            this.FoodName.HeaderText = "Food Name";
            this.FoodName.Name = "FoodName";
            this.FoodName.ReadOnly = true;
            // 
            // Picture
            // 
            this.Picture.HeaderText = "Picture";
            this.Picture.Name = "Picture";
            this.Picture.ReadOnly = true;
            // 
            // Calorie
            // 
            this.Calorie.HeaderText = "Calorie";
            this.Calorie.Name = "Calorie";
            this.Calorie.ReadOnly = true;
            // 
            // Protein
            // 
            this.Protein.HeaderText = "Protein";
            this.Protein.Name = "Protein";
            this.Protein.ReadOnly = true;
            // 
            // Carbohydrate
            // 
            this.Carbohydrate.HeaderText = "Carbohydrate";
            this.Carbohydrate.Name = "Carbohydrate";
            this.Carbohydrate.ReadOnly = true;
            // 
            // Fat
            // 
            this.Fat.HeaderText = "Fat";
            this.Fat.Name = "Fat";
            this.Fat.ReadOnly = true;
            // 
            // Gram
            // 
            this.Gram.HeaderText = "Gram";
            this.Gram.Name = "Gram";
            this.Gram.ReadOnly = true;
            // 
            // dgvEklenenOgun
            // 
            this.dgvEklenenOgun.AllowUserToAddRows = false;
            this.dgvEklenenOgun.AllowUserToDeleteRows = false;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.dgvEklenenOgun.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvEklenenOgun.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEklenenOgun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEklenenOgun.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FoodId1,
            this.FoodName1,
            this.Picture1,
            this.Calorie1,
            this.Protein1,
            this.Carbohydrate1,
            this.Fat1,
            this.Gram1});
            this.dgvEklenenOgun.Location = new System.Drawing.Point(724, 282);
            this.dgvEklenenOgun.Name = "dgvEklenenOgun";
            this.dgvEklenenOgun.ReadOnly = true;
            this.dgvEklenenOgun.RowHeadersVisible = false;
            this.dgvEklenenOgun.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEklenenOgun.Size = new System.Drawing.Size(523, 547);
            this.dgvEklenenOgun.TabIndex = 9;
            // 
            // FoodId1
            // 
            this.FoodId1.HeaderText = "Food Id";
            this.FoodId1.Name = "FoodId1";
            this.FoodId1.ReadOnly = true;
            this.FoodId1.Visible = false;
            // 
            // FoodName1
            // 
            this.FoodName1.HeaderText = "Food Name";
            this.FoodName1.Name = "FoodName1";
            this.FoodName1.ReadOnly = true;
            // 
            // Picture1
            // 
            this.Picture1.HeaderText = "Picture";
            this.Picture1.Name = "Picture1";
            this.Picture1.ReadOnly = true;
            // 
            // Calorie1
            // 
            this.Calorie1.HeaderText = "Calorie";
            this.Calorie1.Name = "Calorie1";
            this.Calorie1.ReadOnly = true;
            // 
            // Protein1
            // 
            this.Protein1.HeaderText = "Protein";
            this.Protein1.Name = "Protein1";
            this.Protein1.ReadOnly = true;
            // 
            // Carbohydrate1
            // 
            this.Carbohydrate1.HeaderText = "Carbohydrate";
            this.Carbohydrate1.Name = "Carbohydrate1";
            this.Carbohydrate1.ReadOnly = true;
            // 
            // Fat1
            // 
            this.Fat1.HeaderText = "Fat";
            this.Fat1.Name = "Fat1";
            this.Fat1.ReadOnly = true;
            // 
            // Gram1
            // 
            this.Gram1.HeaderText = "Gram";
            this.Gram1.Name = "Gram1";
            this.Gram1.ReadOnly = true;
            // 
            // lblTotalCalorie
            // 
            this.lblTotalCalorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTotalCalorie.IsDerivedStyle = true;
            this.lblTotalCalorie.Location = new System.Drawing.Point(982, 110);
            this.lblTotalCalorie.Name = "lblTotalCalorie";
            this.lblTotalCalorie.Size = new System.Drawing.Size(100, 23);
            this.lblTotalCalorie.Style = MetroSet_UI.Enums.Style.Dark;
            this.lblTotalCalorie.StyleManager = null;
            this.lblTotalCalorie.TabIndex = 10;
            this.lblTotalCalorie.Tag = "";
            this.lblTotalCalorie.Text = "TotalCalorie :";
            this.lblTotalCalorie.ThemeAuthor = "Narwin";
            this.lblTotalCalorie.ThemeName = "MetroDark";
            // 
            // lblTotalProtein
            // 
            this.lblTotalProtein.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTotalProtein.IsDerivedStyle = true;
            this.lblTotalProtein.Location = new System.Drawing.Point(982, 133);
            this.lblTotalProtein.Name = "lblTotalProtein";
            this.lblTotalProtein.Size = new System.Drawing.Size(100, 23);
            this.lblTotalProtein.Style = MetroSet_UI.Enums.Style.Dark;
            this.lblTotalProtein.StyleManager = null;
            this.lblTotalProtein.TabIndex = 11;
            this.lblTotalProtein.Tag = "";
            this.lblTotalProtein.Text = "TotalProtein :";
            this.lblTotalProtein.ThemeAuthor = "Narwin";
            this.lblTotalProtein.ThemeName = "MetroDark";
            // 
            // lblTotalFat
            // 
            this.lblTotalFat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTotalFat.IsDerivedStyle = true;
            this.lblTotalFat.Location = new System.Drawing.Point(982, 156);
            this.lblTotalFat.Name = "lblTotalFat";
            this.lblTotalFat.Size = new System.Drawing.Size(73, 23);
            this.lblTotalFat.Style = MetroSet_UI.Enums.Style.Dark;
            this.lblTotalFat.StyleManager = null;
            this.lblTotalFat.TabIndex = 12;
            this.lblTotalFat.Text = "TotalFat :";
            this.lblTotalFat.ThemeAuthor = "Narwin";
            this.lblTotalFat.ThemeName = "MetroDark";
            // 
            // lblTotalCarbohydrate
            // 
            this.lblTotalCarbohydrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTotalCarbohydrate.IsDerivedStyle = true;
            this.lblTotalCarbohydrate.Location = new System.Drawing.Point(982, 179);
            this.lblTotalCarbohydrate.Name = "lblTotalCarbohydrate";
            this.lblTotalCarbohydrate.Size = new System.Drawing.Size(87, 23);
            this.lblTotalCarbohydrate.Style = MetroSet_UI.Enums.Style.Dark;
            this.lblTotalCarbohydrate.StyleManager = null;
            this.lblTotalCarbohydrate.TabIndex = 13;
            this.lblTotalCarbohydrate.Text = "TotalCarb :";
            this.lblTotalCarbohydrate.ThemeAuthor = "Narwin";
            this.lblTotalCarbohydrate.ThemeName = "MetroDark";
            // 
            // lblTotalGram
            // 
            this.lblTotalGram.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTotalGram.IsDerivedStyle = true;
            this.lblTotalGram.Location = new System.Drawing.Point(982, 202);
            this.lblTotalGram.Name = "lblTotalGram";
            this.lblTotalGram.Size = new System.Drawing.Size(100, 23);
            this.lblTotalGram.Style = MetroSet_UI.Enums.Style.Dark;
            this.lblTotalGram.StyleManager = null;
            this.lblTotalGram.TabIndex = 14;
            this.lblTotalGram.Text = "TotalGram :";
            this.lblTotalGram.ThemeAuthor = "Narwin";
            this.lblTotalGram.ThemeName = "MetroDark";
            // 
            // lblGelenCalorie
            // 
            this.lblGelenCalorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblGelenCalorie.IsDerivedStyle = true;
            this.lblGelenCalorie.Location = new System.Drawing.Point(1088, 110);
            this.lblGelenCalorie.Name = "lblGelenCalorie";
            this.lblGelenCalorie.Size = new System.Drawing.Size(100, 23);
            this.lblGelenCalorie.Style = MetroSet_UI.Enums.Style.Dark;
            this.lblGelenCalorie.StyleManager = null;
            this.lblGelenCalorie.TabIndex = 15;
            this.lblGelenCalorie.ThemeAuthor = "Narwin";
            this.lblGelenCalorie.ThemeName = "MetroDark";
            // 
            // lblGelenProtein
            // 
            this.lblGelenProtein.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblGelenProtein.IsDerivedStyle = true;
            this.lblGelenProtein.Location = new System.Drawing.Point(1088, 133);
            this.lblGelenProtein.Name = "lblGelenProtein";
            this.lblGelenProtein.Size = new System.Drawing.Size(100, 23);
            this.lblGelenProtein.Style = MetroSet_UI.Enums.Style.Dark;
            this.lblGelenProtein.StyleManager = null;
            this.lblGelenProtein.TabIndex = 16;
            this.lblGelenProtein.ThemeAuthor = "Narwin";
            this.lblGelenProtein.ThemeName = "MetroDark";
            // 
            // lblGelenFat
            // 
            this.lblGelenFat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblGelenFat.IsDerivedStyle = true;
            this.lblGelenFat.Location = new System.Drawing.Point(1088, 156);
            this.lblGelenFat.Name = "lblGelenFat";
            this.lblGelenFat.Size = new System.Drawing.Size(100, 23);
            this.lblGelenFat.Style = MetroSet_UI.Enums.Style.Dark;
            this.lblGelenFat.StyleManager = null;
            this.lblGelenFat.TabIndex = 17;
            this.lblGelenFat.ThemeAuthor = "Narwin";
            this.lblGelenFat.ThemeName = "MetroDark";
            // 
            // lblGelenCarbohydrate
            // 
            this.lblGelenCarbohydrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblGelenCarbohydrate.IsDerivedStyle = true;
            this.lblGelenCarbohydrate.Location = new System.Drawing.Point(1088, 179);
            this.lblGelenCarbohydrate.Name = "lblGelenCarbohydrate";
            this.lblGelenCarbohydrate.Size = new System.Drawing.Size(100, 23);
            this.lblGelenCarbohydrate.Style = MetroSet_UI.Enums.Style.Dark;
            this.lblGelenCarbohydrate.StyleManager = null;
            this.lblGelenCarbohydrate.TabIndex = 18;
            this.lblGelenCarbohydrate.ThemeAuthor = "Narwin";
            this.lblGelenCarbohydrate.ThemeName = "MetroDark";
            // 
            // lblGelenGram
            // 
            this.lblGelenGram.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblGelenGram.IsDerivedStyle = true;
            this.lblGelenGram.Location = new System.Drawing.Point(1088, 202);
            this.lblGelenGram.Name = "lblGelenGram";
            this.lblGelenGram.Size = new System.Drawing.Size(100, 23);
            this.lblGelenGram.Style = MetroSet_UI.Enums.Style.Dark;
            this.lblGelenGram.StyleManager = null;
            this.lblGelenGram.TabIndex = 19;
            this.lblGelenGram.ThemeAuthor = "Narwin";
            this.lblGelenGram.ThemeName = "MetroDark";
            // 
            // cmbUnit
            // 
            this.cmbUnit.AllowDrop = true;
            this.cmbUnit.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cmbUnit.BackColor = System.Drawing.Color.Transparent;
            this.cmbUnit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cmbUnit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cmbUnit.CausesValidation = false;
            this.cmbUnit.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cmbUnit.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.cmbUnit.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.cmbUnit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.IsDerivedStyle = true;
            this.cmbUnit.ItemHeight = 20;
            this.cmbUnit.Location = new System.Drawing.Point(559, 461);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cmbUnit.SelectedItemForeColor = System.Drawing.Color.White;
            this.cmbUnit.Size = new System.Drawing.Size(134, 26);
            this.cmbUnit.Style = MetroSet_UI.Enums.Style.Light;
            this.cmbUnit.StyleManager = null;
            this.cmbUnit.TabIndex = 20;
            this.cmbUnit.ThemeAuthor = "Narwin";
            this.cmbUnit.ThemeName = "MetroLite";
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnDelete.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnDelete.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDelete.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnDelete.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnDelete.HoverTextColor = System.Drawing.Color.White;
            this.btnDelete.IsDerivedStyle = true;
            this.btnDelete.Location = new System.Drawing.Point(724, 845);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnDelete.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnDelete.NormalTextColor = System.Drawing.Color.White;
            this.btnDelete.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnDelete.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnDelete.PressTextColor = System.Drawing.Color.White;
            this.btnDelete.Size = new System.Drawing.Size(106, 24);
            this.btnDelete.Style = MetroSet_UI.Enums.Style.Light;
            this.btnDelete.StyleManager = null;
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Delete Food";
            this.btnDelete.ThemeAuthor = "Narwin";
            this.btnDelete.ThemeName = "MetroLite";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDeleteUpdate
            // 
            this.btnDeleteUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteUpdate.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnDeleteUpdate.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnDeleteUpdate.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnDeleteUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDeleteUpdate.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnDeleteUpdate.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnDeleteUpdate.HoverTextColor = System.Drawing.Color.White;
            this.btnDeleteUpdate.IsDerivedStyle = true;
            this.btnDeleteUpdate.Location = new System.Drawing.Point(724, 845);
            this.btnDeleteUpdate.Name = "btnDeleteUpdate";
            this.btnDeleteUpdate.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnDeleteUpdate.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnDeleteUpdate.NormalTextColor = System.Drawing.Color.White;
            this.btnDeleteUpdate.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnDeleteUpdate.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnDeleteUpdate.PressTextColor = System.Drawing.Color.White;
            this.btnDeleteUpdate.Size = new System.Drawing.Size(106, 24);
            this.btnDeleteUpdate.Style = MetroSet_UI.Enums.Style.Light;
            this.btnDeleteUpdate.StyleManager = null;
            this.btnDeleteUpdate.TabIndex = 21;
            this.btnDeleteUpdate.Text = "Delete Food";
            this.btnDeleteUpdate.ThemeAuthor = "Narwin";
            this.btnDeleteUpdate.ThemeName = "MetroLite";
            this.btnDeleteUpdate.Click += new System.EventHandler(this.btnDeleteUpdate_Click);
            // 
            // metroSetLabel6
            // 
            this.metroSetLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel6.IsDerivedStyle = true;
            this.metroSetLabel6.Location = new System.Drawing.Point(-367, 241);
            this.metroSetLabel6.Name = "metroSetLabel6";
            this.metroSetLabel6.Size = new System.Drawing.Size(100, 23);
            this.metroSetLabel6.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel6.StyleManager = null;
            this.metroSetLabel6.TabIndex = 25;
            this.metroSetLabel6.Text = "metroSetLabel4";
            this.metroSetLabel6.ThemeAuthor = "Narwin";
            this.metroSetLabel6.ThemeName = "MetroLite";
            // 
            // metroSetLabel7
            // 
            this.metroSetLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel7.IsDerivedStyle = true;
            this.metroSetLabel7.Location = new System.Drawing.Point(16, 104);
            this.metroSetLabel7.Name = "metroSetLabel7";
            this.metroSetLabel7.Size = new System.Drawing.Size(100, 23);
            this.metroSetLabel7.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLabel7.StyleManager = null;
            this.metroSetLabel7.TabIndex = 10;
            this.metroSetLabel7.Tag = "";
            this.metroSetLabel7.Text = "Meal Name :";
            this.metroSetLabel7.ThemeAuthor = "Narwin";
            this.metroSetLabel7.ThemeName = "MetroDark";
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel1.IsDerivedStyle = true;
            this.metroSetLabel1.Location = new System.Drawing.Point(16, 160);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(100, 23);
            this.metroSetLabel1.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLabel1.StyleManager = null;
            this.metroSetLabel1.TabIndex = 10;
            this.metroSetLabel1.Tag = "";
            this.metroSetLabel1.Text = "Meal Type :";
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroDark";
            // 
            // metroSetLabel2
            // 
            this.metroSetLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel2.IsDerivedStyle = true;
            this.metroSetLabel2.Location = new System.Drawing.Point(724, 246);
            this.metroSetLabel2.Name = "metroSetLabel2";
            this.metroSetLabel2.Size = new System.Drawing.Size(100, 23);
            this.metroSetLabel2.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLabel2.StyleManager = null;
            this.metroSetLabel2.TabIndex = 10;
            this.metroSetLabel2.Tag = "";
            this.metroSetLabel2.Text = "Meal Foods :";
            this.metroSetLabel2.ThemeAuthor = "Narwin";
            this.metroSetLabel2.ThemeName = "MetroDark";
            // 
            // metroSetLabel5
            // 
            this.metroSetLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel5.IsDerivedStyle = true;
            this.metroSetLabel5.Location = new System.Drawing.Point(3, 246);
            this.metroSetLabel5.Name = "metroSetLabel5";
            this.metroSetLabel5.Size = new System.Drawing.Size(100, 23);
            this.metroSetLabel5.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLabel5.StyleManager = null;
            this.metroSetLabel5.TabIndex = 10;
            this.metroSetLabel5.Tag = "";
            this.metroSetLabel5.Text = "All Foods :";
            this.metroSetLabel5.ThemeAuthor = "Narwin";
            this.metroSetLabel5.ThemeName = "MetroDark";
            // 
            // metroSetLabel4
            // 
            this.metroSetLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel4.IsDerivedStyle = true;
            this.metroSetLabel4.Location = new System.Drawing.Point(559, 421);
            this.metroSetLabel4.Name = "metroSetLabel4";
            this.metroSetLabel4.Size = new System.Drawing.Size(100, 23);
            this.metroSetLabel4.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLabel4.StyleManager = null;
            this.metroSetLabel4.TabIndex = 26;
            this.metroSetLabel4.Tag = "";
            this.metroSetLabel4.Text = "Unit :";
            this.metroSetLabel4.ThemeAuthor = "Narwin";
            this.metroSetLabel4.ThemeName = "MetroDark";
            // 
            // MealForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1283, 893);
            this.Controls.Add(this.metroSetLabel4);
            this.Controls.Add(this.metroSetLabel6);
            this.Controls.Add(this.btnDeleteUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cmbUnit);
            this.Controls.Add(this.lblGelenGram);
            this.Controls.Add(this.lblGelenCarbohydrate);
            this.Controls.Add(this.lblGelenFat);
            this.Controls.Add(this.lblGelenProtein);
            this.Controls.Add(this.lblGelenCalorie);
            this.Controls.Add(this.lblTotalGram);
            this.Controls.Add(this.lblTotalCarbohydrate);
            this.Controls.Add(this.lblTotalFat);
            this.Controls.Add(this.lblTotalProtein);
            this.Controls.Add(this.metroSetLabel2);
            this.Controls.Add(this.metroSetLabel5);
            this.Controls.Add(this.metroSetLabel1);
            this.Controls.Add(this.metroSetLabel7);
            this.Controls.Add(this.lblTotalCalorie);
            this.Controls.Add(this.dgvEklenenOgun);
            this.Controls.Add(this.dgvOgunListele);
            this.Controls.Add(this.btnAddFood);
            this.Controls.Add(this.txtMealName);
            this.Controls.Add(this.dtpMealDate);
            this.Controls.Add(this.cmbMealType);
            this.Controls.Add(this.metroSetControlBox1);
            this.Controls.Add(this.btnAddMeal);
            this.MaximumSize = new System.Drawing.Size(1283, 893);
            this.MinimumSize = new System.Drawing.Size(1283, 893);
            this.Name = "MealForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Style = MetroSet_UI.Enums.Style.Dark;
            this.Text = "Keep Fit";
            this.TextColor = System.Drawing.Color.White;
            this.ThemeName = "MetroDark";
            this.Load += new System.EventHandler(this.MealForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgunListele)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEklenenOgun)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetButton btnAddMeal;
        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private MetroSet_UI.Controls.MetroSetComboBox cmbMealType;
        private System.Windows.Forms.DateTimePicker dtpMealDate;
        private MetroSet_UI.Controls.MetroSetTextBox txtMealName;
        private MetroSet_UI.Controls.MetroSetButton btnAddFood;
        private System.Windows.Forms.DataGridView dgvOgunListele;
        private System.Windows.Forms.DataGridView dgvEklenenOgun;
        private MetroSet_UI.Controls.MetroSetLabel lblTotalCalorie;
        private MetroSet_UI.Controls.MetroSetLabel lblTotalProtein;
        private MetroSet_UI.Controls.MetroSetLabel lblTotalFat;
        private MetroSet_UI.Controls.MetroSetLabel lblTotalCarbohydrate;
        private MetroSet_UI.Controls.MetroSetLabel lblTotalGram;
        private MetroSet_UI.Controls.MetroSetLabel lblGelenCalorie;
        private MetroSet_UI.Controls.MetroSetLabel lblGelenProtein;
        private MetroSet_UI.Controls.MetroSetLabel lblGelenFat;
        private MetroSet_UI.Controls.MetroSetLabel lblGelenCarbohydrate;
        private MetroSet_UI.Controls.MetroSetLabel lblGelenGram;
        private MetroSet_UI.Controls.MetroSetComboBox cmbUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Picture;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calorie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Protein;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carbohydrate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gram;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodId1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodName1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Picture1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calorie1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Protein1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carbohydrate1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fat1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gram1;
        private MetroSet_UI.Controls.MetroSetButton btnDelete;
        private MetroSet_UI.Controls.MetroSetButton btnDeleteUpdate;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel6;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel7;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel2;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel5;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel4;
    }
}