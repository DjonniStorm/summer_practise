using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class FormPractise1 : Form
    {
        private int _sizeRows = -1;
        private int _sizeColumns = -1;

        private int _rangeFrom = -1;
        private int _rangeTo = -1;

        int[] array1d;
        int[,] array2d;

        Random random = new();

        public FormPractise1()
        {
            InitializeComponent();
        }

        private void buttonTask1_Click(object sender, EventArgs e)
        {
            Array1dFromKeyboard();
        }
        private void buttonTask2_Click(object sender, EventArgs e) => ButtonsTasks(2);
        private void buttonTask3_Click(object sender, EventArgs e) => ButtonsTasks(3);
        private void buttonTask4_Click(object sender, EventArgs e) => ButtonsTasks(4);
        private void buttonTask5_Click(object sender, EventArgs e) => ButtonsTasks(5);
        private void buttonTask6_Click(object sender, EventArgs e) => ButtonsTasks(6);

        private void ButtonsTasks(int task)
        {
            //if (_sizeRows)
            //switch (task)
            //{
            //    case 1:

            //        break;
            //    case 2:

            //        break;
            //    case 3:

            //        break;
            //    case 4:

            //        break;
            //    case 5:

            //        break;
            //    case 6:

            //        break;
            //}
        }

        private void Array1dFromKeyboard()
        {
            string textBoxText = textBoxArray.Text;
            string[] values = textBoxText.Split();
            
            int[] array = new int[values.Length];
            int counter = 0;
            for (int i = 0; i < array.Length && counter < array.Length; i++)
            {
                if (Int32.TryParse(values[i], out int result))
                {
                    array[counter] = result;
                    counter++;
                } 
                else
                {
                    continue;
                }
            }
            array1d = new int[counter];
            for (int i = 0; i < counter; i++)
            {
                array1d[i] = array[i];
            }
            string check = " ";
            foreach (int i in array1d)
            {
                check += $" {i} ";
            }
            textBoxResult.Text = check;
        }
        private int[,] Array2dFromKeyboard()
        {
            string[] textBoxText = textBoxArray.Lines;

            int m = textBoxText.Length;
            int n = textBoxText[0].Length;
            int[,] array = new int[textBoxText.Length, textBoxText[0].Length];
            int countRows = 0;
            int countCols = 0;
            for (int i = 0; i < m; i++)
            {
                string[] line = textBoxText[i].Split();
                for (int j = 0; j < n; j++)
                {
                    if (Int32.TryParse(line[j], out int result))
                    {
                        //доделать
                        countCols++;
                    }
                }
            }

            return array;

        }
        private void UpdateValues()
        {
            _sizeRows = (int)numericUpDownNumberOfRows.Value;
            _sizeColumns = (int)numericUpDownNumberOfColumns.Value;
            _rangeFrom = (int)numericUpDownFrom.Value;
            _rangeTo = (int)numericUpDownTo.Value;
        }
        private void buttonOneD_Click(object sender, EventArgs e)
        {
            UpdateValues();

            array1d = new int[_sizeColumns];
            int rangeFrom = Math.Min(_rangeFrom, _rangeTo);
            int rangeTo = Math.Max(_rangeFrom, _rangeTo);
            string buffer = "";

            for (int i = 0; i < _sizeColumns; i++)
            {
                array1d[i] = random.Next(rangeFrom, rangeTo + 1);
                buffer += $"{array1d[i].ToString().PadLeft(5).PadRight(5)}  ";
            }
            textBoxArray.Text = buffer;

        }

        private void buttonTwoD_Click(object sender, EventArgs e)
        {
            UpdateValues();

            array2d = new int[_sizeRows, _sizeColumns];
            string buffer = "";

            int rangeFrom = Math.Min(_rangeFrom, _rangeTo);
            int rangeTo = Math.Max(_rangeFrom, _rangeTo);

            for (int i = 0; i < _sizeRows; i++)
            {
                for (int j = 0; j < _sizeColumns; j++)
                {
                    array2d[i, j] = random.Next(rangeFrom, rangeTo + 1);
                    buffer += $"{array2d[i, j].ToString().PadLeft(5).PadRight(5)}  ";
                }
                buffer += Environment.NewLine;
            }
            textBoxArray.Text = buffer;
        }
    }
}
