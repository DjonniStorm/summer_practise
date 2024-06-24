namespace Lab1
{
    partial class FormPractise1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelButtons = new Panel();
            labelTasks = new Label();
            buttonTask6 = new Button();
            buttonTask1 = new Button();
            buttonTask3 = new Button();
            buttonTask4 = new Button();
            buttonTask5 = new Button();
            buttonTask2 = new Button();
            panelIO = new Panel();
            labelTo = new Label();
            labelFrom = new Label();
            labelValuesRange = new Label();
            label1 = new Label();
            labelNumberOfRows = new Label();
            numericUpDownNumberOfColumns = new NumericUpDown();
            labelSize = new Label();
            numericUpDownTo = new NumericUpDown();
            numericUpDownFrom = new NumericUpDown();
            numericUpDownNumberOfRows = new NumericUpDown();
            labelArrayGeneration = new Label();
            buttonTwoD = new Button();
            buttonOneD = new Button();
            textBoxArray = new TextBox();
            panelResult = new Panel();
            textBoxResult = new TextBox();
            labelTask = new Label();
            buttonShowResult = new Button();
            panelButtons.SuspendLayout();
            panelIO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNumberOfColumns).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFrom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNumberOfRows).BeginInit();
            panelResult.SuspendLayout();
            SuspendLayout();
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(labelTasks);
            panelButtons.Controls.Add(buttonTask6);
            panelButtons.Controls.Add(buttonTask1);
            panelButtons.Controls.Add(buttonTask3);
            panelButtons.Controls.Add(buttonTask4);
            panelButtons.Controls.Add(buttonTask5);
            panelButtons.Controls.Add(buttonTask2);
            panelButtons.Dock = DockStyle.Left;
            panelButtons.Location = new Point(0, 0);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(164, 450);
            panelButtons.TabIndex = 0;
            // 
            // labelTasks
            // 
            labelTasks.AutoSize = true;
            labelTasks.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelTasks.Location = new Point(12, 9);
            labelTasks.Name = "labelTasks";
            labelTasks.Size = new Size(73, 21);
            labelTasks.TabIndex = 1;
            labelTasks.Text = "Задания:";
            // 
            // buttonTask6
            // 
            buttonTask6.Location = new Point(3, 272);
            buttonTask6.Name = "buttonTask6";
            buttonTask6.Size = new Size(158, 40);
            buttonTask6.TabIndex = 6;
            buttonTask6.Text = "Задание 6";
            buttonTask6.UseVisualStyleBackColor = true;
            buttonTask6.Click += buttonTask6_Click;
            // 
            // buttonTask1
            // 
            buttonTask1.Location = new Point(3, 42);
            buttonTask1.Name = "buttonTask1";
            buttonTask1.Size = new Size(158, 40);
            buttonTask1.TabIndex = 5;
            buttonTask1.Text = "Задание 1";
            buttonTask1.UseVisualStyleBackColor = true;
            buttonTask1.Click += buttonTask1_Click;
            // 
            // buttonTask3
            // 
            buttonTask3.Location = new Point(3, 134);
            buttonTask3.Name = "buttonTask3";
            buttonTask3.Size = new Size(158, 40);
            buttonTask3.TabIndex = 4;
            buttonTask3.Text = "Задание 3";
            buttonTask3.UseVisualStyleBackColor = true;
            buttonTask3.Click += buttonTask3_Click;
            // 
            // buttonTask4
            // 
            buttonTask4.Location = new Point(3, 180);
            buttonTask4.Name = "buttonTask4";
            buttonTask4.Size = new Size(158, 40);
            buttonTask4.TabIndex = 3;
            buttonTask4.Text = "Задание 4";
            buttonTask4.UseVisualStyleBackColor = true;
            buttonTask4.Click += buttonTask4_Click;
            // 
            // buttonTask5
            // 
            buttonTask5.Location = new Point(3, 226);
            buttonTask5.Name = "buttonTask5";
            buttonTask5.Size = new Size(158, 40);
            buttonTask5.TabIndex = 2;
            buttonTask5.Text = "Задание 5";
            buttonTask5.UseVisualStyleBackColor = true;
            buttonTask5.Click += buttonTask5_Click;
            // 
            // buttonTask2
            // 
            buttonTask2.Location = new Point(3, 88);
            buttonTask2.Name = "buttonTask2";
            buttonTask2.Size = new Size(158, 40);
            buttonTask2.TabIndex = 1;
            buttonTask2.Text = "Задание 2";
            buttonTask2.UseVisualStyleBackColor = true;
            buttonTask2.Click += buttonTask2_Click;
            // 
            // panelIO
            // 
            panelIO.Controls.Add(labelTo);
            panelIO.Controls.Add(labelFrom);
            panelIO.Controls.Add(labelValuesRange);
            panelIO.Controls.Add(label1);
            panelIO.Controls.Add(labelNumberOfRows);
            panelIO.Controls.Add(numericUpDownNumberOfColumns);
            panelIO.Controls.Add(labelSize);
            panelIO.Controls.Add(numericUpDownTo);
            panelIO.Controls.Add(numericUpDownFrom);
            panelIO.Controls.Add(numericUpDownNumberOfRows);
            panelIO.Controls.Add(labelArrayGeneration);
            panelIO.Controls.Add(buttonTwoD);
            panelIO.Controls.Add(buttonOneD);
            panelIO.Controls.Add(textBoxArray);
            panelIO.Dock = DockStyle.Top;
            panelIO.Location = new Point(164, 0);
            panelIO.Name = "panelIO";
            panelIO.Size = new Size(636, 295);
            panelIO.TabIndex = 1;
            // 
            // labelTo
            // 
            labelTo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelTo.AutoSize = true;
            labelTo.Location = new Point(500, 101);
            labelTo.Name = "labelTo";
            labelTo.Size = new Size(25, 15);
            labelTo.TabIndex = 13;
            labelTo.Text = "До:";
            // 
            // labelFrom
            // 
            labelFrom.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelFrom.AutoSize = true;
            labelFrom.Location = new Point(500, 72);
            labelFrom.Name = "labelFrom";
            labelFrom.Size = new Size(24, 15);
            labelFrom.TabIndex = 12;
            labelFrom.Text = "От:";
            // 
            // labelValuesRange
            // 
            labelValuesRange.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelValuesRange.AutoSize = true;
            labelValuesRange.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelValuesRange.Location = new Point(488, 42);
            labelValuesRange.Name = "labelValuesRange";
            labelValuesRange.Size = new Size(128, 17);
            labelValuesRange.TabIndex = 11;
            labelValuesRange.Text = "Диапазон значений:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(299, 72);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 10;
            label1.Text = "Число столбцов:";
            // 
            // labelNumberOfRows
            // 
            labelNumberOfRows.AutoSize = true;
            labelNumberOfRows.Location = new Point(299, 101);
            labelNumberOfRows.Name = "labelNumberOfRows";
            labelNumberOfRows.Size = new Size(79, 15);
            labelNumberOfRows.TabIndex = 9;
            labelNumberOfRows.Text = "Число строк:";
            // 
            // numericUpDownNumberOfColumns
            // 
            numericUpDownNumberOfColumns.Location = new Point(405, 70);
            numericUpDownNumberOfColumns.Name = "numericUpDownNumberOfColumns";
            numericUpDownNumberOfColumns.Size = new Size(50, 23);
            numericUpDownNumberOfColumns.TabIndex = 8;
            // 
            // labelSize
            // 
            labelSize.AutoSize = true;
            labelSize.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelSize.Location = new Point(290, 42);
            labelSize.Name = "labelSize";
            labelSize.Size = new Size(88, 17);
            labelSize.TabIndex = 7;
            labelSize.Text = "Размерность:";
            // 
            // numericUpDownTo
            // 
            numericUpDownTo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numericUpDownTo.Location = new Point(573, 99);
            numericUpDownTo.Minimum = new decimal(new int[] { 99, 0, 0, int.MinValue });
            numericUpDownTo.Name = "numericUpDownTo";
            numericUpDownTo.Size = new Size(50, 23);
            numericUpDownTo.TabIndex = 6;
            // 
            // numericUpDownFrom
            // 
            numericUpDownFrom.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numericUpDownFrom.Location = new Point(573, 70);
            numericUpDownFrom.Minimum = new decimal(new int[] { 99, 0, 0, int.MinValue });
            numericUpDownFrom.Name = "numericUpDownFrom";
            numericUpDownFrom.Size = new Size(50, 23);
            numericUpDownFrom.TabIndex = 5;
            // 
            // numericUpDownNumberOfRows
            // 
            numericUpDownNumberOfRows.Location = new Point(405, 99);
            numericUpDownNumberOfRows.Name = "numericUpDownNumberOfRows";
            numericUpDownNumberOfRows.Size = new Size(50, 23);
            numericUpDownNumberOfRows.TabIndex = 4;
            // 
            // labelArrayGeneration
            // 
            labelArrayGeneration.AutoSize = true;
            labelArrayGeneration.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelArrayGeneration.Location = new Point(15, 9);
            labelArrayGeneration.Name = "labelArrayGeneration";
            labelArrayGeneration.Size = new Size(152, 21);
            labelArrayGeneration.TabIndex = 3;
            labelArrayGeneration.Text = "Генерация массива:";
            // 
            // buttonTwoD
            // 
            buttonTwoD.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonTwoD.Location = new Point(405, 180);
            buttonTwoD.Name = "buttonTwoD";
            buttonTwoD.Size = new Size(105, 35);
            buttonTwoD.TabIndex = 2;
            buttonTwoD.Text = "Двумерный";
            buttonTwoD.UseVisualStyleBackColor = true;
            buttonTwoD.Click += buttonTwoD_Click;
            // 
            // buttonOneD
            // 
            buttonOneD.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonOneD.Location = new Point(405, 139);
            buttonOneD.Name = "buttonOneD";
            buttonOneD.Size = new Size(105, 35);
            buttonOneD.TabIndex = 1;
            buttonOneD.Text = "Одномерный";
            buttonOneD.UseVisualStyleBackColor = true;
            buttonOneD.Click += buttonOneD_Click;
            // 
            // textBoxArray
            // 
            textBoxArray.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxArray.Location = new Point(11, 41);
            textBoxArray.Multiline = true;
            textBoxArray.Name = "textBoxArray";
            textBoxArray.PlaceholderText = "Элементы массива";
            textBoxArray.Size = new Size(273, 192);
            textBoxArray.TabIndex = 0;
            // 
            // panelResult
            // 
            panelResult.Controls.Add(textBoxResult);
            panelResult.Controls.Add(labelTask);
            panelResult.Controls.Add(buttonShowResult);
            panelResult.Dock = DockStyle.Bottom;
            panelResult.Location = new Point(164, 239);
            panelResult.Name = "panelResult";
            panelResult.Size = new Size(636, 211);
            panelResult.TabIndex = 2;
            // 
            // textBoxResult
            // 
            textBoxResult.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxResult.Location = new Point(15, 33);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.PlaceholderText = "Результат обработки";
            textBoxResult.Size = new Size(273, 175);
            textBoxResult.TabIndex = 14;
            // 
            // labelTask
            // 
            labelTask.AutoSize = true;
            labelTask.Location = new Point(15, 12);
            labelTask.Name = "labelTask";
            labelTask.Size = new Size(103, 15);
            labelTask.TabIndex = 1;
            labelTask.Text = "Тут будет задание";
            // 
            // buttonShowResult
            // 
            buttonShowResult.Location = new Point(405, 84);
            buttonShowResult.Name = "buttonShowResult";
            buttonShowResult.Size = new Size(111, 36);
            buttonShowResult.TabIndex = 0;
            buttonShowResult.Text = "Результат";
            buttonShowResult.UseVisualStyleBackColor = true;
            // 
            // FormPractise1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelResult);
            Controls.Add(panelIO);
            Controls.Add(panelButtons);
            Name = "FormPractise1";
            Text = "Практическая работа №1";
            panelButtons.ResumeLayout(false);
            panelButtons.PerformLayout();
            panelIO.ResumeLayout(false);
            panelIO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNumberOfColumns).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTo).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFrom).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNumberOfRows).EndInit();
            panelResult.ResumeLayout(false);
            panelResult.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelButtons;
        private Button buttonTask6;
        private Button buttonTask1;
        private Button buttonTask3;
        private Button buttonTask4;
        private Button buttonTask5;
        private Button buttonTask2;
        private Label labelTasks;
        private Panel panelIO;
        private TextBox textBoxArray;
        private Label labelArrayGeneration;
        private Button buttonTwoD;
        private Button buttonOneD;
        private Label labelNumberOfRows;
        private NumericUpDown numericUpDownNumberOfColumns;
        private Label labelSize;
        private NumericUpDown numericUpDownTo;
        private NumericUpDown numericUpDownFrom;
        private NumericUpDown numericUpDownNumberOfRows;
        private Label label1;
        private Label labelTo;
        private Label labelFrom;
        private Label labelValuesRange;
        private Panel panelResult;
        private Label labelTask;
        private Button buttonShowResult;
        private TextBox textBoxResult;
    }
}