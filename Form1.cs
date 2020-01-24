using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsTest
{
    public partial class Form1 : Form
    {
        int size;
        int sizeList;
        List<InterfaceIndex> listBox;
        public event myDelegate event1;
        public event myDelegate2 event2;
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
            listBox = new List<InterfaceIndex>();
            int first = rand.Next(5,10);
            int second = rand.Next(5, 10);
            for(int i = 0; i < first; ++i)
            {
                listBox.Add(new DefaultClass(rand.Next(10, 20)));
            }
            for (int i = 0; i < second; ++i)
            {
                listBox.Add(new SecondClass(rand.Next(10, 20)));
            }

            foreach (var item in listBox)
            {
                listBoxClasses.Items.Add(item);
            }
        }
        DefaultClass cl1;
        SecondClass cl2;
        private void Createbutton_Click(object sender, EventArgs e)
        {         
            if (Convert.ToInt32(ReadtextBox.Text) < 10)
            {
                size = rand.Next(10, 20);
            }
            else
            {
                size = Convert.ToInt32(ReadtextBox.Text);
            }
            cl1 = new DefaultClass(size);
            
            ArraytextBox.Text = PrintArray(cl1);
        }

        private void ChetSumButton_Click(object sender, EventArgs e)
        {
            OutputtextBox.Text = cl1.ChetSum(ArraytextBox.Text.Length);
            ArraytextBox.Text = PrintArray(cl1);
        }

        private void NeChetbutton_Click(object sender, EventArgs e)
        { 
            OutputtextBox.Text = cl1.ChetSum();
            ArraytextBox.Text = PrintArray(cl1);
        }
        private string PrintArray(InterfaceIndex e)
        {
            string str = "";
            for (int i = 0; i < size; ++i)
            {
                str += e[i];
            }
            return str;
        }

        private void CreatebuttonList_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(ReadtextBox.Text) < 10)
            {
                sizeList = rand.Next(10, 20);
            }
            else
            {
                sizeList = Convert.ToInt32(ReadtextBox.Text);
            }
            cl2 = new SecondClass(sizeList);
            ArraytextBox.Text = PrintArray(cl2);
        }

        private void ChetbuttonList_Click(object sender, EventArgs e)
        {
            OutputtextBox.Text = cl2.ChetSum(ArraytextBox.Text.Length);
            ArraytextBox.Text = PrintArray(cl2);
        }

        private void NeChetbuttonList_Click(object sender, EventArgs e)
        {
            OutputtextBox.Text = cl2.ChetSum();
            ArraytextBox.Text = PrintArray(cl2);
        }

        private void InsertFirstM_Click(object sender, EventArgs e)
        {
            event1 += listBox.ElementAt(listBoxClasses.SelectedIndex).ChetSum;
        }

        private void DeleteFirstM_Click(object sender, EventArgs e)
        {
            event1 -= listBox.ElementAt(listBoxClasses.SelectedIndex).ChetSum;
        }

        private void InsertSecondM_Click(object sender, EventArgs e)
        {
            event2 += listBox.ElementAt(listBoxClasses.SelectedIndex).ChetSum;
        }

        private void DeleteSecondM_Click(object sender, EventArgs e)
        {
            event2 -= listBox.ElementAt(listBoxClasses.SelectedIndex).ChetSum;
        }

        private void EventFirst_Click(object sender, EventArgs e)
        {
            richTextBox.Text += event1?.Invoke(Convert.ToInt32(ReadtextBox.Text));
        }

        private void EventSecond_Click(object sender, EventArgs e)
        {
            richTextBox.Text += event2?.Invoke();
        }
    }
}
