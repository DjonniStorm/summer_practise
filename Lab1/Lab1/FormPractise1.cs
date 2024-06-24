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

        Random random = new();

        public FormPractise1()
        {
            InitializeComponent();
        }

        private void buttonTask1_Click(object sender, EventArgs e)
        {

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

        private void buttonOneD_Click(object sender, EventArgs e)
        {
            _sizeRows = (int) numericUpDownNumberOfRows.Value;
            _sizeColumns = (int)numericUpDownNumberOfColumns.Value;
            _rangeFrom = (int)numericUpDownFrom.Value;
            _rangeTo = (int)numericUpDownTo.Value;
            
            int[] array = new int[_sizeColumns];
            string buffer = "";

            for (int i = 0; i < _sizeColumns; i++)
            {
                int? newElem = random.Next(Math.Min(_rangeFrom, _rangeTo + 1), Math.Max(_rangeFrom, _rangeTo + 1));
                array[i] = newElem ?? random.Next();
                buffer += $"{array[i]}  ";
            }
            textBoxArray.Text = buffer;

        }

        private void buttonTwoD_Click(object sender, EventArgs e)
        {
            _sizeRows = (int)numericUpDownNumberOfRows.Value;
            _sizeColumns = (int)numericUpDownNumberOfColumns.Value;
            _rangeFrom = (int)numericUpDownFrom.Value;
            _rangeTo = (int)numericUpDownTo.Value;

            int[,] array = new int[_sizeRows, _sizeColumns];
            string buffer = "";

            int rangeFrom = Math.Min(_rangeFrom, _rangeTo);
            int rangeTo = Math.Max(_rangeFrom, _rangeTo);

            for (int i = 0; i < _sizeRows; i++)
            {
                for (int j = 0; j < _sizeColumns; j++)
                {
                    array[i, j] = random.Next(rangeFrom, rangeTo + 1);
                    buffer += $"{array[i, j].ToString().PadLeft(5).PadRight(5)}  ";
                }
                buffer += Environment.NewLine;
            }
            textBoxArray.Text = buffer;
        }
    }
}
