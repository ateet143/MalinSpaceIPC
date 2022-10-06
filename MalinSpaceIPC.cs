using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.ServiceModel;
using System.Threading;
using System.Windows.Forms;
///Created by Atit Singh
///Date: 16/09/2022
///This is a Single Client windows Application that will connect to the server program using 
///Named pipes from the IPC.The client interface will provide the user with input text boxes for each astronomical calculation and 
///read only output text boxes for the returned values.User can able to change the language to German, France and English(UK)
///The user can able to change the theme as well as customise the background and foreground colours.

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
                            display[0] = result.ToString() + " m/s";
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
                            display[1] = result.ToString() + " parsec";
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
                            display[2] = result.ToString() + " K";
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
                            string result = String.Format(CultureInfo.InvariantCulture, "{0:0.#E+0}", eventHorizonResult);
                            display[3] = result + " metres";
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

        //Clearing all the textbox in the application
        private void allTextBoxClear()
        {
            textBoxObserve.Clear();
            textBoxRest.Clear();
            textBoxArc.Clear();
            textBoxMass.Clear();
            textBoxCelcius.Clear();
        }


        /// When the user choose the Day button under the Setting> Theme> Day Menu
        /// This code executes with the background colour of LightBlue and forecolor of MidnightBlue
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeTheme(Color.LightBlue, Color.MidnightBlue);
        }

        /// When the user choose the Day button under the Setting> Theme> Night Menu
        /// This code executes with the background colour of ARGB(255,46,46,46) and forecolor of white
        private void nightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeTheme(Color.FromArgb(46, 46, 46), Color.White);
        }



        /// ChangeTheme method to change the Background and Foreground coloru
        /// <param name="backColor">Represents the background colour for the application</param>
        /// <param name="foreColor">Represents the foreground colour for the application</param>
        public void ChangeTheme(Color backColor, Color foreColor)
        {
            this.BackColor = backColor;
            this.ForeColor = foreColor;

            //For changing the button color and style
            foreach (var button in Controls.OfType<Button>())
            {
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderColor = Color.SlateBlue;
                // this will darken the given backcolor, to help visible in the form
                button.BackColor = ControlPaint.Dark(backColor, 50.0f);
                button.ForeColor = foreColor;
            }

            foreach (var group in Controls.OfType<GroupBox>())
            {
                group.ForeColor = foreColor;
                group.BackColor = backColor;
            }

            foreach (var menu in Controls.OfType<MenuStrip>())
            {
                menu.BackColor = backColor;
                menu.ForeColor = foreColor;
            }

            foreach (var listView in Controls.OfType<ListView>())
            {
                listView.BackColor = ControlPaint.Light(backColor, 50.0f);
            }
        }


        /// Execute the code when user chooses Settings > Colour > Background menu
        /// It will open the colour dialog box and call the changeTheme method to change the background colour
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {

                ChangeTheme(colorDlg.Color, this.ForeColor);
            }
        }

        /// Execute the code when user chooses Settings > Colour > Foreground menu
        /// It will open the colour dialog box and call the changeTheme method to change the foreground colour
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void foregroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                ChangeTheme(this.BackColor, colorDlg.Color);
            }
        }

        
        /// When the user chooses Setting > Language > English
        /// ChangeLanguage method executes with English input.The language of the form is expected to changed to English(UK)
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void eNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLanguage("English");
        }

        /// When the user chooses Setting > Language > French
        /// ChangeLanguage method executes with French input.The language of the form is expected to changed to French
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fRENCHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLanguage("French");
        }

        /// When the user chooses Setting > Language > German
        /// ChangeLanguage method executes with German input.The language of the form is expected to changed to German
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gERMANToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLanguage("German");
        }

        /// Method to change the UICulture of the form
        /// The code help to change the language to English(UK), French and German 
        /// <param name="language">Represents the language to be changed</param>
        private void ChangeLanguage(string language)
        {
            this.BackColor = DefaultBackColor;
            this.ForeColor = DefaultForeColor;
            
            switch (language)
            {
                case "English":
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-GB");

                    break;
                case "French":
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("fr-FR");
                    break;
                case "German":
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("de-DE");
                
                    break;
            }
            //Clear the previous Controls object configuration
            Controls.Clear();
            
            //re-Initialize every component according the language choosen.
            InitializeComponent();
        }

      
    }
}
