using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TimeFrequencyConversionApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double input = Convert.ToDouble(inputbox.Text.ToString());
            string selectedValue = conversionbox.SelectedItem.ToString();
            string timeUnit = "";
            string HzUnit = "";
            if (selectedValue == "Time to Frequency")
            {
                timeUnit = "seconds";
                double Hertz = Math.Pow(10, 0);
                double KiloHertz = Math.Pow(10, 3);
                double MegaHertz = Math.Pow(10, 6);
                double GigaHertz = Math.Pow(10, 9);

                HzUnit = "Hz";
                double frequency = input > 0 ? 1.0 / input : 0.0;

                if (frequency >= GigaHertz)
                {
                    frequency /= GigaHertz;
                    HzUnit = "GHz";
                }
                else if (frequency >= MegaHertz)
                {
                    frequency /= MegaHertz;
                    HzUnit = "MHz";
                }
                else if (frequency >= KiloHertz)
                {
                    frequency /= KiloHertz;
                    HzUnit = "kHz";
                }
                unit1.Text = timeUnit;
                convert.Text = frequency.ToString();
                unit2.Text = HzUnit;
            }
            else if (selectedValue == "Frequency to Time")
            {
                HzUnit = "Hz";
                double seconds = 1.0 / input;

                if (seconds >= 1)
                {
                    timeUnit = "seconds";
                }
                else if (seconds >= Math.Pow(10, -3))
                {
                    seconds *= Math.Pow(10, 3);
                    timeUnit = "milliseconds";
                }
                else if (seconds >= Math.Pow(10, -6))
                {
                    seconds *= Math.Pow(10, 6);
                    timeUnit = "microseconds";
                }
                else
                {
                    seconds *= Math.Pow(10, 9);
                    timeUnit = "nanoseconds";
                }
                unit1.Text = HzUnit;
                convert.Text = seconds.ToString();
                unit2.Text = timeUnit;
            }
        }
    }
}
