using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysAdmin_Remider
{
    public partial class Form1 : Form
    {
        private readonly string[] priorities = { "Незначительная", "Низкая", "Средняя", "Высокая", "Критическая" };

        public Form1()
        {
            InitializeComponent();

            comboBox1.Items.AddRange(priorities);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            dataGridView1.Width = this.ClientSize.Width - 24;
            dataGridView1.Height = this.ClientSize.Height - 335;

            groupBox1.Top = this.ClientSize.Height - 316;
            groupBox1.Width = this.ClientSize.Width - 199;

            richTextBox1.Width = this.ClientSize.Width - 387;

            label2.Left = this.ClientSize.Width - 376;

            dateTimePicker1.Left = this.ClientSize.Width - 373;

            label3.Left = this.ClientSize.Width - 376;

            comboBox1.Left = this.ClientSize.Width - 373;

            button1.Left = this.ClientSize.Width - 180;

            button2.Left = this.ClientSize.Width - 180;

            button3.Left = this.ClientSize.Width - 180;

            button4.Left = this.ClientSize.Width - 180;
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int textLength = richTextBox1.Text.Length;

            if (e.KeyChar != '\b')
            {
                textLength++;
            }

            button1.Enabled = textLength > 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[1].Value = dataGridView1.Rows.Count.ToString();
            dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[2].Value = richTextBox1.Text;
            dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[3].Value = dateTimePicker1.Value;
            dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[4].Value = comboBox1.SelectedValue.ToString();

            //dataGridView1.Rows.Add();

            richTextBox2.Clear();
            richTextBox2.AppendText(dataGridView1.Rows.Add().ToString());
        }
    }
}
