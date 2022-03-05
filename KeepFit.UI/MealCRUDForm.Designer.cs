
namespace KeepFit.UI
{
    partial class MealCRUDForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.btnAddMeal = new MetroSet_UI.Controls.MetroSetButton();
            this.dtpMealDate = new System.Windows.Forms.DateTimePicker();
            this.dgvOgunlerim = new System.Windows.Forms.DataGridView();
            this.MealId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MealName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MealType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteMealToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateMealToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvListelenecekYemek = new System.Windows.Forms.DataGridView();
            this.FoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgunlerim)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListelenecekYemek)).BeginInit();
            this.SuspendLayout();
            // 
            // metroSetControlBox1
            // 
            this.metroSetControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroSetControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroSetControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.DisabledForeColor = System.Drawing.Color.DimGray;
            this.metroSetControlBox1.IsDerivedStyle = true;
            this.metroSetControlBox1.Location = new System.Drawing.Point(974, 11);
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
            this.metroSetControlBox1.TabIndex = 0;
            this.metroSetControlBox1.Text = "metroSetControlBox1";
            this.metroSetControlBox1.ThemeAuthor = "Narwin";
            this.metroSetControlBox1.ThemeName = "MetroLite";
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
            this.btnAddMeal.Location = new System.Drawing.Point(15, 474);
            this.btnAddMeal.Name = "btnAddMeal";
            this.btnAddMeal.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAddMeal.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAddMeal.NormalTextColor = System.Drawing.Color.White;
            this.btnAddMeal.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnAddMeal.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnAddMeal.PressTextColor = System.Drawing.Color.White;
            this.btnAddMeal.Size = new System.Drawing.Size(93, 23);
            this.btnAddMeal.Style = MetroSet_UI.Enums.Style.Light;
            this.btnAddMeal.StyleManager = null;
            this.btnAddMeal.TabIndex = 3;
            this.btnAddMeal.Text = "Add Meal";
            this.btnAddMeal.ThemeAuthor = "Narwin";
            this.btnAddMeal.ThemeName = "MetroLite";
            this.btnAddMeal.Click += new System.EventHandler(this.btnAddMeal_Click);
            // 
            // dtpMealDate
            // 
            this.dtpMealDate.Location = new System.Drawing.Point(879, 157);
            this.dtpMealDate.Name = "dtpMealDate";
            this.dtpMealDate.Size = new System.Drawing.Size(265, 27);
            this.dtpMealDate.TabIndex = 6;
            this.dtpMealDate.ValueChanged += new System.EventHandler(this.dtpMealDate_ValueChanged);
            // 
            // dgvOgunlerim
            // 
            this.dgvOgunlerim.AllowUserToAddRows = false;
            this.dgvOgunlerim.AllowUserToDeleteRows = false;
            this.dgvOgunlerim.AllowUserToResizeColumns = false;
            this.dgvOgunlerim.AllowUserToResizeRows = false;
            this.dgvOgunlerim.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOgunlerim.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvOgunlerim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOgunlerim.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MealId,
            this.MealName,
            this.MealType});
            this.dgvOgunlerim.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOgunlerim.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOgunlerim.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvOgunlerim.Location = new System.Drawing.Point(15, 197);
            this.dgvOgunlerim.MultiSelect = false;
            this.dgvOgunlerim.Name = "dgvOgunlerim";
            this.dgvOgunlerim.ReadOnly = true;
            this.dgvOgunlerim.RowHeadersVisible = false;
            this.dgvOgunlerim.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOgunlerim.Size = new System.Drawing.Size(478, 256);
            this.dgvOgunlerim.TabIndex = 8;
            this.dgvOgunlerim.SelectionChanged += new System.EventHandler(this.dgvOgunlerim_SelectionChanged);
            this.dgvOgunlerim.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvOgunlerim_MouseDown);
            // 
            // MealId
            // 
            this.MealId.HeaderText = "Meal Id";
            this.MealId.Name = "MealId";
            this.MealId.ReadOnly = true;
            this.MealId.Visible = false;
            // 
            // MealName
            // 
            this.MealName.HeaderText = "Meal Name";
            this.MealName.Name = "MealName";
            this.MealName.ReadOnly = true;
            // 
            // MealType
            // 
            this.MealType.HeaderText = "Meal Type";
            this.MealType.Name = "MealType";
            this.MealType.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteMealToolStripMenuItem,
            this.updateMealToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(142, 48);
            // 
            // deleteMealToolStripMenuItem
            // 
            this.deleteMealToolStripMenuItem.Name = "deleteMealToolStripMenuItem";
            this.deleteMealToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.deleteMealToolStripMenuItem.Text = "Delete Meal";
            this.deleteMealToolStripMenuItem.Click += new System.EventHandler(this.deleteMealToolStripMenuItem_Click);
            // 
            // updateMealToolStripMenuItem
            // 
            this.updateMealToolStripMenuItem.Name = "updateMealToolStripMenuItem";
            this.updateMealToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.updateMealToolStripMenuItem.Text = "Update Meal";
            this.updateMealToolStripMenuItem.Click += new System.EventHandler(this.updateMealToolStripMenuItem_Click);
            // 
            // dgvListelenecekYemek
            // 
            this.dgvListelenecekYemek.AllowUserToAddRows = false;
            this.dgvListelenecekYemek.AllowUserToDeleteRows = false;
            this.dgvListelenecekYemek.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListelenecekYemek.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListelenecekYemek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListelenecekYemek.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FoodName});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListelenecekYemek.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListelenecekYemek.Location = new System.Drawing.Point(565, 197);
            this.dgvListelenecekYemek.Name = "dgvListelenecekYemek";
            this.dgvListelenecekYemek.ReadOnly = true;
            this.dgvListelenecekYemek.RowHeadersVisible = false;
            this.dgvListelenecekYemek.Size = new System.Drawing.Size(579, 256);
            this.dgvListelenecekYemek.TabIndex = 9;
            // 
            // FoodName
            // 
            this.FoodName.HeaderText = "Food Name";
            this.FoodName.Name = "FoodName";
            this.FoodName.ReadOnly = true;
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel1.IsDerivedStyle = true;
            this.metroSetLabel1.Location = new System.Drawing.Point(565, 161);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(100, 23);
            this.metroSetLabel1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel1.StyleManager = null;
            this.metroSetLabel1.TabIndex = 10;
            this.metroSetLabel1.Text = "Meal Foods";
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroLite";
            // 
            // MealCRUDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1162, 513);
            this.Controls.Add(this.metroSetLabel1);
            this.Controls.Add(this.dgvListelenecekYemek);
            this.Controls.Add(this.dgvOgunlerim);
            this.Controls.Add(this.dtpMealDate);
            this.Controls.Add(this.btnAddMeal);
            this.Controls.Add(this.metroSetControlBox1);
            this.Name = "MealCRUDForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Style = MetroSet_UI.Enums.Style.Dark;
            this.Text = "Keep Fit";
            this.TextColor = System.Drawing.Color.White;
            this.ThemeName = "MetroDark";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MealCRUDForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MealCRUDForm_FormClosed);
            this.Load += new System.EventHandler(this.MealCRUDForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgunlerim)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListelenecekYemek)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private MetroSet_UI.Controls.MetroSetButton btnAddMeal;
        private System.Windows.Forms.DateTimePicker dtpMealDate;
        private System.Windows.Forms.DataGridView dgvOgunlerim;
        private System.Windows.Forms.DataGridView dgvListelenecekYemek;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteMealToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateMealToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodName;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MealId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MealName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MealType;
    }
}