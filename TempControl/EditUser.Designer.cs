namespace TempControl
{
    partial class EditUserFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditUserFrm));
            this.EditUserElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.OkBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.CancelBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.TitlePnl = new System.Windows.Forms.Panel();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.XBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.TitleDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.TitleTextDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.EditNameCard = new Bunifu.Framework.UI.BunifuCards();
            this.UsernameText = new Telerik.WinControls.UI.RadTextBox();
            this.TitlePnl.SuspendLayout();
            this.EditNameCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsernameText)).BeginInit();
            this.SuspendLayout();
            // 
            // EditUserElipse
            // 
            this.EditUserElipse.ElipseRadius = 5;
            this.EditUserElipse.TargetControl = this;
            // 
            // OkBtn
            // 
            this.OkBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.OkBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.OkBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OkBtn.BorderRadius = 0;
            this.OkBtn.ButtonText = "Ok";
            this.OkBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OkBtn.DisabledColor = System.Drawing.Color.Gray;
            this.OkBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.OkBtn.Iconimage = null;
            this.OkBtn.Iconimage_right = null;
            this.OkBtn.Iconimage_right_Selected = null;
            this.OkBtn.Iconimage_Selected = null;
            this.OkBtn.IconMarginLeft = 0;
            this.OkBtn.IconMarginRight = 0;
            this.OkBtn.IconRightVisible = true;
            this.OkBtn.IconRightZoom = 0D;
            this.OkBtn.IconVisible = true;
            this.OkBtn.IconZoom = 90D;
            this.OkBtn.IsTab = false;
            this.OkBtn.Location = new System.Drawing.Point(180, 75);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.OkBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.OkBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.OkBtn.selected = false;
            this.OkBtn.Size = new System.Drawing.Size(127, 36);
            this.OkBtn.TabIndex = 1;
            this.OkBtn.Text = "Ok";
            this.OkBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OkBtn.Textcolor = System.Drawing.Color.White;
            this.OkBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(116)))), ((int)(((byte)(117)))));
            this.CancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(116)))), ((int)(((byte)(117)))));
            this.CancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelBtn.BorderRadius = 0;
            this.CancelBtn.ButtonText = "Cancel";
            this.CancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelBtn.DisabledColor = System.Drawing.Color.Gray;
            this.CancelBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.CancelBtn.Iconimage = null;
            this.CancelBtn.Iconimage_right = null;
            this.CancelBtn.Iconimage_right_Selected = null;
            this.CancelBtn.Iconimage_Selected = null;
            this.CancelBtn.IconMarginLeft = 0;
            this.CancelBtn.IconMarginRight = 0;
            this.CancelBtn.IconRightVisible = true;
            this.CancelBtn.IconRightZoom = 0D;
            this.CancelBtn.IconVisible = true;
            this.CancelBtn.IconZoom = 90D;
            this.CancelBtn.IsTab = false;
            this.CancelBtn.Location = new System.Drawing.Point(10, 75);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(116)))), ((int)(((byte)(117)))));
            this.CancelBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(106)))), ((int)(((byte)(107)))));
            this.CancelBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.CancelBtn.selected = false;
            this.CancelBtn.Size = new System.Drawing.Size(127, 36);
            this.CancelBtn.TabIndex = 2;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CancelBtn.Textcolor = System.Drawing.Color.White;
            this.CancelBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // TitlePnl
            // 
            this.TitlePnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(89)))), ((int)(((byte)(155)))));
            this.TitlePnl.Controls.Add(this.TitleLbl);
            this.TitlePnl.Controls.Add(this.XBtn);
            this.TitlePnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitlePnl.Location = new System.Drawing.Point(0, 0);
            this.TitlePnl.Name = "TitlePnl";
            this.TitlePnl.Size = new System.Drawing.Size(336, 44);
            this.TitlePnl.TabIndex = 3;
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TitleLbl.Location = new System.Drawing.Point(11, 11);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(115, 20);
            this.TitleLbl.TabIndex = 4;
            this.TitleLbl.Text = "Edit user name";
            // 
            // XBtn
            // 
            this.XBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(89)))), ((int)(((byte)(155)))));
            this.XBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(89)))), ((int)(((byte)(155)))));
            this.XBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.XBtn.BorderRadius = 0;
            this.XBtn.ButtonText = "";
            this.XBtn.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.XBtn.Location = new System.Drawing.Point(296, 6);
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
            // TitleDragControl
            // 
            this.TitleDragControl.Fixed = true;
            this.TitleDragControl.Horizontal = true;
            this.TitleDragControl.TargetControl = this.TitlePnl;
            this.TitleDragControl.Vertical = true;
            // 
            // TitleTextDragControl
            // 
            this.TitleTextDragControl.Fixed = true;
            this.TitleTextDragControl.Horizontal = true;
            this.TitleTextDragControl.TargetControl = this.TitleLbl;
            this.TitleTextDragControl.Vertical = true;
            // 
            // EditNameCard
            // 
            this.EditNameCard.BackColor = System.Drawing.Color.White;
            this.EditNameCard.BorderRadius = 5;
            this.EditNameCard.BottomSahddow = true;
            this.EditNameCard.color = System.Drawing.SystemColors.Control;
            this.EditNameCard.Controls.Add(this.UsernameText);
            this.EditNameCard.Controls.Add(this.CancelBtn);
            this.EditNameCard.Controls.Add(this.OkBtn);
            this.EditNameCard.LeftSahddow = false;
            this.EditNameCard.Location = new System.Drawing.Point(8, 50);
            this.EditNameCard.Name = "EditNameCard";
            this.EditNameCard.RightSahddow = true;
            this.EditNameCard.ShadowDepth = 20;
            this.EditNameCard.Size = new System.Drawing.Size(319, 129);
            this.EditNameCard.TabIndex = 4;
            // 
            // UsernameText
            // 
            this.UsernameText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(97)))), ((int)(((byte)(108)))));
            this.UsernameText.Location = new System.Drawing.Point(46, 20);
            this.UsernameText.Name = "UsernameText";
            this.UsernameText.Size = new System.Drawing.Size(219, 20);
            this.UsernameText.TabIndex = 17;
            this.UsernameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UsernameText.ThemeName = "Material";
            // 
            // EditUserFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(212)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(336, 189);
            this.Controls.Add(this.EditNameCard);
            this.Controls.Add(this.TitlePnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditUserFrm";
            this.Text = "EditUser";
            this.TitlePnl.ResumeLayout(false);
            this.TitlePnl.PerformLayout();
            this.EditNameCard.ResumeLayout(false);
            this.EditNameCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsernameText)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse EditUserElipse;
        private Bunifu.Framework.UI.BunifuFlatButton CancelBtn;
        private Bunifu.Framework.UI.BunifuFlatButton OkBtn;
        private System.Windows.Forms.Panel TitlePnl;
        private Bunifu.Framework.UI.BunifuFlatButton XBtn;
        private System.Windows.Forms.Label TitleLbl;
        private Bunifu.Framework.UI.BunifuDragControl TitleDragControl;
        private Bunifu.Framework.UI.BunifuDragControl TitleTextDragControl;
        private Bunifu.Framework.UI.BunifuCards EditNameCard;
        private Telerik.WinControls.UI.RadTextBox UsernameText;
    }
}