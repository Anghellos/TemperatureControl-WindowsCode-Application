namespace TempControl
{
    partial class MainFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.TitleDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.TitlePnl = new System.Windows.Forms.Panel();
            this.MinimizeBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.LogoImg = new System.Windows.Forms.PictureBox();
            this.XBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SidePnl = new System.Windows.Forms.Panel();
            this.SelectedTabImg = new System.Windows.Forms.PictureBox();
            this.SettingsBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.DashboardBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.TitleLogoDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.MainElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SwitchLbl = new Telerik.WinControls.UI.RadLabel();
            this.Switch = new Telerik.WinControls.UI.RadToggleSwitch();
            this.DashboardUseControl = new TempControl.Dashboard();
            this.SettingUseControl = new TempControl.Settings();
            this.TitlePnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoImg)).BeginInit();
            this.SidePnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedTabImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SwitchLbl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Switch)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleDragControl
            // 
            this.TitleDragControl.Fixed = true;
            this.TitleDragControl.Horizontal = true;
            this.TitleDragControl.TargetControl = this.TitlePnl;
            this.TitleDragControl.Vertical = true;
            // 
            // TitlePnl
            // 
            this.TitlePnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(89)))), ((int)(((byte)(155)))));
            this.TitlePnl.Controls.Add(this.MinimizeBtn);
            this.TitlePnl.Controls.Add(this.LogoImg);
            this.TitlePnl.Controls.Add(this.XBtn);
            this.TitlePnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitlePnl.Location = new System.Drawing.Point(0, 0);
            this.TitlePnl.Name = "TitlePnl";
            this.TitlePnl.Size = new System.Drawing.Size(860, 44);
            this.TitlePnl.TabIndex = 1;
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(89)))), ((int)(((byte)(155)))));
            this.MinimizeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(89)))), ((int)(((byte)(155)))));
            this.MinimizeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MinimizeBtn.BorderRadius = 0;
            this.MinimizeBtn.ButtonText = "";
            this.MinimizeBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.MinimizeBtn.DisabledColor = System.Drawing.Color.Gray;
            this.MinimizeBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.MinimizeBtn.Iconimage = global::TempControl.Properties.Resources._Btn;
            this.MinimizeBtn.Iconimage_right = null;
            this.MinimizeBtn.Iconimage_right_Selected = null;
            this.MinimizeBtn.Iconimage_Selected = null;
            this.MinimizeBtn.IconMarginLeft = 0;
            this.MinimizeBtn.IconMarginRight = 0;
            this.MinimizeBtn.IconRightVisible = true;
            this.MinimizeBtn.IconRightZoom = 0D;
            this.MinimizeBtn.IconVisible = true;
            this.MinimizeBtn.IconZoom = 40D;
            this.MinimizeBtn.IsTab = false;
            this.MinimizeBtn.Location = new System.Drawing.Point(781, 6);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(89)))), ((int)(((byte)(155)))));
            this.MinimizeBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(89)))), ((int)(((byte)(155)))));
            this.MinimizeBtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(89)))), ((int)(((byte)(155)))));
            this.MinimizeBtn.selected = true;
            this.MinimizeBtn.Size = new System.Drawing.Size(33, 32);
            this.MinimizeBtn.TabIndex = 5;
            this.MinimizeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MinimizeBtn.Textcolor = System.Drawing.Color.White;
            this.MinimizeBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeBtn.Click += new System.EventHandler(this.MinimizeBtn_Click);
            // 
            // LogoImg
            // 
            this.LogoImg.Image = ((System.Drawing.Image)(resources.GetObject("LogoImg.Image")));
            this.LogoImg.Location = new System.Drawing.Point(12, 0);
            this.LogoImg.Name = "LogoImg";
            this.LogoImg.Size = new System.Drawing.Size(115, 43);
            this.LogoImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoImg.TabIndex = 4;
            this.LogoImg.TabStop = false;
            // 
            // XBtn
            // 
            this.XBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(89)))), ((int)(((byte)(155)))));
            this.XBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(89)))), ((int)(((byte)(155)))));
            this.XBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.XBtn.BorderRadius = 0;
            this.XBtn.ButtonText = "";
            this.XBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.XBtn.DisabledColor = System.Drawing.Color.Gray;
            this.XBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.XBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("XBtn.Iconimage")));
            this.XBtn.Iconimage_right = null;
            this.XBtn.Iconimage_right_Selected = null;
            this.XBtn.Iconimage_Selected = null;
            this.XBtn.IconMarginLeft = 0;
            this.XBtn.IconMarginRight = 0;
            this.XBtn.IconRightVisible = true;
            this.XBtn.IconRightZoom = 0D;
            this.XBtn.IconVisible = true;
            this.XBtn.IconZoom = 30D;
            this.XBtn.IsTab = false;
            this.XBtn.Location = new System.Drawing.Point(811, 6);
            this.XBtn.Name = "XBtn";
            this.XBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(89)))), ((int)(((byte)(155)))));
            this.XBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(89)))), ((int)(((byte)(155)))));
            this.XBtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(89)))), ((int)(((byte)(155)))));
            this.XBtn.selected = true;
            this.XBtn.Size = new System.Drawing.Size(33, 32);
            this.XBtn.TabIndex = 3;
            this.XBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.XBtn.Textcolor = System.Drawing.Color.White;
            this.XBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XBtn.Click += new System.EventHandler(this.XBtn_Click);
            // 
            // SidePnl
            // 
            this.SidePnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.SidePnl.Controls.Add(this.SelectedTabImg);
            this.SidePnl.Controls.Add(this.SettingsBtn);
            this.SidePnl.Controls.Add(this.DashboardBtn);
            this.SidePnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePnl.Location = new System.Drawing.Point(0, 44);
            this.SidePnl.Name = "SidePnl";
            this.SidePnl.Size = new System.Drawing.Size(209, 494);
            this.SidePnl.TabIndex = 0;
            // 
            // SelectedTabImg
            // 
            this.SelectedTabImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(89)))), ((int)(((byte)(155)))));
            this.SelectedTabImg.Location = new System.Drawing.Point(0, 25);
            this.SelectedTabImg.Name = "SelectedTabImg";
            this.SelectedTabImg.Size = new System.Drawing.Size(5, 48);
            this.SelectedTabImg.TabIndex = 2;
            this.SelectedTabImg.TabStop = false;
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.SettingsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.SettingsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SettingsBtn.BorderRadius = 0;
            this.SettingsBtn.ButtonText = "     Settings";
            this.SettingsBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.SettingsBtn.DisabledColor = System.Drawing.Color.Gray;
            this.SettingsBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.SettingsBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("SettingsBtn.Iconimage")));
            this.SettingsBtn.Iconimage_right = null;
            this.SettingsBtn.Iconimage_right_Selected = null;
            this.SettingsBtn.Iconimage_Selected = null;
            this.SettingsBtn.IconMarginLeft = 20;
            this.SettingsBtn.IconMarginRight = 0;
            this.SettingsBtn.IconRightVisible = true;
            this.SettingsBtn.IconRightZoom = 0D;
            this.SettingsBtn.IconVisible = true;
            this.SettingsBtn.IconZoom = 60D;
            this.SettingsBtn.IsTab = false;
            this.SettingsBtn.Location = new System.Drawing.Point(0, 72);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.SettingsBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.SettingsBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.SettingsBtn.selected = true;
            this.SettingsBtn.Size = new System.Drawing.Size(209, 48);
            this.SettingsBtn.TabIndex = 2;
            this.SettingsBtn.Text = "     Settings";
            this.SettingsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingsBtn.Textcolor = System.Drawing.Color.LightGray;
            this.SettingsBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsBtn.Click += new System.EventHandler(this.SettingsBtn_Click);
            // 
            // DashboardBtn
            // 
            this.DashboardBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.DashboardBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.DashboardBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DashboardBtn.BorderRadius = 0;
            this.DashboardBtn.ButtonText = "     Dashboard";
            this.DashboardBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.DashboardBtn.DisabledColor = System.Drawing.Color.Gray;
            this.DashboardBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.DashboardBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("DashboardBtn.Iconimage")));
            this.DashboardBtn.Iconimage_right = null;
            this.DashboardBtn.Iconimage_right_Selected = null;
            this.DashboardBtn.Iconimage_Selected = null;
            this.DashboardBtn.IconMarginLeft = 20;
            this.DashboardBtn.IconMarginRight = 0;
            this.DashboardBtn.IconRightVisible = true;
            this.DashboardBtn.IconRightZoom = 0D;
            this.DashboardBtn.IconVisible = true;
            this.DashboardBtn.IconZoom = 60D;
            this.DashboardBtn.IsTab = false;
            this.DashboardBtn.Location = new System.Drawing.Point(0, 25);
            this.DashboardBtn.Name = "DashboardBtn";
            this.DashboardBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.DashboardBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.DashboardBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.DashboardBtn.selected = true;
            this.DashboardBtn.Size = new System.Drawing.Size(209, 48);
            this.DashboardBtn.TabIndex = 1;
            this.DashboardBtn.Text = "     Dashboard";
            this.DashboardBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DashboardBtn.Textcolor = System.Drawing.Color.LightGray;
            this.DashboardBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashboardBtn.Click += new System.EventHandler(this.DashboardBtn_Click);
            // 
            // TitleLogoDragControl
            // 
            this.TitleLogoDragControl.Fixed = true;
            this.TitleLogoDragControl.Horizontal = true;
            this.TitleLogoDragControl.TargetControl = this.LogoImg;
            this.TitleLogoDragControl.Vertical = true;
            // 
            // MainElipse
            // 
            this.MainElipse.ElipseRadius = 5;
            this.MainElipse.TargetControl = this;
            // 
            // SwitchLbl
            // 
            this.SwitchLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.SwitchLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(97)))), ((int)(((byte)(108)))));
            this.SwitchLbl.Location = new System.Drawing.Point(776, 51);
            this.SwitchLbl.Name = "SwitchLbl";
            this.SwitchLbl.Size = new System.Drawing.Size(26, 19);
            this.SwitchLbl.TabIndex = 30;
            this.SwitchLbl.Text = "On";
            this.SwitchLbl.ThemeName = "Material";
            // 
            // Switch
            // 
            this.Switch.Location = new System.Drawing.Point(806, 50);
            this.Switch.Name = "Switch";
            this.Switch.Size = new System.Drawing.Size(36, 20);
            this.Switch.TabIndex = 29;
            this.Switch.Text = "radToggleSwitch1";
            this.Switch.ThemeName = "Material";
            this.Switch.ValueChanged += new System.EventHandler(this.Switch_ValueChanged);
            // 
            // DashboardUseControl
            // 
            this.DashboardUseControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(212)))), ((int)(((byte)(217)))));
            this.DashboardUseControl.Location = new System.Drawing.Point(210, 72);
            this.DashboardUseControl.Name = "DashboardUseControl";
            this.DashboardUseControl.Size = new System.Drawing.Size(649, 464);
            this.DashboardUseControl.TabIndex = 32;
            // 
            // SettingUseControl
            // 
            this.SettingUseControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(212)))), ((int)(((byte)(217)))));
            this.SettingUseControl.Location = new System.Drawing.Point(210, 72);
            this.SettingUseControl.Name = "SettingUseControl";
            this.SettingUseControl.Size = new System.Drawing.Size(649, 465);
            this.SettingUseControl.TabIndex = 31;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(212)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(860, 538);
            this.Controls.Add(this.DashboardUseControl);
            this.Controls.Add(this.SettingUseControl);
            this.Controls.Add(this.SwitchLbl);
            this.Controls.Add(this.SidePnl);
            this.Controls.Add(this.Switch);
            this.Controls.Add(this.TitlePnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainFrm";
            this.Text = "Temp Control";
            this.TitlePnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoImg)).EndInit();
            this.SidePnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SelectedTabImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SwitchLbl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Switch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel TitlePnl;
        private Bunifu.Framework.UI.BunifuFlatButton XBtn;
        private Bunifu.Framework.UI.BunifuFlatButton DashboardBtn;
        private System.Windows.Forms.Panel SidePnl;
        private Bunifu.Framework.UI.BunifuDragControl TitleDragControl;
        private Bunifu.Framework.UI.BunifuDragControl TitleLogoDragControl;
        private System.Windows.Forms.PictureBox LogoImg;
        private System.Windows.Forms.PictureBox SelectedTabImg;
        private Bunifu.Framework.UI.BunifuElipse MainElipse;
        private Bunifu.Framework.UI.BunifuFlatButton SettingsBtn;
        private Telerik.WinControls.UI.RadLabel SwitchLbl;
        private Telerik.WinControls.UI.RadToggleSwitch Switch;
        private Dashboard DashboardUseControl;
        private Settings SettingUseControl;
        private Bunifu.Framework.UI.BunifuFlatButton MinimizeBtn;
    }
}

