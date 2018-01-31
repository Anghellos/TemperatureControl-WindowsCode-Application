namespace TempControl
{
    partial class Dashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.WinControls.UI.CartesianArea cartesianArea2 = new Telerik.WinControls.UI.CartesianArea();
            Telerik.WinControls.UI.CategoricalAxis categoricalAxis2 = new Telerik.WinControls.UI.CategoricalAxis();
            Telerik.WinControls.UI.LinearAxis linearAxis2 = new Telerik.WinControls.UI.LinearAxis();
            Telerik.WinControls.UI.LineSeries lineSeries2 = new Telerik.WinControls.UI.LineSeries();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.TempHumChart = new Telerik.WinControls.UI.RadChartView();
            this.materialTheme = new Telerik.WinControls.Themes.MaterialTheme();
            this.TempInCrd = new Telerik.WinControls.UI.RadCardView();
            this.HouseTempIntLbl = new Telerik.WinControls.UI.RadLabel();
            this.TempInLbl = new Telerik.WinControls.UI.RadLabel();
            this.TempValueInLbl = new System.Windows.Forms.Label();
            this.TempPrgInBr = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.TempOutCrd = new Telerik.WinControls.UI.RadCardView();
            this.ClujTempOutLbl = new Telerik.WinControls.UI.RadLabel();
            this.TempOutLbl = new Telerik.WinControls.UI.RadLabel();
            this.TempValueOutLbl = new System.Windows.Forms.Label();
            this.TempPrgOutBr = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            ((System.ComponentModel.ISupportInitialize)(this.TempHumChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TempInCrd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TempInCrd.CardTemplate)).BeginInit();
            this.TempInCrd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HouseTempIntLbl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TempInLbl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TempOutCrd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TempOutCrd.CardTemplate)).BeginInit();
            this.TempOutCrd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClujTempOutLbl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TempOutLbl)).BeginInit();
            this.SuspendLayout();
            // 
            // TempHumChart
            // 
            this.TempHumChart.AreaDesign = cartesianArea2;
            categoricalAxis2.IsPrimary = true;
            categoricalAxis2.LabelRotationAngle = 300D;
            categoricalAxis2.Title = "";
            linearAxis2.AxisType = Telerik.Charting.AxisType.Second;
            linearAxis2.IsPrimary = true;
            linearAxis2.LabelRotationAngle = 300D;
            linearAxis2.TickOrigin = null;
            linearAxis2.Title = "";
            this.TempHumChart.Axes.AddRange(new Telerik.WinControls.UI.Axis[] {
            categoricalAxis2,
            linearAxis2});
            this.TempHumChart.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TempHumChart.Location = new System.Drawing.Point(10, 199);
            this.TempHumChart.Name = "TempHumChart";
            lineSeries2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(210)))), ((int)(((byte)(79)))));
            lineSeries2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(210)))), ((int)(((byte)(79)))));
            lineSeries2.HorizontalAxis = categoricalAxis2;
            lineSeries2.LabelAngle = 90D;
            lineSeries2.LabelDistanceToPoint = 15D;
            lineSeries2.Spline = true;
            lineSeries2.VerticalAxis = linearAxis2;
            this.TempHumChart.Series.AddRange(new Telerik.WinControls.UI.ChartSeries[] {
            lineSeries2});
            this.TempHumChart.ShowGrid = false;
            this.TempHumChart.Size = new System.Drawing.Size(627, 253);
            this.TempHumChart.TabIndex = 17;
            this.TempHumChart.Text = " ";
            this.TempHumChart.ThemeName = "Material";
            // 
            // TempInCrd
            // 
            this.TempInCrd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.TempInCrd.CardTemplate.Location = new System.Drawing.Point(143, 91);
            this.TempInCrd.CardTemplate.Name = "";
            this.TempInCrd.CardTemplate.Size = new System.Drawing.Size(0, 0);
            this.TempInCrd.CardTemplate.TabIndex = 0;
            this.TempInCrd.Controls.Add(this.HouseTempIntLbl);
            this.TempInCrd.Controls.Add(this.TempInLbl);
            this.TempInCrd.Controls.Add(this.TempValueInLbl);
            this.TempInCrd.Controls.Add(this.TempPrgInBr);
            this.TempInCrd.GroupItemSize = new System.Drawing.Size(309, 225);
            this.TempInCrd.ItemSize = new System.Drawing.Size(0, 0);
            this.TempInCrd.Location = new System.Drawing.Point(28, 10);
            this.TempInCrd.Name = "TempInCrd";
            this.TempInCrd.Size = new System.Drawing.Size(287, 183);
            this.TempInCrd.TabIndex = 23;
            this.TempInCrd.ThemeName = "Material";
            // 
            // HouseTempIntLbl
            // 
            this.HouseTempIntLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.HouseTempIntLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(97)))), ((int)(((byte)(108)))));
            this.HouseTempIntLbl.Location = new System.Drawing.Point(13, 5);
            this.HouseTempIntLbl.Name = "HouseTempIntLbl";
            this.HouseTempIntLbl.Size = new System.Drawing.Size(23, 23);
            this.HouseTempIntLbl.TabIndex = 13;
            this.HouseTempIntLbl.Text = "In";
            this.HouseTempIntLbl.ThemeName = "Material";
            // 
            // TempInLbl
            // 
            this.TempInLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TempInLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(97)))), ((int)(((byte)(108)))));
            this.TempInLbl.Location = new System.Drawing.Point(78, 150);
            this.TempInLbl.Name = "TempInLbl";
            this.TempInLbl.Size = new System.Drawing.Size(133, 28);
            this.TempInLbl.TabIndex = 12;
            this.TempInLbl.Text = "Temperature";
            this.TempInLbl.ThemeName = "Material";
            // 
            // TempValueInLbl
            // 
            this.TempValueInLbl.AutoSize = true;
            this.TempValueInLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.TempValueInLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.TempValueInLbl.Location = new System.Drawing.Point(98, 66);
            this.TempValueInLbl.Name = "TempValueInLbl";
            this.TempValueInLbl.Size = new System.Drawing.Size(97, 29);
            this.TempValueInLbl.TabIndex = 11;
            this.TempValueInLbl.Text = "00.0 °C";
            // 
            // TempPrgInBr
            // 
            this.TempPrgInBr.animated = false;
            this.TempPrgInBr.animationIterval = 5;
            this.TempPrgInBr.animationSpeed = 300;
            this.TempPrgInBr.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.TempPrgInBr.BackColor = System.Drawing.Color.White;
            this.TempPrgInBr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TempPrgInBr.BackgroundImage")));
            this.TempPrgInBr.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.TempPrgInBr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(116)))), ((int)(((byte)(117)))));
            this.TempPrgInBr.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TempPrgInBr.LabelVisible = false;
            this.TempPrgInBr.LineProgressThickness = 8;
            this.TempPrgInBr.LineThickness = 2;
            this.TempPrgInBr.Location = new System.Drawing.Point(70, 5);
            this.TempPrgInBr.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.TempPrgInBr.MaxValue = 40;
            this.TempPrgInBr.Name = "TempPrgInBr";
            this.TempPrgInBr.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(97)))), ((int)(((byte)(108)))));
            this.TempPrgInBr.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(116)))), ((int)(((byte)(117)))));
            this.TempPrgInBr.Size = new System.Drawing.Size(147, 147);
            this.TempPrgInBr.TabIndex = 10;
            this.TempPrgInBr.Value = 27;
            // 
            // TempOutCrd
            // 
            this.TempOutCrd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.TempOutCrd.CardTemplate.Location = new System.Drawing.Point(143, 91);
            this.TempOutCrd.CardTemplate.Name = "";
            this.TempOutCrd.CardTemplate.Size = new System.Drawing.Size(0, 0);
            this.TempOutCrd.CardTemplate.TabIndex = 0;
            this.TempOutCrd.Controls.Add(this.ClujTempOutLbl);
            this.TempOutCrd.Controls.Add(this.TempOutLbl);
            this.TempOutCrd.Controls.Add(this.TempValueOutLbl);
            this.TempOutCrd.Controls.Add(this.TempPrgOutBr);
            this.TempOutCrd.GroupItemSize = new System.Drawing.Size(309, 225);
            this.TempOutCrd.ItemSize = new System.Drawing.Size(0, 0);
            this.TempOutCrd.Location = new System.Drawing.Point(329, 10);
            this.TempOutCrd.Name = "TempOutCrd";
            this.TempOutCrd.Size = new System.Drawing.Size(287, 183);
            this.TempOutCrd.TabIndex = 24;
            this.TempOutCrd.ThemeName = "Material";
            // 
            // ClujTempOutLbl
            // 
            this.ClujTempOutLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.ClujTempOutLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(97)))), ((int)(((byte)(108)))));
            this.ClujTempOutLbl.Location = new System.Drawing.Point(13, 5);
            this.ClujTempOutLbl.Name = "ClujTempOutLbl";
            this.ClujTempOutLbl.Size = new System.Drawing.Size(36, 23);
            this.ClujTempOutLbl.TabIndex = 14;
            this.ClujTempOutLbl.Text = "Out";
            this.ClujTempOutLbl.ThemeName = "Material";
            // 
            // TempOutLbl
            // 
            this.TempOutLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TempOutLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(97)))), ((int)(((byte)(108)))));
            this.TempOutLbl.Location = new System.Drawing.Point(78, 150);
            this.TempOutLbl.Name = "TempOutLbl";
            this.TempOutLbl.Size = new System.Drawing.Size(133, 28);
            this.TempOutLbl.TabIndex = 12;
            this.TempOutLbl.Text = "Temperature";
            this.TempOutLbl.ThemeName = "Material";
            // 
            // TempValueOutLbl
            // 
            this.TempValueOutLbl.AutoSize = true;
            this.TempValueOutLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.TempValueOutLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(166)))), ((int)(((byte)(245)))));
            this.TempValueOutLbl.Location = new System.Drawing.Point(98, 66);
            this.TempValueOutLbl.Name = "TempValueOutLbl";
            this.TempValueOutLbl.Size = new System.Drawing.Size(97, 29);
            this.TempValueOutLbl.TabIndex = 11;
            this.TempValueOutLbl.Text = "00.0 °C";
            // 
            // TempPrgOutBr
            // 
            this.TempPrgOutBr.animated = false;
            this.TempPrgOutBr.animationIterval = 5;
            this.TempPrgOutBr.animationSpeed = 300;
            this.TempPrgOutBr.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.TempPrgOutBr.BackColor = System.Drawing.Color.White;
            this.TempPrgOutBr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TempPrgOutBr.BackgroundImage")));
            this.TempPrgOutBr.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.TempPrgOutBr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(166)))), ((int)(((byte)(245)))));
            this.TempPrgOutBr.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TempPrgOutBr.LabelVisible = false;
            this.TempPrgOutBr.LineProgressThickness = 8;
            this.TempPrgOutBr.LineThickness = 2;
            this.TempPrgOutBr.Location = new System.Drawing.Point(70, 5);
            this.TempPrgOutBr.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.TempPrgOutBr.MaxValue = 40;
            this.TempPrgOutBr.Name = "TempPrgOutBr";
            this.TempPrgOutBr.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(97)))), ((int)(((byte)(108)))));
            this.TempPrgOutBr.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(166)))), ((int)(((byte)(245)))));
            this.TempPrgOutBr.Size = new System.Drawing.Size(147, 147);
            this.TempPrgOutBr.TabIndex = 10;
            this.TempPrgOutBr.Value = 10;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(212)))), ((int)(((byte)(217)))));
            this.Controls.Add(this.TempOutCrd);
            this.Controls.Add(this.TempInCrd);
            this.Controls.Add(this.TempHumChart);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(649, 465);
            ((System.ComponentModel.ISupportInitialize)(this.TempHumChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TempInCrd.CardTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TempInCrd)).EndInit();
            this.TempInCrd.ResumeLayout(false);
            this.TempInCrd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HouseTempIntLbl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TempInLbl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TempOutCrd.CardTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TempOutCrd)).EndInit();
            this.TempOutCrd.ResumeLayout(false);
            this.TempOutCrd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClujTempOutLbl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TempOutLbl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.UI.RadChartView TempHumChart;
        private Telerik.WinControls.Themes.MaterialTheme materialTheme;
        private Telerik.WinControls.UI.RadCardView TempInCrd;
        private Telerik.WinControls.UI.RadLabel TempInLbl;
        private System.Windows.Forms.Label TempValueInLbl;
        private Bunifu.Framework.UI.BunifuCircleProgressbar TempPrgInBr;
        private Telerik.WinControls.UI.RadCardView TempOutCrd;
        private Telerik.WinControls.UI.RadLabel TempOutLbl;
        private System.Windows.Forms.Label TempValueOutLbl;
        private Bunifu.Framework.UI.BunifuCircleProgressbar TempPrgOutBr;
        private Telerik.WinControls.UI.RadLabel HouseTempIntLbl;
        private Telerik.WinControls.UI.RadLabel ClujTempOutLbl;
    }
}
