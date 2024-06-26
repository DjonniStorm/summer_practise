namespace Lab1
{
    partial class FormPractise2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPractise2));
            panelLeft = new Panel();
            label1 = new Label();
            buttonGetAll = new Button();
            buttonDel = new Button();
            buttonAddRandom = new Button();
            labelInfoADT = new Label();
            panelRight = new Panel();
            labelInfoAlgo = new Label();
            panelCenter = new Panel();
            buttonStep = new Button();
            labelAfter = new Label();
            labelBefore = new Label();
            textBoxAfter = new TextBox();
            textBoxBefore = new TextBox();
            labelInfoAlgoSort = new Label();
            panelLeft.SuspendLayout();
            panelRight.SuspendLayout();
            panelCenter.SuspendLayout();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.Controls.Add(label1);
            panelLeft.Controls.Add(buttonGetAll);
            panelLeft.Controls.Add(buttonDel);
            panelLeft.Controls.Add(buttonAddRandom);
            panelLeft.Controls.Add(labelInfoADT);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(211, 450);
            panelLeft.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 43);
            label1.Name = "label1";
            label1.Size = new Size(199, 165);
            label1.TabIndex = 6;
            label1.Text = resources.GetString("label1.Text");
            // 
            // buttonGetAll
            // 
            buttonGetAll.Location = new Point(27, 321);
            buttonGetAll.Name = "buttonGetAll";
            buttonGetAll.Size = new Size(114, 38);
            buttonGetAll.TabIndex = 2;
            buttonGetAll.Text = "Вывести все";
            buttonGetAll.UseVisualStyleBackColor = true;
            // 
            // buttonDel
            // 
            buttonDel.Location = new Point(27, 277);
            buttonDel.Name = "buttonDel";
            buttonDel.Size = new Size(114, 38);
            buttonDel.TabIndex = 1;
            buttonDel.Text = "Удалить";
            buttonDel.UseVisualStyleBackColor = true;
            // 
            // buttonAddRandom
            // 
            buttonAddRandom.Location = new Point(27, 233);
            buttonAddRandom.Name = "buttonAddRandom";
            buttonAddRandom.Size = new Size(114, 38);
            buttonAddRandom.TabIndex = 0;
            buttonAddRandom.Text = "Добавить рандом";
            buttonAddRandom.UseVisualStyleBackColor = true;
            // 
            // labelInfoADT
            // 
            labelInfoADT.AutoSize = true;
            labelInfoADT.Location = new Point(12, 9);
            labelInfoADT.Name = "labelInfoADT";
            labelInfoADT.Size = new Size(87, 15);
            labelInfoADT.TabIndex = 0;
            labelInfoADT.Text = "Описание АТД";
            // 
            // panelRight
            // 
            panelRight.Controls.Add(labelInfoAlgo);
            panelRight.Dock = DockStyle.Right;
            panelRight.Location = new Point(552, 0);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(248, 450);
            panelRight.TabIndex = 1;
            // 
            // labelInfoAlgo
            // 
            labelInfoAlgo.AutoSize = true;
            labelInfoAlgo.Location = new Point(6, 9);
            labelInfoAlgo.Name = "labelInfoAlgo";
            labelInfoAlgo.Size = new Size(124, 15);
            labelInfoAlgo.TabIndex = 0;
            labelInfoAlgo.Text = "Описание алгоритма";
            // 
            // panelCenter
            // 
            panelCenter.Controls.Add(buttonStep);
            panelCenter.Controls.Add(labelAfter);
            panelCenter.Controls.Add(labelBefore);
            panelCenter.Controls.Add(textBoxAfter);
            panelCenter.Controls.Add(textBoxBefore);
            panelCenter.Controls.Add(labelInfoAlgoSort);
            panelCenter.Dock = DockStyle.Fill;
            panelCenter.Location = new Point(211, 0);
            panelCenter.Name = "panelCenter";
            panelCenter.Size = new Size(341, 450);
            panelCenter.TabIndex = 2;
            // 
            // buttonStep
            // 
            buttonStep.Location = new Point(38, 289);
            buttonStep.Name = "buttonStep";
            buttonStep.Size = new Size(56, 56);
            buttonStep.TabIndex = 5;
            buttonStep.Text = "Шаг";
            buttonStep.UseVisualStyleBackColor = true;
            buttonStep.Click += buttonStep_Click;
            // 
            // labelAfter
            // 
            labelAfter.AutoSize = true;
            labelAfter.Location = new Point(6, 159);
            labelAfter.Name = "labelAfter";
            labelAfter.Size = new Size(88, 15);
            labelAfter.TabIndex = 4;
            labelAfter.Text = "Массив после:";
            // 
            // labelBefore
            // 
            labelBefore.AutoSize = true;
            labelBefore.Location = new Point(6, 62);
            labelBefore.Name = "labelBefore";
            labelBefore.Size = new Size(52, 15);
            labelBefore.TabIndex = 3;
            labelBefore.Text = "Массив:";
            // 
            // textBoxAfter
            // 
            textBoxAfter.Location = new Point(6, 177);
            textBoxAfter.Multiline = true;
            textBoxAfter.Name = "textBoxAfter";
            textBoxAfter.Size = new Size(329, 36);
            textBoxAfter.TabIndex = 2;
            // 
            // textBoxBefore
            // 
            textBoxBefore.Location = new Point(6, 80);
            textBoxBefore.Multiline = true;
            textBoxBefore.Name = "textBoxBefore";
            textBoxBefore.Size = new Size(329, 36);
            textBoxBefore.TabIndex = 1;
            // 
            // labelInfoAlgoSort
            // 
            labelInfoAlgoSort.AutoSize = true;
            labelInfoAlgoSort.Location = new Point(6, 9);
            labelInfoAlgoSort.Name = "labelInfoAlgoSort";
            labelInfoAlgoSort.Size = new Size(192, 15);
            labelInfoAlgoSort.TabIndex = 0;
            labelInfoAlgoSort.Text = "Описание алгоритма сортировки";
            // 
            // FormPractise2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelCenter);
            Controls.Add(panelRight);
            Controls.Add(panelLeft);
            Name = "FormPractise2";
            Text = "FormPractise2";
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            panelRight.ResumeLayout(false);
            panelRight.PerformLayout();
            panelCenter.ResumeLayout(false);
            panelCenter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLeft;
        private Button buttonGetAll;
        private Button buttonDel;
        private Button buttonAddRandom;
        private Label labelInfoADT;
        private Panel panelRight;
        private Panel panelCenter;
        private Label labelAfter;
        private Label labelBefore;
        private TextBox textBoxAfter;
        private TextBox textBoxBefore;
        private Label labelInfoAlgoSort;
        private Label label1;
        private Label labelInfoAlgo;
        private Button buttonStep;
    }
}