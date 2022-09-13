namespace MalinSpaceIPC
{
    partial class MalinSpaceIPC
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
            this.listViewCalculations = new System.Windows.Forms.ListView();
            this.StarVelocity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StarDistance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Temperature = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EventHorizon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxStarVelocity = new System.Windows.Forms.GroupBox();
            this.textBoxRest = new System.Windows.Forms.TextBox();
            this.labelRest = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxObserve = new System.Windows.Forms.TextBox();
            this.groupBoxStarDistance = new System.Windows.Forms.GroupBox();
            this.labelArcAngle = new System.Windows.Forms.Label();
            this.textBoxArc = new System.Windows.Forms.TextBox();
            this.groupBoxTemp = new System.Windows.Forms.GroupBox();
            this.labelCelcius = new System.Windows.Forms.Label();
            this.textBoxCelcius = new System.Windows.Forms.TextBox();
            this.groupBoxEventHorizon = new System.Windows.Forms.GroupBox();
            this.numericUpDownPower = new System.Windows.Forms.NumericUpDown();
            this.labelPower = new System.Windows.Forms.Label();
            this.labelMass = new System.Windows.Forms.Label();
            this.textBoxMass = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foregroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxStarVelocity.SuspendLayout();
            this.groupBoxStarDistance.SuspendLayout();
            this.groupBoxTemp.SuspendLayout();
            this.groupBoxEventHorizon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPower)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewCalculations
            // 
            this.listViewCalculations.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.StarVelocity,
            this.StarDistance,
            this.Temperature,
            this.EventHorizon});
            this.listViewCalculations.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listViewCalculations.HideSelection = false;
            this.listViewCalculations.Location = new System.Drawing.Point(484, 95);
            this.listViewCalculations.Margin = new System.Windows.Forms.Padding(4);
            this.listViewCalculations.Name = "listViewCalculations";
            this.listViewCalculations.Size = new System.Drawing.Size(715, 405);
            this.listViewCalculations.TabIndex = 0;
            this.listViewCalculations.UseCompatibleStateImageBehavior = false;
            this.listViewCalculations.View = System.Windows.Forms.View.Details;
            // 
            // StarVelocity
            // 
            this.StarVelocity.Text = "Star Velocity";
            this.StarVelocity.Width = 174;
            // 
            // StarDistance
            // 
            this.StarDistance.Text = "Star Distance";
            this.StarDistance.Width = 208;
            // 
            // Temperature
            // 
            this.Temperature.Text = "Temperature";
            this.Temperature.Width = 113;
            // 
            // EventHorizon
            // 
            this.EventHorizon.Text = "Event Horizon";
            this.EventHorizon.Width = 196;
            // 
            // groupBoxStarVelocity
            // 
            this.groupBoxStarVelocity.Controls.Add(this.textBoxRest);
            this.groupBoxStarVelocity.Controls.Add(this.labelRest);
            this.groupBoxStarVelocity.Controls.Add(this.label1);
            this.groupBoxStarVelocity.Controls.Add(this.textBoxObserve);
            this.groupBoxStarVelocity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxStarVelocity.Location = new System.Drawing.Point(18, 20);
            this.groupBoxStarVelocity.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxStarVelocity.Name = "groupBoxStarVelocity";
            this.groupBoxStarVelocity.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxStarVelocity.Size = new System.Drawing.Size(420, 111);
            this.groupBoxStarVelocity.TabIndex = 1;
            this.groupBoxStarVelocity.TabStop = false;
            this.groupBoxStarVelocity.Text = "Star Velocity";
            // 
            // textBoxRest
            // 
            this.textBoxRest.Location = new System.Drawing.Point(165, 75);
            this.textBoxRest.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRest.Name = "textBoxRest";
            this.textBoxRest.Size = new System.Drawing.Size(148, 22);
            this.textBoxRest.TabIndex = 4;
            this.textBoxRest.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRest_KeyPress);
            // 
            // labelRest
            // 
            this.labelRest.AutoSize = true;
            this.labelRest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRest.Location = new System.Drawing.Point(13, 75);
            this.labelRest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRest.Name = "labelRest";
            this.labelRest.Size = new System.Drawing.Size(33, 13);
            this.labelRest.TabIndex = 3;
            this.labelRest.Text = "Rest";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Observe";
            // 
            // textBoxObserve
            // 
            this.textBoxObserve.Location = new System.Drawing.Point(165, 32);
            this.textBoxObserve.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxObserve.Name = "textBoxObserve";
            this.textBoxObserve.Size = new System.Drawing.Size(148, 22);
            this.textBoxObserve.TabIndex = 2;
            this.textBoxObserve.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxObserve_KeyPress);
            // 
            // groupBoxStarDistance
            // 
            this.groupBoxStarDistance.Controls.Add(this.labelArcAngle);
            this.groupBoxStarDistance.Controls.Add(this.textBoxArc);
            this.groupBoxStarDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxStarDistance.Location = new System.Drawing.Point(18, 153);
            this.groupBoxStarDistance.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxStarDistance.Name = "groupBoxStarDistance";
            this.groupBoxStarDistance.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxStarDistance.Size = new System.Drawing.Size(420, 77);
            this.groupBoxStarDistance.TabIndex = 5;
            this.groupBoxStarDistance.TabStop = false;
            this.groupBoxStarDistance.Text = "Star Distance";
            // 
            // labelArcAngle
            // 
            this.labelArcAngle.AutoSize = true;
            this.labelArcAngle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArcAngle.Location = new System.Drawing.Point(10, 32);
            this.labelArcAngle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelArcAngle.Name = "labelArcAngle";
            this.labelArcAngle.Size = new System.Drawing.Size(62, 13);
            this.labelArcAngle.TabIndex = 2;
            this.labelArcAngle.Text = "Arc Angle";
            // 
            // textBoxArc
            // 
            this.textBoxArc.Location = new System.Drawing.Point(165, 32);
            this.textBoxArc.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxArc.Name = "textBoxArc";
            this.textBoxArc.Size = new System.Drawing.Size(148, 22);
            this.textBoxArc.TabIndex = 2;
            this.textBoxArc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxArc_KeyPress);
            // 
            // groupBoxTemp
            // 
            this.groupBoxTemp.Controls.Add(this.labelCelcius);
            this.groupBoxTemp.Controls.Add(this.textBoxCelcius);
            this.groupBoxTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTemp.Location = new System.Drawing.Point(18, 249);
            this.groupBoxTemp.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxTemp.Name = "groupBoxTemp";
            this.groupBoxTemp.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxTemp.Size = new System.Drawing.Size(420, 75);
            this.groupBoxTemp.TabIndex = 6;
            this.groupBoxTemp.TabStop = false;
            this.groupBoxTemp.Text = "Temperature";
            // 
            // labelCelcius
            // 
            this.labelCelcius.AutoSize = true;
            this.labelCelcius.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCelcius.Location = new System.Drawing.Point(10, 32);
            this.labelCelcius.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCelcius.Name = "labelCelcius";
            this.labelCelcius.Size = new System.Drawing.Size(48, 13);
            this.labelCelcius.TabIndex = 2;
            this.labelCelcius.Text = "Celcius";
            // 
            // textBoxCelcius
            // 
            this.textBoxCelcius.Location = new System.Drawing.Point(165, 32);
            this.textBoxCelcius.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCelcius.Name = "textBoxCelcius";
            this.textBoxCelcius.Size = new System.Drawing.Size(148, 22);
            this.textBoxCelcius.TabIndex = 2;
            this.textBoxCelcius.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCelcius_KeyPress);
            // 
            // groupBoxEventHorizon
            // 
            this.groupBoxEventHorizon.Controls.Add(this.numericUpDownPower);
            this.groupBoxEventHorizon.Controls.Add(this.labelPower);
            this.groupBoxEventHorizon.Controls.Add(this.labelMass);
            this.groupBoxEventHorizon.Controls.Add(this.textBoxMass);
            this.groupBoxEventHorizon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxEventHorizon.Location = new System.Drawing.Point(18, 340);
            this.groupBoxEventHorizon.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxEventHorizon.Name = "groupBoxEventHorizon";
            this.groupBoxEventHorizon.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxEventHorizon.Size = new System.Drawing.Size(420, 85);
            this.groupBoxEventHorizon.TabIndex = 7;
            this.groupBoxEventHorizon.TabStop = false;
            this.groupBoxEventHorizon.Text = "Event Horizon";
            // 
            // numericUpDownPower
            // 
            this.numericUpDownPower.Location = new System.Drawing.Point(350, 36);
            this.numericUpDownPower.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownPower.Name = "numericUpDownPower";
            this.numericUpDownPower.Size = new System.Drawing.Size(60, 22);
            this.numericUpDownPower.TabIndex = 8;
            // 
            // labelPower
            // 
            this.labelPower.AutoSize = true;
            this.labelPower.Location = new System.Drawing.Point(302, 38);
            this.labelPower.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPower.Name = "labelPower";
            this.labelPower.Size = new System.Drawing.Size(34, 16);
            this.labelPower.TabIndex = 8;
            this.labelPower.Text = "x 10";
            // 
            // labelMass
            // 
            this.labelMass.AutoSize = true;
            this.labelMass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMass.Location = new System.Drawing.Point(10, 39);
            this.labelMass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMass.Name = "labelMass";
            this.labelMass.Size = new System.Drawing.Size(36, 13);
            this.labelMass.TabIndex = 2;
            this.labelMass.Text = "Mass";
            // 
            // textBoxMass
            // 
            this.textBoxMass.Location = new System.Drawing.Point(165, 36);
            this.textBoxMass.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMass.Name = "textBoxMass";
            this.textBoxMass.Size = new System.Drawing.Size(133, 22);
            this.textBoxMass.TabIndex = 2;
            this.textBoxMass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMass_KeyPress);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalculate.Location = new System.Drawing.Point(117, 458);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(179, 32);
            this.buttonCalculate.TabIndex = 8;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseMnemonic = false;
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(527, 9);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(124, 25);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themeToolStripMenuItem,
            this.colourToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(116, 21);
            this.fileToolStripMenuItem.Text = "Theme Settings";
            // 
            // themeToolStripMenuItem
            // 
            this.themeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dayToolStripMenuItem,
            this.nightToolStripMenuItem});
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            this.themeToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.themeToolStripMenuItem.Text = "Theme";
            // 
            // dayToolStripMenuItem
            // 
            this.dayToolStripMenuItem.Name = "dayToolStripMenuItem";
            this.dayToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.dayToolStripMenuItem.Text = "Day";
            this.dayToolStripMenuItem.Click += new System.EventHandler(this.dayToolStripMenuItem_Click);
            // 
            // nightToolStripMenuItem
            // 
            this.nightToolStripMenuItem.Name = "nightToolStripMenuItem";
            this.nightToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.nightToolStripMenuItem.Text = "Night";
            this.nightToolStripMenuItem.Click += new System.EventHandler(this.nightToolStripMenuItem_Click);
            // 
            // colourToolStripMenuItem
            // 
            this.colourToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backgroundToolStripMenuItem,
            this.foregroundToolStripMenuItem});
            this.colourToolStripMenuItem.Name = "colourToolStripMenuItem";
            this.colourToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.colourToolStripMenuItem.Text = "Colour";
            // 
            // backgroundToolStripMenuItem
            // 
            this.backgroundToolStripMenuItem.Name = "backgroundToolStripMenuItem";
            this.backgroundToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.backgroundToolStripMenuItem.Text = "Background";
            this.backgroundToolStripMenuItem.Click += new System.EventHandler(this.backgroundToolStripMenuItem_Click);
            // 
            // foregroundToolStripMenuItem
            // 
            this.foregroundToolStripMenuItem.Name = "foregroundToolStripMenuItem";
            this.foregroundToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.foregroundToolStripMenuItem.Text = "Foreground";
            this.foregroundToolStripMenuItem.Click += new System.EventHandler(this.foregroundToolStripMenuItem_Click);
            // 
            // MalinSpaceIPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 553);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.groupBoxEventHorizon);
            this.Controls.Add(this.groupBoxTemp);
            this.Controls.Add(this.groupBoxStarDistance);
            this.Controls.Add(this.groupBoxStarVelocity);
            this.Controls.Add(this.listViewCalculations);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MalinSpaceIPC";
            this.Text = "Malin Space IPC";
            this.groupBoxStarVelocity.ResumeLayout(false);
            this.groupBoxStarVelocity.PerformLayout();
            this.groupBoxStarDistance.ResumeLayout(false);
            this.groupBoxStarDistance.PerformLayout();
            this.groupBoxTemp.ResumeLayout(false);
            this.groupBoxTemp.PerformLayout();
            this.groupBoxEventHorizon.ResumeLayout(false);
            this.groupBoxEventHorizon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPower)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewCalculations;
        private System.Windows.Forms.GroupBox groupBoxStarVelocity;
        private System.Windows.Forms.TextBox textBoxRest;
        private System.Windows.Forms.Label labelRest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxObserve;
        private System.Windows.Forms.GroupBox groupBoxStarDistance;
        private System.Windows.Forms.Label labelArcAngle;
        private System.Windows.Forms.TextBox textBoxArc;
        private System.Windows.Forms.GroupBox groupBoxTemp;
        private System.Windows.Forms.Label labelCelcius;
        private System.Windows.Forms.TextBox textBoxCelcius;
        private System.Windows.Forms.GroupBox groupBoxEventHorizon;
        private System.Windows.Forms.NumericUpDown numericUpDownPower;
        private System.Windows.Forms.Label labelPower;
        private System.Windows.Forms.Label labelMass;
        private System.Windows.Forms.TextBox textBoxMass;
        private System.Windows.Forms.ColumnHeader StarVelocity;
        private System.Windows.Forms.ColumnHeader StarDistance;
        private System.Windows.Forms.ColumnHeader Temperature;
        private System.Windows.Forms.ColumnHeader EventHorizon;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foregroundToolStripMenuItem;
    }
}

