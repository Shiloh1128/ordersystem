using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Order_system
{
    public partial class Form1 : Form
    {
        private string addData = "";
        private int tabCtr = 0;
        public Form1()
        {
            InitializeComponent();
            tabControl1.TabPages[0].ImageIndex = 0;
            tabControl1.TabPages[1].ImageIndex = 1;
            tabControl1.TabPages[2].ImageIndex = 2;
            tabControl1.TabPages[3].ImageIndex = 3;
            //this.Controls.OfType<Button>()
            // tabControl1.
        }
        private void testbtn_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(((Button)sender).Text);
            addData += ((Button)sender).Text;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[0].Value == null)
                return;
        }

        private void button68_Click(object sender, EventArgs e)
        {
            int x = tabCtr;
            int y = 0;
            dataGridView1[x, y].Value = addData;
        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            int maxTabPages = tabControl1.TabCount;
            if (tabControl1.SelectedIndex != (maxTabPages))
            {
                tabControl1.SelectedIndex = tabControl1.SelectedIndex + 1;
            }
            else
            {
                tabControl1.SelectedIndex = 0;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            MessageBox.Show("點餐結束");
            this.Close();
        }

        private void buttonUpPage_Click(object sender, EventArgs e)
        {
              
        }

        private void btnNo1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabCtr = (sender as TabControl).SelectedIndex;
        }
    }
}
