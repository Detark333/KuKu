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
        public Form1()
        {
            InitializeComponent();
        }
        DefaultClass cl1;
        private void Createbutton_Click(object sender, EventArgs e)
        {
            cl1 = new DefaultClass();
            
        }

        private void ChetSumButton_Click(object sender, EventArgs e)
        {
            int size = Convert.ToInt32(ReadtextBox.Text);
            OutputtextBox.Text = cl1.ChetSum(size);
            ArraytextBox.Text = cl1.PrintArray(size);

        }

        private void NeChetbutton_Click(object sender, EventArgs e)
        {
            int size = Convert.ToInt32(ReadtextBox.Text);
            OutputtextBox.Text = cl1.NeChetSum(size);
            ArraytextBox.Text = cl1.PrintArray(size);

        }
    }
}
