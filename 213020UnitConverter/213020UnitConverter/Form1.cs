using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _213020UnitConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeComboBoxes();
        }
        private void InitializeComboBoxes()
        {
            selectComboBox.Items.AddRange(new string[] { "Time", "Area", "Length", "Temperature" });
            fromComboBox.Items.AddRange(new string[] { "Hours", "Minutes", "Seconds", "SquareFoot", "SquareMeter", "SquareInch", "Foot", "Inches", "Meters", "Kilometer", "Centimeter", "Celsius", "Fahrenheit", "Kelvin" });
            toComboBox.Items.AddRange(new string[] { "Hours", "Minutes", "Seconds", "SquareFoot", "SquareMeter", "SquareInch", "Foot", "Inches", "Meters", "Kilometer", "Centimeter", "Celsius", "Fahrenheit", "Kelvin" });
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double inputValue))
            {
                string category = selectComboBox.SelectedItem.ToString();
                string sourceUnit = fromComboBox.SelectedItem.ToString();
                string targetUnit = toComboBox.SelectedItem.ToString();

                double result = ConvertUnits(inputValue, category, sourceUnit, targetUnit);

                resultLabel.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter a valid number to convert.");
            }

        }
        private double ConvertUnits(double inputValue, string category, string sourceUnit, string targetUnit)
        {
            double result = 0.0;

            switch (category)
            {
                case "Time":
                    result = ConvertTime(inputValue, sourceUnit, targetUnit);
                    break;
                case "Area":
                    result = ConvertArea(inputValue, sourceUnit, targetUnit);
                    break;
                case "Length":
                    result = ConvertLength(inputValue, sourceUnit, targetUnit);
                    break;
                case "Temperature":
                    result = ConvertTemperature(inputValue, sourceUnit, targetUnit);
                    break;
                default:
                    MessageBox.Show("Invalid category selected.");
                    break;
            }

            return result;
        }
        private double ConvertTime(double value, string fromUnit, string toUnit)
        {
            if (fromUnit == "Hours" && toUnit == "Minutes")
            {
                return value * 60;
            }
            else if (fromUnit == "Minutes" && toUnit == "Hours")
            {
                return value / 60;
            }
            else if (fromUnit == "Minutes" && toUnit == "Seconds")
            {
                return value * 60;
            }
            else if (fromUnit == "Seconds" && toUnit == "Minutes")
            {
                return value / 60;
            }
            else if (fromUnit == "Seconds" && toUnit == "Hours")
            {
                return value / 3600;
            }
            else if (fromUnit == "Hours" && toUnit == "Seconds")
            {
                return value * 3600;
            }
            return value;
        }

        private double ConvertArea(double value, string fromUnit, string toUnit)
        {
            if (fromUnit == "SquareFoot" && toUnit == "SquareMeter")
            {
                return value * 0.092903;
            }
            else if (fromUnit == "SquareFoot" && toUnit == "SquareInch")
            {
                return value * 144;
            }
            else if (fromUnit == "SquareFoot" && toUnit == "SquareMeter")
            {
                return value / 10.764;
            }
            else if (fromUnit == "SquareInch" && toUnit == "SquareFoot")
            {
                return value / 144;
            }
            else if (fromUnit == "SquareInch" && toUnit == "SquareMeter")
            {
                return value / 1550.003;
            }
            else if (fromUnit == "SquareMeter" && toUnit == "SquareInch")
            {
                return value * 1550.003;
            }
            else if (fromUnit == "SquareMeter" && toUnit == "SquareFoot")
            {
                return value * 10.764;
            }
            return value;
        }

        private double ConvertLength(double value, string fromUnit, string toUnit)
        {
            if (fromUnit == "Foot" && toUnit == "Inches")
            {
                return value * 12;
            }
            else if (fromUnit == "Inches" && toUnit == "Foot")
            {
                return value / 12;
            }
            else if (fromUnit == "Inches" && toUnit == "Meters")
            {
                return value * 0.0254;
            }
            else if (fromUnit == "Meters" && toUnit == "Inches")
            {
                return value / 0.0254;
            }
            else if (fromUnit == "Foot" && toUnit == "Meters")
            {
                return value * 0.3048;
            }
            else if (fromUnit == "Meters" && toUnit == "Foot")
            {
                return value / 0.3048;
            }
            else if (fromUnit == "Kilometer" && toUnit == "Meters")
            {
                return value * 1000;
            }
            else if (fromUnit == "Kilometer" && toUnit == "Centimeter")
            {
                return value * 100000;
            }
            else if (fromUnit == "Meters" && toUnit == "Kilometer")
            {
                return value / 1000;
            }
            else if (fromUnit == "Meters" && toUnit == "Centimeter")
            {
                return value * 100;
            }
            else if (fromUnit == "Centimeter" && toUnit == "Meters")
            {
                return value / 100;
            }
            else if (fromUnit == "Centimeter" && toUnit == "Kilometer")
            {
                return value / 100000;
            }

            return value;
        }


        private double ConvertTemperature(double value, string fromUnit, string toUnit)
        {
            if (fromUnit == "Celsius" && toUnit == "Fahrenheit")
            {
                return (value * 9 / 5) + 32;
            }
            else if (fromUnit == "Celsius" && toUnit == "Kelvin")
            {
                return value + 273.15;
            }
            else if (fromUnit == "Fahrenheit" && toUnit == "Celsius")
            {
                return (value - 32) * 5 / 9;
            }
            else if (fromUnit == "Fahrenheit" && toUnit == "Kelvin")
            {
                return (value - 32) * 5 / 9 + 273.15;
            }
            else if (fromUnit == "Kelvin" && toUnit == "Celsius")
            {
                return value - 273.15;
            }
            else if (fromUnit == "Kelvin" && toUnit == "Fahrenheit")
            {
                return (value - 273.15) * 9 / 5 + 32;
            }
            return value;
        }
        private void selectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void fromComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
