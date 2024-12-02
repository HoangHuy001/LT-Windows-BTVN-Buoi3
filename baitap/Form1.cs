using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace baitap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (listView1.Columns.Count == 0)
            {
                listView1.View = View.Details;
                listView1.Columns.Add("Last Name", 100);
                listView1.Columns.Add("First Name", 100);
                listView1.Columns.Add("Phone", 150);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var item = listView1.SelectedItems[0];
                txt_LastName.Text = item.Text; // Last Name
                txt_FirstName.Text = item.SubItems.Count > 1 ? item.SubItems[1].Text : string.Empty; // First Name
                txt_Phone.Text = item.SubItems.Count > 2 ? item.SubItems[2].Text : string.Empty; // Phone
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void formatToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_LastName.Text) ||
                string.IsNullOrWhiteSpace(txt_FirstName.Text) ||
                string.IsNullOrWhiteSpace(txt_Phone.Text))
            {
                MessageBox.Show("Please fill in all fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var item = new ListViewItem(txt_LastName.Text); // Last Name
            item.SubItems.Add(txt_FirstName.Text); // First Name
            item.SubItems.Add(txt_Phone.Text); // Phone
            listView1.Items.Add(item);
             ClearTextBoxes();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
                ClearTextBoxes();
            }
            else
            {
                MessageBox.Show("Please select an item to delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ClearTextBoxes()
        {
            txt_LastName.Clear();
            txt_FirstName.Clear();
            txt_Phone.Clear();
        }


        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var item = listView1.SelectedItems[0];
                item.Text = txt_LastName.Text; // Last Name
                if (item.SubItems.Count > 1) item.SubItems[1].Text = txt_FirstName.Text; // First Name
                if (item.SubItems.Count > 2) item.SubItems[2].Text = txt_Phone.Text; // Phone

                ClearTextBoxes();
            }
            else
            {
                MessageBox.Show("Vui long chon chinh sua !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
        }
