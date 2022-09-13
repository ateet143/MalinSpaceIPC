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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MalinSpaceIPC));
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
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eNGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fRENCHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gERMANToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxCountryFlag = new System.Windows.Forms.PictureBox();
            this.groupBoxStarVelocity.SuspendLayout();
            this.groupBoxStarDistance.SuspendLayout();
            this.groupBoxTemp.SuspendLayout();
            this.groupBoxEventHorizon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPower)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCountryFlag)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewCalculations
            // 
            resources.ApplyResources(this.listViewCalculations, "listViewCalculations");
            this.listViewCalculations.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.StarVelocity,
            this.StarDistance,
            this.Temperature,
            this.EventHorizon});
            this.listViewCalculations.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listViewCalculations.HideSelection = false;
            this.listViewCalculations.Name = "listViewCalculations";
            this.listViewCalculations.UseCompatibleStateImageBehavior = false;
            this.listViewCalculations.View = System.Windows.Forms.View.Details;
            // 
            // StarVelocity
            // 
            resources.ApplyResources(this.StarVelocity, "StarVelocity");
            // 
            // StarDistance
            // 
            resources.ApplyResources(this.StarDistance, "StarDistance");
            // 
            // Temperature
            // 
            resources.ApplyResources(this.Temperature, "Temperature");
            // 
            // EventHorizon
            // 
            resources.ApplyResources(this.EventHorizon, "EventHorizon");
            // 
            // groupBoxStarVelocity
            // 
            resources.ApplyResources(this.groupBoxStarVelocity, "groupBoxStarVelocity");
            this.groupBoxStarVelocity.Controls.Add(this.textBoxRest);
            this.groupBoxStarVelocity.Controls.Add(this.labelRest);
            this.groupBoxStarVelocity.Controls.Add(this.label1);
            this.groupBoxStarVelocity.Controls.Add(this.textBoxObserve);
            this.groupBoxStarVelocity.Name = "groupBoxStarVelocity";
            this.groupBoxStarVelocity.TabStop = false;
            // 
            // textBoxRest
            // 
            resources.ApplyResources(this.textBoxRest, "textBoxRest");
            this.textBoxRest.Name = "textBoxRest";
            this.textBoxRest.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRest_KeyPress);
            // 
            // labelRest
            // 
            resources.ApplyResources(this.labelRest, "labelRest");
            this.labelRest.Name = "labelRest";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // textBoxObserve
            // 
            resources.ApplyResources(this.textBoxObserve, "textBoxObserve");
            this.textBoxObserve.Name = "textBoxObserve";
            this.textBoxObserve.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxObserve_KeyPress);
            // 
            // groupBoxStarDistance
            // 
            resources.ApplyResources(this.groupBoxStarDistance, "groupBoxStarDistance");
            this.groupBoxStarDistance.Controls.Add(this.labelArcAngle);
            this.groupBoxStarDistance.Controls.Add(this.textBoxArc);
            this.groupBoxStarDistance.Name = "groupBoxStarDistance";
            this.groupBoxStarDistance.TabStop = false;
            // 
            // labelArcAngle
            // 
            resources.ApplyResources(this.labelArcAngle, "labelArcAngle");
            this.labelArcAngle.Name = "labelArcAngle";
            // 
            // textBoxArc
            // 
            resources.ApplyResources(this.textBoxArc, "textBoxArc");
            this.textBoxArc.Name = "textBoxArc";
            this.textBoxArc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxArc_KeyPress);
            // 
            // groupBoxTemp
            // 
            resources.ApplyResources(this.groupBoxTemp, "groupBoxTemp");
            this.groupBoxTemp.Controls.Add(this.labelCelcius);
            this.groupBoxTemp.Controls.Add(this.textBoxCelcius);
            this.groupBoxTemp.Name = "groupBoxTemp";
            this.groupBoxTemp.TabStop = false;
            // 
            // labelCelcius
            // 
            resources.ApplyResources(this.labelCelcius, "labelCelcius");
            this.labelCelcius.Name = "labelCelcius";
            // 
            // textBoxCelcius
            // 
            resources.ApplyResources(this.textBoxCelcius, "textBoxCelcius");
            this.textBoxCelcius.Name = "textBoxCelcius";
            this.textBoxCelcius.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCelcius_KeyPress);
            // 
            // groupBoxEventHorizon
            // 
            resources.ApplyResources(this.groupBoxEventHorizon, "groupBoxEventHorizon");
            this.groupBoxEventHorizon.Controls.Add(this.numericUpDownPower);
            this.groupBoxEventHorizon.Controls.Add(this.labelPower);
            this.groupBoxEventHorizon.Controls.Add(this.labelMass);
            this.groupBoxEventHorizon.Controls.Add(this.textBoxMass);
            this.groupBoxEventHorizon.Name = "groupBoxEventHorizon";
            this.groupBoxEventHorizon.TabStop = false;
            // 
            // numericUpDownPower
            // 
            resources.ApplyResources(this.numericUpDownPower, "numericUpDownPower");
            this.numericUpDownPower.Name = "numericUpDownPower";
            // 
            // labelPower
            // 
            resources.ApplyResources(this.labelPower, "labelPower");
            this.labelPower.Name = "labelPower";
            // 
            // labelMass
            // 
            resources.ApplyResources(this.labelMass, "labelMass");
            this.labelMass.Name = "labelMass";
            // 
            // textBoxMass
            // 
            resources.ApplyResources(this.textBoxMass, "textBoxMass");
            this.textBoxMass.Name = "textBoxMass";
            this.textBoxMass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMass_KeyPress);
            // 
            // buttonCalculate
            // 
            resources.ApplyResources(this.buttonCalculate, "buttonCalculate");
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.UseMnemonic = false;
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themeToolStripMenuItem,
            this.colourToolStripMenuItem,
            this.languageToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            // 
            // themeToolStripMenuItem
            // 
            resources.ApplyResources(this.themeToolStripMenuItem, "themeToolStripMenuItem");
            this.themeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dayToolStripMenuItem,
            this.nightToolStripMenuItem});
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            // 
            // dayToolStripMenuItem
            // 
            resources.ApplyResources(this.dayToolStripMenuItem, "dayToolStripMenuItem");
            this.dayToolStripMenuItem.Name = "dayToolStripMenuItem";
            this.dayToolStripMenuItem.Click += new System.EventHandler(this.dayToolStripMenuItem_Click);
            // 
            // nightToolStripMenuItem
            // 
            resources.ApplyResources(this.nightToolStripMenuItem, "nightToolStripMenuItem");
            this.nightToolStripMenuItem.Name = "nightToolStripMenuItem";
            this.nightToolStripMenuItem.Click += new System.EventHandler(this.nightToolStripMenuItem_Click);
            // 
            // colourToolStripMenuItem
            // 
            resources.ApplyResources(this.colourToolStripMenuItem, "colourToolStripMenuItem");
            this.colourToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backgroundToolStripMenuItem,
            this.foregroundToolStripMenuItem});
            this.colourToolStripMenuItem.Name = "colourToolStripMenuItem";
            // 
            // backgroundToolStripMenuItem
            // 
            resources.ApplyResources(this.backgroundToolStripMenuItem, "backgroundToolStripMenuItem");
            this.backgroundToolStripMenuItem.Name = "backgroundToolStripMenuItem";
            this.backgroundToolStripMenuItem.Click += new System.EventHandler(this.backgroundToolStripMenuItem_Click);
            // 
            // foregroundToolStripMenuItem
            // 
            resources.ApplyResources(this.foregroundToolStripMenuItem, "foregroundToolStripMenuItem");
            this.foregroundToolStripMenuItem.Name = "foregroundToolStripMenuItem";
            this.foregroundToolStripMenuItem.Click += new System.EventHandler(this.foregroundToolStripMenuItem_Click);
            // 
            // languageToolStripMenuItem
            // 
            resources.ApplyResources(this.languageToolStripMenuItem, "languageToolStripMenuItem");
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eNGToolStripMenuItem,
            this.fRENCHToolStripMenuItem,
            this.gERMANToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            // 
            // eNGToolStripMenuItem
            // 
            resources.ApplyResources(this.eNGToolStripMenuItem, "eNGToolStripMenuItem");
            this.eNGToolStripMenuItem.Name = "eNGToolStripMenuItem";
            this.eNGToolStripMenuItem.Click += new System.EventHandler(this.eNGToolStripMenuItem_Click);
            // 
            // fRENCHToolStripMenuItem
            // 
            resources.ApplyResources(this.fRENCHToolStripMenuItem, "fRENCHToolStripMenuItem");
            this.fRENCHToolStripMenuItem.Name = "fRENCHToolStripMenuItem";
            this.fRENCHToolStripMenuItem.Click += new System.EventHandler(this.fRENCHToolStripMenuItem_Click);
            // 
            // gERMANToolStripMenuItem
            // 
            resources.ApplyResources(this.gERMANToolStripMenuItem, "gERMANToolStripMenuItem");
            this.gERMANToolStripMenuItem.Name = "gERMANToolStripMenuItem";
            this.gERMANToolStripMenuItem.Click += new System.EventHandler(this.gERMANToolStripMenuItem_Click);
            // 
            // pictureBoxCountryFlag
            // 
            resources.ApplyResources(this.pictureBoxCountryFlag, "pictureBoxCountryFlag");
            this.pictureBoxCountryFlag.Name = "pictureBoxCountryFlag";
            this.pictureBoxCountryFlag.TabStop = false;
            // 
            // MalinSpaceIPC
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBoxCountryFlag);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.groupBoxEventHorizon);
            this.Controls.Add(this.groupBoxTemp);
            this.Controls.Add(this.groupBoxStarDistance);
            this.Controls.Add(this.groupBoxStarVelocity);
            this.Controls.Add(this.listViewCalculations);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MalinSpaceIPC";
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCountryFlag)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eNGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fRENCHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gERMANToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBoxCountryFlag;
    }
}

