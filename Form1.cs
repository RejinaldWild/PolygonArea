using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PolygonArea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.WindowsDefaultLocation;
            textBoxX.ScrollBars = ScrollBars.Horizontal;
            textBoxY.ScrollBars = ScrollBars.Horizontal;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            try
            {                
                string[] arrX = textBoxX.Text.Split(',');
                string[] arrY = textBoxY.Text.Split(',');
                if (arrX.Length != arrY.Length)
                {
                    throw new Exception(labelAnswerInfo.Text = "Quantity of x and y has to be equal!");
                }
                int[] arrNumX = new int[arrX.Length];
                int[] arrNumY = new int[arrY.Length];
                for (int i = 0; i<arrNumX.Length;i++)
                {
                    arrNumX[i] = Convert.ToInt32(arrX[i]);
                    arrNumY[i] = Convert.ToInt32(arrY[i]);
                }
                int tempSquare1 = 0;
                int tempSquare2 = 0;
                for (int i = 0; i < arrNumX.Length - 1; i++)
                {
                    tempSquare1 += arrNumX[i] * arrNumY[i + 1];
                    tempSquare2 += arrNumY[i] * arrNumX[i + 1];
                }
                double Square = Math.Abs((double)((tempSquare1 - tempSquare2) / 2));
                labelAnswerInfo.Text = "Answer is " + Square.ToString() + " in units of measurement";
            }
            catch (FormatException)
            {
                labelAnswerInfo.Text = "Incorrect data, try to use \nonly numbers and commas";
            }
            catch (Exception ex)
            {
                labelAnswerInfo.Text = $"{ex.Message}";
            }
        }
    }
}
