using System;
using System.Windows.Forms;

namespace ConstructsPractical01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            tbxDay.Text = dateTimePicker1.Value.Day.ToString();
            tbxMonth.Text = dateTimePicker1.Value.Month.ToString();
            tbxYear.Text = dateTimePicker1.Value.Year.ToString();

            int day = dateTimePicker1.Value.Day;
            int month = dateTimePicker1.Value.Month;
            int year = dateTimePicker1.Value.Year;

            lstOutput.Items.Clear();

            // Take the Day of your Birth
            // Multiply it by 20 
            long result = day * 20;
            lstOutput.Items.Add(day + " x 20 = " + (int)result);

            // Add 3 
            long result1 = result + 3;
            lstOutput.Items.Add(result + " + 3 = " + (int)result1);
            // Multiply by 5
            long result2 = result1 * 5;
            lstOutput.Items.Add(result1 + " x 5 = " + (int)result2);

            // Add your Month of Birth
            long result3 = result2 + month;
            lstOutput.Items.Add(result2 + " + " + month + " = " + (int)result3);

            // Multiply by 20
            long result4 = result3 * 20;
            lstOutput.Items.Add(result3 + " x 20 = " + (int)result4);

            // Add 3
            long result5 = result4 + 3;
            lstOutput.Items.Add(result4 + " + 3 = " + (int)result5);

            // Multiply by 5
            long result6 = result5 * 5;
            lstOutput.Items.Add(result5 + " x 5 = " + (int)result6);

            // Add last two digits of your Year of Birth
            int shortyear = year % 100;
            long result7 = result6 + shortyear;
            lstOutput.Items.Add(result6 + " - " + shortyear + " = " + (int)result7);

            // Subtract 1515
            long result8 = result7 - 1515;
            lstOutput.Items.Add(result7 + " - 1515 = " + (int)result8);
        }
    }
}
