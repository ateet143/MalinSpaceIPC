using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
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

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            listViewCalculations.Items.Clear(); 
            string[] test = new string[4];
           
            using (ChannelFactory<IAstroContract> pipeFactory = new ChannelFactory<IAstroContract>(
                    new NetNamedPipeBinding(),
                      new EndpointAddress("net.pipe://localhost/PipeReverse"))
)
            {
                IAstroContract pipeProxy = pipeFactory.CreateChannel();

                if (!string.IsNullOrEmpty(textBoxObserve.Text) && !string.IsNullOrEmpty(textBoxRest.Text))
                {
                    double ob = Double.Parse(textBoxObserve.Text);
                    double rt = Double.Parse(textBoxRest.Text);
                    double result = pipeProxy.starVelocity(ob, rt);

                    MessageBox.Show("star Velocity" + result.ToString());
                    test[0] = result.ToString();
                    
                    
                }

                if (!string.IsNullOrEmpty(textBoxArc.Text))
                {
                    double arc = Double.Parse(textBoxArc.Text);
                    double result = pipeProxy.starDistance(arc);

                    MessageBox.Show("star Distance" + result.ToString());
                    test[1] = result.ToString();
                }


                if (!string.IsNullOrEmpty(textBoxCelcius.Text))
                {
                    double temp = Double.Parse(textBoxCelcius.Text);
                    double result = pipeProxy.celciusToKelvin(temp);

                    MessageBox.Show("temp in K " + result.ToString());
                    test[2] = result.ToString();

                }

                if (!string.IsNullOrEmpty(textBoxMass.Text))
                {
                    double mass = Double.Parse(textBoxMass.Text);
                    double result = pipeProxy.eventHorizon(mass * Math.Pow(10,(double)numericUpDownPower.Value));
                    MessageBox.Show("Event Horizon" + result.ToString("0.#E+0", CultureInfo.InvariantCulture));
                    test[3] = result.ToString();

                }
                ListViewItem itm = new ListViewItem(test);
                listViewCalculations.Items.Add(itm);


            }

        }

       
    }
}
