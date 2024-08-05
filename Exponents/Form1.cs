using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/**************************************
 * Name:
 * Date:
 * Description: A program using user-created method
 *              for the math function Square and Cube
 * Assistance:
 *************************************/

namespace Exponents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void xGoButton_Click(object sender, EventArgs e)
        {
            // STORAGE
            int inputNumber;

            // INPUT
            if (int.TryParse(UxInputTextBox.Text, out inputNumber))


            // PROCESS
            /* calculate the square of the number and add it to the output - 
             * do this with a method call that allows you to pass the number
             * and then receive the answer */
            {
                int squaredValue = Square(inputNumber);
                int cubedValue = Cube(inputNumber);


                UxOutputLabel.Text = $"Square: {squaredValue}\nCube: {cubedValue}";
                UxOutputLabel.Visible = true;

                UxGoButton.Enabled = false;
            }


            /* calculate the cube of the number and add it to the output - 
             * do this by creating a methd as in the squaring example above */

            // OUTPUT
            // set the output to visible


            // turn the Go button off

            else
            {
                MessageBox.Show("Please enter a valid integer.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public int Square(int num)
        {
            // we will create this code in class
            return num * num;
        }

        public int Cube(int num)
        {
            // we will create this code in class
            return num * num * num;
        }

        private void xResetButton_Click(object sender, EventArgs e)
        {
            // the input and output text should be emptied
            UxInputTextBox.Clear();
            UxOutputLabel.Text = "";

            // turn the output to invisible
            UxOutputLabel.Visible = false;

            // turn the Go button back on
            UxGoButton.Enabled = true;
        }

        private void xInputTextBox_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
