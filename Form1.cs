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
        private void Createbutton_Click(object sender, EventArgs e)
        {
            cl1 = new DefaultClass(Convert.ToInt32(ReadtextBox.Text));
            ArraytextBox.Text = cl1.PrintArray();
        }

        private void ChetSumButton_Click(object sender, EventArgs e)
        {
            OutputtextBox.Text = cl1.ChetSum(ArraytextBox.Text.Length);
            ArraytextBox.Text = cl1.PrintArray();
        }

        private void NeChetbutton_Click(object sender, EventArgs e)
        { 
            OutputtextBox.Text = cl1.ChetSum();
            ArraytextBox.Text = cl1.PrintArray();
        }
    }
}
