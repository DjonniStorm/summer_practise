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
            if (_sizeColumns <= 1 || array1d == default(int[]))
            {
                MessageBox.Show("Некорректные данные");
                return;
            }
            int[] freq = new int[10];
            for (int i = 0; i < _sizeColumns; i++)
            {
                string line = array1d[i].ToString();
                foreach (var character in line)
                {
                    if (char.IsDigit(character))
                        freq[(int)char.GetNumericValue(character)]++;
                }
            }
            string buffer = " ";
            foreach (int i in freq)
                buffer += $"  {i}  ";
            textBoxResult.Text = buffer;
        }
        private void buttonTask2_Click(object sender, EventArgs e) => ButtonsTasks(2);
        private void buttonTask3_Click(object sender, EventArgs e)
        {
            int counter = 0;
            for (int i = 0; i < _sizeColumns - 1; i++)
            {
                if (array1d[i] % 2 == 0)
                {
                    if (array1d[i + 1] % 2 == 0)
                    {
                        counter++;
                        continue;
                    }
                    if (counter >= 1)
                    {
                        int startPoint = i - counter;
                        for (int j = _sizeColumns - 1; j > startPoint + counter; j--) //тут можно до startPoint + counter + 1, там типо
                                                                                      //цепляет последний элемент серии, но он всё равно потом затирается
                        {
                            array1d[j] = array1d[j - 1];
                        }
                        int temp = array1d[startPoint];
                        array1d[startPoint + counter + 1] = temp;
                        i++;
                        counter = 0;
                    }
                }
                else
                {
                    if (array1d[i + 1] % 2 != 0)
                    {
                        counter++;
                        continue;
                    }
                    if (counter >= 1)
                    {
                        int startPoint = i - counter;
                        for (int j = _sizeColumns - 1; j > startPoint + counter; j--)
                        {
                            array1d[j] = array1d[j - 1];
                        }
                        int temp = array1d[startPoint];
                        array1d[startPoint + counter + 1] = temp;
                        i++;
                        counter = 0;
                    }
                }
            }
            string buffer = "";
            for (int i = 0; i < _sizeColumns / 2; i++)
            {
                buffer += $"  {array1d[i]}  ";
            }
            buffer += Environment.NewLine;
            for (int i = _sizeColumns / 2; i < _sizeColumns; i++)
            {
                buffer += $"  {array1d[i]}  ";
            }
            textBoxResult.Text = buffer;
            Array1dFromTextBox();


        }
        private void buttonTask4_Click(object sender, EventArgs e)
        {
            int counter = 0;
            for (int i = _sizeColumns - 1; i > 0; i--)
            {
                if (array1d[i] >= 0)
                {
                    if (array1d[i - 1] >= 0)
                    {
                        counter++;
                    }
                    else
                    {
                        if (counter >= 1)
                        {
                            int temp = counter;
                            while (counter >= 0)
                            {
                                for (int j = i; j < _sizeColumns - 1; j++)
                                {
                                    array1d[j] = array1d[j + 1];
                                }
                                counter--;
                            }
                            _sizeColumns -= temp + 1;

                            break;
                        }
                    }
                }
                else
                {
                    if (array1d[i - 1] < 0)
                    {
                        counter++;
                    }
                    else
                    {
                        if (counter >= 1)
                        {
                            int temp = counter;
                            while (counter >= 0)
                            {
                                for (int j = i; j < _sizeColumns - 1; j++)
                                {
                                    array1d[j] = array1d[j + 1];
                                }
                                counter--;
                            }
                            _sizeColumns -= temp + 1;

                            break;
                        }
                    }
                }
            }
            if (counter >= 1)
            {
                MessageBox.Show("Только одна серия");
                return;
            }
            string buffer = "";
            for (int i = 0; i < _sizeColumns; i++)
            {
                buffer += $"  {array1d[i]}  ";
            }
            buffer += Environment.NewLine;
            textBoxResult.Text = buffer;
            Array1dFromTextBox();
        }
        private void buttonTask5_Click(object sender, EventArgs e)
        {
            //оно вроде работает
            int first = -1;
            int second = -1;
            for (int j = 0; j < _sizeColumns; j++)
            {
                for (int i = 0; i < _sizeRows; i++)
                {
                    if (array2d[i, j] >= 0 && first == -1)
                    {
                        first = j;
                    }
                    if (array2d[_sizeRows - 1 - i, _sizeColumns - 1 - j] < 0 && second == -1)
                    {
                        second = _sizeColumns - 1 - j;
                    }
                }
                if (second != -1 && first != -1)
                {
                    break;
                }
            }
            for (int j = 0; j < _sizeColumns; j++)
            {
                int counter = 0;
                for (int i = 0; i < _sizeRows; i++)
                {
                    if (array2d[i, j] % 2 == 0)
                    {
                        counter++;
                    }
                }
                if (counter > 3)
                {
                    _sizeColumns++;
                    if (j < first)
                        first++;
                    if (j < second)
                        second++;

                    for (int d = _sizeColumns - 1; d > j; d--)
                    {
                        for (int k = 0; k < _sizeRows; k++)
                        {
                            array2d[k, d] = array2d[k, d - 1];


                        }
                    }
                    for (int k = 0; k < _sizeRows; k++)
                    {
                        if (j != _sizeColumns) //вроде и без этого работает
                            array2d[k, j + 1] = Math.Abs(array2d[k, second]) + Math.Abs(array2d[k, first]);

                    }
                    j++;
                }
            }
            string buffer = "";
            MessageBox.Show($" first = {first}   second = {second}");
            for (int i = 0; i < _sizeRows; i++)
            {
                for (int j = 0; j < _sizeColumns; j++)
                {
                    buffer += $"{array2d[i, j].ToString().PadLeft(5).PadRight(5)}  ";
                }
                buffer += Environment.NewLine;
            }
            textBoxResult.Text = buffer;
            Array2dFromTextBox();
        }
        private void buttonTask6_Click(object sender, EventArgs e) 
        {
            
        }

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

        private void UpdateValues()
        {
            _sizeRows = (int)numericUpDownNumberOfRows.Value;
            _sizeColumns = (int)numericUpDownNumberOfColumns.Value;
            MessageBox.Show(_sizeColumns.ToString());
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
            buffer += Environment.NewLine;
            textBoxArray.Text = buffer;

        }

        private void buttonTwoD_Click(object sender, EventArgs e)
        {
            UpdateValues();

            array2d = new int[_sizeRows, _sizeColumns * 2];
            string buffer = "";

            int rangeFrom = Math.Min(_rangeFrom, _rangeTo);
            int rangeTo = Math.Max(_rangeFrom, _rangeTo);

            for (int i = 0; i < _sizeRows; i++)
            {
                for (int j = 0; j < _sizeColumns * 2; j++)
                {
                    if (j < _sizeColumns)
                        array2d[i, j] = random.Next(rangeFrom, rangeTo + 1);
                    else
                        array2d[i, j] = 0;
                    buffer += $"{array2d[i, j].ToString().PadLeft(5).PadRight(5)}  ";
                }
                buffer += Environment.NewLine;
            }
            textBoxArray.Text = buffer;
        }


        private void textBoxArray_TextChanged(object sender, EventArgs e)
        {
            if (textBoxArray.Lines.Length <= 2)
            {
                Array1dFromTextBox();
            } else if (textBoxArray.Lines.Length > 1)
            {
                Array2dFromTextBox();
            }
        }
        private void Array1dFromTextBox()
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
        }
        private void Array2dFromTextBox()
        {
            string[] textBoxText = textBoxArray.Lines;
            int countRows = textBoxArray.Lines.Length - 1;
            int[,] array = new int[countRows, textBoxText[0].Replace(" ", "").Length];
            
            int sizeM = 0, sizeN = 0;
            for (int i = 0; i < countRows; i++)
            {
                sizeN = 0;
                string[] line = textBoxText[i].Split();
                for (int j = 0; j < line.Length; j++)
                {
                    if (Int32.TryParse(line[j], out int result))
                    {
                        array[sizeM, sizeN] = result;
                        sizeN++;
                    }
                }
                sizeM++;
            }
            array2d = new int[sizeM, sizeN];
            for (int i = 0; i < sizeM; i++)
            {
                for (int j = 0; j < sizeN; j++)
                {
                    array2d[i, j] = array[i, j];
                }
            }
            
        }
    }
}
