using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lab1;

public partial class FormPractise2 : Form
{
    private Deque? deque;
    int step;
    public FormPractise2()
    {
        InitializeComponent();
        step = 0;
        Sort();
    }
    public List<int[]> states = new();
    public void TestDeq()
    {
        deque = new();
        deque.PushFront(10);
        deque.PushFront(11);
        deque.PushFront(12);
        deque.PushFront(13);
        deque.PushBack(9);
        string buffer = "";
        foreach (var i in deque.GetAll())
        {
            buffer += $"  {i}  ";
        }
        textBoxAfter.Text = buffer;
    }
    public void CollectValue(int[] array)
    {
        int size = array.GetLength(0);
        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
        {
            arr[i] = array[i];
        }
        states.Add(arr);
    }
    public void StoogeSort(int[] array, int left, int right)
    {
        int tmp, k;
        if (array[left] > array[right])
        {
            CollectValue(array);
            tmp = array[left];
            array[left] = array[right];
            array[right] = tmp;
            CollectValue(array);
        }
        if ((left + 1) >= right)
        {
            return;
        }

        k = (right - left + 1) / 3;
        StoogeSort(array, left, right - k);
        StoogeSort(array, left + k, right);
        StoogeSort(array, left, right - k);
    }
    public void Sort()
    {
        int[] array = new int[10];
        Random random = new();
        string buffer = "";
        for (int i = 0; i < array.GetLength(0); i++)
        {
            array[i] = random.Next(-20, 20);
            buffer += $"  {array[i]}  ";
        }
        CollectValue(array);
        textBoxBefore.Text = buffer;
        StoogeSort(array, 0, array.GetLength(0) - 1);
    }

    private void buttonStep_Click(object sender, EventArgs e)
    {
        if (states.Count <= 0)
        {
            textBoxAfter.Text = "Всё";
            return;
        }
        textBoxAfter.Clear();
        int[] array = states[0];
        string buffer = "";
        for (int i = 0; i < array.GetLength(0); i++)
            buffer += $"  {array[i]}  ";
        buffer += Environment.NewLine + states.Count.ToString();
            
        textBoxAfter.Text = buffer;
        states.RemoveAt(0);
    }
}
