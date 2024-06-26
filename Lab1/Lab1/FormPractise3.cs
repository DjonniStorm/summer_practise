using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1;

public partial class FormPractise3 : Form
{
    private List<Sofa> divani;
    public FormPractise3()
    {
        InitializeComponent();
        divani = new();
    }

    private void buttonAddValue_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(textBoxMaterial.Text) || string.IsNullOrEmpty(textBoxName.Text))
        {
            MessageBox.Show("Не заполнено");
            return;
        }
        Sofa sofa = new();
        sofa.Length = (int)numericUpDownLength.Value;
        sofa.Width = (int)numericUpDownWidth.Value;
        sofa.Height = (int)numericUpDownHeight.Value;

        sofa.Finishing = textBoxMaterial.Text;
        sofa.Name = textBoxName.Text;

        sofa.Armrests = checkBox.Checked;
        sofa.Mechanism = checkBoxMechanism.Checked;
        divani.Add(sofa);

        string buffer = $" {sofa.Length}  {sofa.Width}  {sofa.Height}  {sofa.Finishing}  {sofa.Name}  Подлокотники {(sofa.Armrests ? "есть" : "нет")} {sofa.Mechanism}";
        listBoxSofa.Items.Add(buffer);
    }
}
