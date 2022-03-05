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
            this.btnOgunDuzenle = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.cmbOgunleriListele = new MetroSet_UI.Controls.MetroSetComboBox();
            this.dtpMeal = new System.Windows.Forms.DateTimePicker();
            this.flpOgunListele = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // btnOgunDuzenle
            // 
            this.btnOgunDuzenle.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnOgunDuzenle.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnOgunDuzenle.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnOgunDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnOgunDuzenle.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnOgunDuzenle.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnOgunDuzenle.HoverTextColor = System.Drawing.Color.White;
            this.btnOgunDuzenle.IsDerivedStyle = true;
            this.btnOgunDuzenle.Location = new System.Drawing.Point(662, 411);
            this.btnOgunDuzenle.Name = "btnOgunDuzenle";
            this.btnOgunDuzenle.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnOgunDuzenle.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnOgunDuzenle.NormalTextColor = System.Drawing.Color.White;
            this.btnOgunDuzenle.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnOgunDuzenle.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnOgunDuzenle.PressTextColor = System.Drawing.Color.White;
            this.btnOgunDuzenle.Size = new System.Drawing.Size(123, 24);
            this.btnOgunDuzenle.Style = MetroSet_UI.Enums.Style.Light;
            this.btnOgunDuzenle.StyleManager = null;
            this.btnOgunDuzenle.TabIndex = 0;
            this.btnOgunDuzenle.Text = "Öğünleri Düzenle";
            this.btnOgunDuzenle.ThemeAuthor = "Narwin";
            this.btnOgunDuzenle.ThemeName = "MetroLite";
            this.btnOgunDuzenle.Click += new System.EventHandler(this.btnOgunDuzenle_Click);
            // 
            // metroSetControlBox1
            // 
            this.metroSetControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroSetControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroSetControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.DisabledForeColor = System.Drawing.Color.DimGray;
            this.metroSetControlBox1.IsDerivedStyle = true;
            this.metroSetControlBox1.Location = new System.Drawing.Point(685, 11);
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
            this.metroSetControlBox1.TabIndex = 1;
            this.metroSetControlBox1.Text = "metroSetControlBox1";
            this.metroSetControlBox1.ThemeAuthor = "Narwin";
            this.metroSetControlBox1.ThemeName = "MetroLite";
            // 
            // cmbOgunleriListele
            // 
            this.cmbOgunleriListele.AllowDrop = true;
            this.cmbOgunleriListele.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cmbOgunleriListele.BackColor = System.Drawing.Color.Transparent;
            this.cmbOgunleriListele.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cmbOgunleriListele.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cmbOgunleriListele.CausesValidation = false;
            this.cmbOgunleriListele.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cmbOgunleriListele.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.cmbOgunleriListele.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.cmbOgunleriListele.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbOgunleriListele.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOgunleriListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbOgunleriListele.FormattingEnabled = true;
            this.cmbOgunleriListele.IsDerivedStyle = true;
            this.cmbOgunleriListele.ItemHeight = 20;
            this.cmbOgunleriListele.Location = new System.Drawing.Point(15, 86);
            this.cmbOgunleriListele.Name = "cmbOgunleriListele";
            this.cmbOgunleriListele.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cmbOgunleriListele.SelectedItemForeColor = System.Drawing.Color.White;
            this.cmbOgunleriListele.Size = new System.Drawing.Size(121, 26);
            this.cmbOgunleriListele.Style = MetroSet_UI.Enums.Style.Light;
            this.cmbOgunleriListele.StyleManager = null;
            this.cmbOgunleriListele.TabIndex = 2;
            this.cmbOgunleriListele.ThemeAuthor = "Narwin";
            this.cmbOgunleriListele.ThemeName = "MetroLite";
            this.cmbOgunleriListele.SelectedIndexChanged += new System.EventHandler(this.cmbOgunleriListele_SelectedIndexChanged);
            // 
            // dtpMeal
            // 
            this.dtpMeal.Location = new System.Drawing.Point(313, 86);
            this.dtpMeal.Name = "dtpMeal";
            this.dtpMeal.Size = new System.Drawing.Size(200, 27);
            this.dtpMeal.TabIndex = 3;
            // 
            // flpOgunListele
            // 
            this.flpOgunListele.Location = new System.Drawing.Point(15, 130);
            this.flpOgunListele.Name = "flpOgunListele";
            this.flpOgunListele.Size = new System.Drawing.Size(498, 305);
            this.flpOgunListele.TabIndex = 4;
            // 
            // MealForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flpOgunListele);
            this.Controls.Add(this.dtpMeal);
            this.Controls.Add(this.cmbOgunleriListele);
            this.Controls.Add(this.metroSetControlBox1);
            this.Controls.Add(this.btnOgunDuzenle);
            this.Name = "MealForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Style = MetroSet_UI.Enums.Style.Dark;
            this.Text = "Keep Fit";
            this.TextColor = System.Drawing.Color.White;
            this.ThemeName = "MetroDark";
            this.Load += new System.EventHandler(this.MealForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetButton btnOgunDuzenle;
        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private MetroSet_UI.Controls.MetroSetComboBox cmbOgunleriListele;
        private System.Windows.Forms.DateTimePicker dtpMeal;
        private System.Windows.Forms.FlowLayoutPanel flpOgunListele;
    }
}