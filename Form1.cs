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
        public Form1()
        {
            InitializeComponent();
        }
        DefaultClass cl1;
        SecondClass cl2;
        private void Createbutton_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
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
            Random rand = new Random();
            if (Convert.ToInt32(ReadtextBox.Text) < 10)
            {
                size = rand.Next(10, 20);
            }
            else
            {
                size = Convert.ToInt32(ReadtextBox.Text);
            }
            cl2 = new SecondClass(size);
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
    }
}
