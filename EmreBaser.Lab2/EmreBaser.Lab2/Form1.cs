using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EmreBaser.Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            massRadio.CheckedChanged += new EventHandler(massRadio_CheckedChanged);
            areaRadio.CheckedChanged += new EventHandler(areaRadio_CheckedChanged);
            distanceRadio.CheckedChanged += new EventHandler(distanceRadio_CheckedChanged);
            inputText.TextChanged += new EventHandler(updateResults);
            resetButton.Click += new EventHandler(resetButton_Click);
            exitButton.Click += new EventHandler(exitButton_Click);
            roundUpButton.Click += new EventHandler(roundUpButton_Click);
            roundDownButton.Click += new EventHandler(roundDownButton_Click);
            userManualButton.Click += new EventHandler(userManualButton_Click);
            distanceRadio.Checked = false;
            massRadio.Checked = false;
            areaRadio.Checked = false;
            this.inputText = new System.Windows.Forms.TextBox();
        }
        private void updateResults(object sender, EventArgs e)
        {
            //My Update Results function Prints computed calculation at outputTextbox

            if (double.TryParse(inputText.Text, out double value))
            {
                double result = calculateConversion(value);
                outputTextbox.Text = result.ToString("F3");
            }
            else 
            {
                outputTextbox.Text = "Invalid input";
            }
        }

        private double calculateConversion(double value)
        {
            //CalculateConversion Function computes calculation
            double result;

            string unitFrom = fromComboBox.SelectedItem.ToString();
            string unitTo = toComboBox.SelectedItem.ToString();

            //Conversion Rates Used for distance.
            double yardtoMeter = 0.914;
            double yardtoKm = 0.0009144;
            double yardtoMile = 0.000568182;
            double metertoKm = 0.001;
            double metertoMile = 0.000621371;
            double kmtoMile = 1.6;

            //Conversion rates used for Mass.
            double gramtoOunce = 0.03527396;
            double gramtoPound = 0.00220462;
            double gramtoKg = metertoKm;
            double ouncetoPound = 0.0625;
            double ouncetoKg = 0.02834952;
            double poundtoKg = 0.45359237;

            //Conversion Rates used for the Area.
            double fttoMeter = 0.0092903;
            double fttoAc = 0.00002295;
            double metertoArc = 0.000247;

                //
                //Distance Logic
         if (unitFrom == "Yard" && unitTo == "Meter")
                    result = value * yardtoMeter;
                else if (unitFrom == "Yard" && unitTo == "Kilometer")
                    result = value * yardtoKm;
                else if (unitFrom == "Yard" && unitTo == "Mile")
                    result = value * yardtoMile;

                else if (unitFrom == "Meter" && unitTo == "Yard")
                    result = value / yardtoMeter;
                else if (unitFrom == "Meter" && unitTo == "Kilometer")
                    result = value * metertoKm;
                else if (unitFrom == "Meter" && unitTo == "Mile")
                    result = value * metertoMile;

                else if (unitFrom == "Kilometer" && unitTo == "Mile")
                    result = (value/kmtoMile);
                else if (unitFrom == "Kilometer" && unitTo == "Meter")
                    result = (value / metertoKm);
                else if (unitFrom == "Kilometer" && unitTo == "Yard")
                    result = value / yardtoKm;

                else if (unitFrom == "Mile" && unitTo == "Yard")
                    result = value / yardtoMile;
                else if (unitFrom == "Mile" && unitTo == "Meter")
                    result = value / metertoMile;
                else if (unitFrom == "Mile" && unitTo == "Kilometer")
                    result = value * kmtoMile;
                //
                //  Mass Logic
                else if (unitFrom == "Gram" && unitTo == "Ounce")
                    result = value * gramtoOunce;
                else if (unitFrom == "Gram" && unitTo == "Pound")
                    result = value * gramtoPound;
                else if (unitFrom == "Gram" && unitTo == "Kilogram")
                    result = value * gramtoKg;

                else if (unitFrom == "Ounce" && unitTo == "Gram")
                    result = value / gramtoOunce;
                else if (unitFrom == "Ounce" && unitTo == "Pound")
                    result = value * ouncetoPound;
                else if (unitFrom == "Gram" && unitTo == "Kilogram")
                    result = value * ouncetoKg;

                else if (unitFrom == "Pound" && unitTo == "Kilogram")
                    result = value * poundtoKg;
                else if (unitFrom == "Pound" && unitTo == "Ounce")
                    result = value / ouncetoPound;
                else if (unitFrom == "Pound" && unitTo == "Gram")
                    result = value / gramtoPound;

                else if (unitFrom == "Kilogram" && unitTo == "Gram")
                    result = value / gramtoKg;
                else if (unitFrom == "Kilogram" && unitTo == "Pound")
                    result = value / poundtoKg;
                else if (unitFrom == "Kilogram" && unitTo == "Ounce")
                    result = value / ouncetoKg;
                //
                // Area Logic
                else if (unitFrom == "Square Feet" && unitTo == "Square Meters")
                    result = value * fttoMeter;
                else if (unitFrom == "Square Feet" && unitTo == "Acres")
                    result = value * fttoAc;

                else if (unitFrom == "Square Meters" && unitTo == "Square Feet")
                    result = value / fttoMeter;
                else if (unitFrom == "Square Meters" && unitTo == "Acres")
                    result = value * metertoArc;

                else if (unitFrom == "Acres" && unitTo == "Square Meters")
                    result = value / metertoArc;
                else if (unitFrom == "Acres" && unitTo == "Feet Square")
                    result = value / fttoAc;

         else
         result = value;
           
         return result;
         }


        private void distanceRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (distanceRadio.Checked)
            {
                // Update combo box items for distance units
                outputTextbox.Clear();
                inputText.Clear();
                fromComboBox.Items.Clear();
                fromComboBox.Items.AddRange(new string[] { "Yard", "Meter", "Kilometers", "Mile" });
                toComboBox.Items.Clear(); 
                toComboBox.Items.AddRange(new string[] { "Yard", "Meter", "Kilometer", "Mile"});

            }
        }

        private void massRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (massRadio.Checked)
            {
                // Update combo box items for mass units
                outputTextbox.Clear();
                inputText.Clear();
                fromComboBox.Items.Clear();
                fromComboBox.Items.AddRange(new string[] { "Gram", "Ounce", "Pound", "Kilogram"});
                toComboBox.Items.Clear();
                toComboBox.Items.AddRange(new string[] { "Gram", "Ounce", "Pound", "Kilogram" });

            }
        }

        private void areaRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (areaRadio.Checked)
            {
                // Update combo box items for area units
                outputTextbox.Clear();
                inputText.Clear();
                fromComboBox.Items.Clear();
                fromComboBox.Items.AddRange(new string[] { "Square Feet", "Square Meters", "Acres" });
                toComboBox.Items.Clear();
                toComboBox.Items.AddRange(new string[] { "Square Feet", "Square Meters", "Acres" });

            }
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Program will now terminate");
            Application.Exit();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            inputText.Clear();
            outputTextbox.Clear();
            fromComboBox.Items.Clear();
            toComboBox.Items.Clear();
            distanceRadio.Checked = false;
            massRadio.Checked = false;
            areaRadio.Checked = false;
        }

        private void roundUpButton_Click(object sender, EventArgs e)
        {
            if (double.TryParse(outputTextbox.Text, out double result))
            {
                int roundedValue = (int)Math.Ceiling(result);
                outputTextbox.Text = roundedValue.ToString();
            }
        }
        private void roundDownButton_Click(object sender, EventArgs e)
        {
            if (double.TryParse(outputTextbox.Text, out double result))
            {
                int roundedValue = (int)Math.Floor(result);
                outputTextbox.Text = roundedValue.ToString();
            }
        }

        private void userManualButton_Click(object sender, EventArgs e)
        {
            string userManualMessage =
        "Hello, welcome to the unit converter,\n" +
        "User manual:\n" +
        "       1) Select Units\n" +
        "       2) Select From and To MEASURES to identify the conversion\n" +
        "       3) Use Round Up or Round Down buttons if necessary\n" +
        "Note: Convert Textbox will only function if numbers are entered,"+
        "If Reset button is pressed, User must select units again"
        ;

            MessageBox.Show(userManualMessage, "User Manual", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void inputText_TextChanged(object sender, EventArgs e)
        {
            string banText = inputText.Text;
            banText = new string(banText.Where(c => Char.IsDigit(c) || c == '-' || c == '.').ToArray());
            inputText.Text = banText;
        }
    }
    }

