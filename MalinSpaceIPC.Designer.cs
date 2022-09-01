﻿namespace MalinSpaceIPC
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBoxStarVelocity = new System.Windows.Forms.GroupBox();
            this.textBoxObserve = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelRest = new System.Windows.Forms.Label();
            this.textBoxRest = new System.Windows.Forms.TextBox();
            this.groupBoxStarDistance = new System.Windows.Forms.GroupBox();
            this.labelArcAngle = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBoxTemp = new System.Windows.Forms.GroupBox();
            this.labelCelcius = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBoxEventHorizon = new System.Windows.Forms.GroupBox();
            this.labelMass = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labelPower = new System.Windows.Forms.Label();
            this.numericUpDownPower = new System.Windows.Forms.NumericUpDown();
            this.StarVelocity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StarDistance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Temperature = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EventHorizon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.groupBoxStarVelocity.SuspendLayout();
            this.groupBoxStarDistance.SuspendLayout();
            this.groupBoxTemp.SuspendLayout();
            this.groupBoxEventHorizon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPower)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.StarVelocity,
            this.StarDistance,
            this.Temperature,
            this.EventHorizon});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(484, 95);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(715, 482);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // groupBoxStarVelocity
            // 
            this.groupBoxStarVelocity.Controls.Add(this.textBoxRest);
            this.groupBoxStarVelocity.Controls.Add(this.labelRest);
            this.groupBoxStarVelocity.Controls.Add(this.label1);
            this.groupBoxStarVelocity.Controls.Add(this.textBoxObserve);
            this.groupBoxStarVelocity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxStarVelocity.Location = new System.Drawing.Point(18, 20);
            this.groupBoxStarVelocity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxStarVelocity.Name = "groupBoxStarVelocity";
            this.groupBoxStarVelocity.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxStarVelocity.Size = new System.Drawing.Size(420, 138);
            this.groupBoxStarVelocity.TabIndex = 1;
            this.groupBoxStarVelocity.TabStop = false;
            this.groupBoxStarVelocity.Text = "Star Velocity";
            // 
            // textBoxObserve
            // 
            this.textBoxObserve.Location = new System.Drawing.Point(165, 32);
            this.textBoxObserve.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxObserve.Name = "textBoxObserve";
            this.textBoxObserve.Size = new System.Drawing.Size(148, 22);
            this.textBoxObserve.TabIndex = 2;
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
            // labelRest
            // 
            this.labelRest.AutoSize = true;
            this.labelRest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRest.Location = new System.Drawing.Point(15, 103);
            this.labelRest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRest.Name = "labelRest";
            this.labelRest.Size = new System.Drawing.Size(33, 13);
            this.labelRest.TabIndex = 3;
            this.labelRest.Text = "Rest";
            // 
            // textBoxRest
            // 
            this.textBoxRest.Location = new System.Drawing.Point(165, 97);
            this.textBoxRest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxRest.Name = "textBoxRest";
            this.textBoxRest.Size = new System.Drawing.Size(148, 22);
            this.textBoxRest.TabIndex = 4;
            // 
            // groupBoxStarDistance
            // 
            this.groupBoxStarDistance.Controls.Add(this.labelArcAngle);
            this.groupBoxStarDistance.Controls.Add(this.textBox2);
            this.groupBoxStarDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxStarDistance.Location = new System.Drawing.Point(18, 186);
            this.groupBoxStarDistance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxStarDistance.Name = "groupBoxStarDistance";
            this.groupBoxStarDistance.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(165, 32);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(148, 22);
            this.textBox2.TabIndex = 2;
            // 
            // groupBoxTemp
            // 
            this.groupBoxTemp.Controls.Add(this.labelCelcius);
            this.groupBoxTemp.Controls.Add(this.textBox1);
            this.groupBoxTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTemp.Location = new System.Drawing.Point(18, 284);
            this.groupBoxTemp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxTemp.Name = "groupBoxTemp";
            this.groupBoxTemp.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxTemp.Size = new System.Drawing.Size(420, 98);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(165, 32);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 22);
            this.textBox1.TabIndex = 2;
            // 
            // groupBoxEventHorizon
            // 
            this.groupBoxEventHorizon.Controls.Add(this.numericUpDownPower);
            this.groupBoxEventHorizon.Controls.Add(this.labelPower);
            this.groupBoxEventHorizon.Controls.Add(this.labelMass);
            this.groupBoxEventHorizon.Controls.Add(this.textBox3);
            this.groupBoxEventHorizon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxEventHorizon.Location = new System.Drawing.Point(18, 403);
            this.groupBoxEventHorizon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxEventHorizon.Name = "groupBoxEventHorizon";
            this.groupBoxEventHorizon.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxEventHorizon.Size = new System.Drawing.Size(420, 91);
            this.groupBoxEventHorizon.TabIndex = 7;
            this.groupBoxEventHorizon.TabStop = false;
            this.groupBoxEventHorizon.Text = "Event Horizon";
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
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(165, 36);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(133, 22);
            this.textBox3.TabIndex = 2;
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
            // numericUpDownPower
            // 
            this.numericUpDownPower.Location = new System.Drawing.Point(350, 36);
            this.numericUpDownPower.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDownPower.Name = "numericUpDownPower";
            this.numericUpDownPower.Size = new System.Drawing.Size(60, 22);
            this.numericUpDownPower.TabIndex = 8;
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
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(114, 528);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(179, 32);
            this.buttonCalculate.TabIndex = 8;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseMnemonic = false;
            this.buttonCalculate.UseVisualStyleBackColor = true;
            // 
            // MalinSpaceIPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 604);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.groupBoxEventHorizon);
            this.Controls.Add(this.groupBoxTemp);
            this.Controls.Add(this.groupBoxStarDistance);
            this.Controls.Add(this.groupBoxStarVelocity);
            this.Controls.Add(this.listView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox groupBoxStarVelocity;
        private System.Windows.Forms.TextBox textBoxRest;
        private System.Windows.Forms.Label labelRest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxObserve;
        private System.Windows.Forms.GroupBox groupBoxStarDistance;
        private System.Windows.Forms.Label labelArcAngle;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBoxTemp;
        private System.Windows.Forms.Label labelCelcius;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBoxEventHorizon;
        private System.Windows.Forms.NumericUpDown numericUpDownPower;
        private System.Windows.Forms.Label labelPower;
        private System.Windows.Forms.Label labelMass;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ColumnHeader StarVelocity;
        private System.Windows.Forms.ColumnHeader StarDistance;
        private System.Windows.Forms.ColumnHeader Temperature;
        private System.Windows.Forms.ColumnHeader EventHorizon;
        private System.Windows.Forms.Button buttonCalculate;
    }
}

