using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MalinSpaceIPC
{
    public partial class MalinSpaceIPC : Form
    {
        public MalinSpaceIPC()
        {
            InitializeComponent();
        }
       
        /// When the user click the calculate button this block executes.
        /// Step1. Client is connected to the server by the address, if not connected then catch block executes.
        /// Step2. When there is input in any of the textbox then the corresponding calculation is done.
        /// <param name="sender">Sendere is the calucate button</param>
        /// <param name="e">a parameter called e that contains the event data</param>
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            //listViewCalculations.Items.Clear();
            string[] display = new string[4];
            try
            {
                using (ChannelFactory<IAstroContract> pipeFactory = new ChannelFactory<IAstroContract>(
                   new NetNamedPipeBinding(),
                     new EndpointAddress("net.pipe://localhost/PipeReverse"))
)
                {
                    IAstroContract pipeProxy = pipeFactory.CreateChannel();
                    

                    if (!string.IsNullOrEmpty(textBoxObserve.Text) && !string.IsNullOrEmpty(textBoxRest.Text))
                    {
                        try
                        {
                            double ob = Double.Parse(textBoxObserve.Text);
                            double rt = Double.Parse(textBoxRest.Text);
                            double result = pipeProxy.starVelocity(ob, rt);
                            display[0] = result.ToString();
                        }
                        //if connection is not connected then executes this block
                        catch (EndpointNotFoundException)
                        {
                            MessageBox.Show("Server Connection fault: Check the address/connection");
                        }
                    }

                    if (!string.IsNullOrEmpty(textBoxArc.Text))
                    {
                        try
                        {
                            double arc = Double.Parse(textBoxArc.Text);
                            double result = pipeProxy.starDistance(arc);
                            display[1] = result.ToString();
                        }
                        catch (EndpointNotFoundException)
                        {
                            MessageBox.Show("Server Connection fault: Check the address/connection");
                        }
                    }


                    if (!string.IsNullOrEmpty(textBoxCelcius.Text))
                    {
                        try
                        {
                            double temp = Double.Parse(textBoxCelcius.Text);
                            double result = pipeProxy.celciusToKelvin(temp);
                            display[2] = result.ToString();
                        }
                        catch (EndpointNotFoundException)
                        {
                            MessageBox.Show("Server Connection fault: Check the address/connection");
                        }
                    }

                    if (!string.IsNullOrEmpty(textBoxMass.Text))
                    {
                        try
                        {
                            double mass = Double.Parse(textBoxMass.Text);
                            double eventHorizonResult = pipeProxy.eventHorizon(mass * Math.Pow(10, (double)numericUpDownPower.Value));
                            string result = String.Format(CultureInfo.InvariantCulture,  "{0:0.#E+0}", eventHorizonResult);
                            display[3] = result;
                        }
                        catch (EndpointNotFoundException)
                        {
                            MessageBox.Show("Server Connection fault: Check the address/connection");
                        }

                    }
                    ListViewItem itm = new ListViewItem(display);
                    listViewCalculations.Items.Add(itm);
                    allTextBoxClear();
                }
            }
            catch (CommunicationObjectFaultedException)
            {
                return;
            }
        }

        private void textBoxObserve_KeyPress(object sender, KeyPressEventArgs e)
        {

            keyPressMethod((sender as TextBox), e);
        }

        private void textBoxRest_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyPressMethod((sender as TextBox), e);
        }

        private void textBoxArc_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyPressMethod((sender as TextBox), e);
        }

        private void textBoxCelcius_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyPressMethod((sender as TextBox), e);
        }

        private void textBoxMass_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyPressMethod((sender as TextBox), e);
        }

        /// Method to execute the keypress event
        /// it will prevent the user to type other than digit ,control, decimal and - (for negative number)
        /// Second block allow aonly one decimal.
        /// Third block allows only - once
        /// <param name="textBoxPress">it is for the TextBox object</param>
        /// <param name="e">e contains event data which is char pressed by the user</param>
        private void keyPressMethod(TextBox textBoxPress, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.' && textBoxPress.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }

            //only allow - once 
            if (e.KeyChar == '-' && textBoxPress.Text.Length > 0)
            {
                e.Handled = true;
            }
        }


        private void allTextBoxClear()
        {
            textBoxObserve.Clear();
            textBoxRest.Clear();
            textBoxArc.Clear();
            textBoxMass.Clear();
            textBoxCelcius.Clear();
        }


        private void dayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeTheme(Color.LightBlue, Color.MidnightBlue);
        }

        private void nightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeTheme(Color.FromArgb(46,46,46), Color.White);
        }

        public void ChangeTheme(Color backColor, Color foreColor)
        {
            this.BackColor = backColor;
            this.ForeColor = foreColor;
            
            foreach (var button in Controls.OfType<Button>())
            {
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderColor = Color.SlateBlue;
                button.BackColor = ControlPaint.Dark(backColor, 50.0f);
                button.ForeColor = foreColor;
            }

            foreach (var group in Controls.OfType<GroupBox>())
            {
                group.ForeColor = foreColor;
                group.BackColor = backColor;
            }

            foreach(var menu in Controls.OfType<MenuStrip>())
            {
                menu.BackColor = backColor;
                menu.ForeColor = foreColor;
            }

            foreach (var listView in Controls.OfType<ListView>())
            {
                listView.ForeColor = foreColor;
                listView.Columns[0].ListView.ForeColor = foreColor;
                //listViewCalculations.Columns[0].Text
            }
        }

        private void backgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
              
                ChangeTheme(colorDlg.Color, this.ForeColor);
            }
        }

        private void foregroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                ChangeTheme(this.BackColor, colorDlg.Color);
            }
        }

      
    }
}
