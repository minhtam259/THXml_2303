using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;
using THXml;

namespace THXml
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string path = @"E:\WFC#\THXml\THXml\bin\Debug\XmlSinhVien_ADD_EDIT_DEL.xml";
        private void loaddata_Click(object sender, EventArgs e)
        {
            loadfile();
        }

        private void loadfile()
        {
            dataGridView1.Rows.Clear();
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(path);
            XPathNavigator nav = xdoc.CreateNavigator();
            XPathNodeIterator nodeiter = nav.Select(@"BIZREQUEST/DATAAREA/VOUCHERS/HEADER");
            int row = 0;
            while (nodeiter.MoveNext())
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[row].Cells[0].Value = nodeiter.Current.SelectSingleNode("@SinhvienPrkID").Value.ToString();
                dataGridView1.Rows[row].Cells[1].Value = nodeiter.Current.SelectSingleNode("@SinhvienID").Value.ToString();
                dataGridView1.Rows[row].Cells[2].Value = nodeiter.Current.SelectSingleNode("@SinVienName").Value.ToString();
                dataGridView1.Rows[row].Cells[3].Value = nodeiter.Current.SelectSingleNode("@SinvienEmail").Value.ToString();
                dataGridView1.Rows[row].Cells[4].Value = nodeiter.Current.SelectSingleNode("@SinvienPhone").Value.ToString();
                dataGridView1.Rows[row].Cells[5].Value = nodeiter.Current.SelectSingleNode("@SinhvienAddr").Value.ToString();
                row++;
            }
            dataGridView1.Refresh();
        }
        private void themdata_Click(object sender, EventArgs e)
        {
            sinhvien sv = new sinhvien();
            sv.PrkId = prktxt.Text;
            sv.Id = idtxt.Text;
            sv.Name = nametxt.Text;
            sv.Email = emailtxt.Text;
            sv.Phone = phonetxt.Text;
            sv.Addr = addtxt.Text;
            SinhVienDBMng.themsv(sv);
            loadfile();
        }

        private void suadata_Click(object sender, EventArgs e)
        {
            sinhvien sv = new sinhvien();
            sv.PrkId = prktxt.Text;
            sv.Id = idtxt.Text;
            sv.Name = nametxt.Text;
            sv.Email = emailtxt.Text;
            sv.Phone = phonetxt.Text;
            sv.Addr = addtxt.Text;
            SinhVienDBMng.suasv(sv);
            loadfile();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            prktxt.Text = dataGridView1.SelectedRows[0].Cells["prkid"].Value.ToString();
            idtxt.Text = dataGridView1.SelectedRows[0].Cells["id"].Value.ToString();
            nametxt.Text = dataGridView1.SelectedRows[0].Cells["name"].Value.ToString();
            emailtxt.Text = dataGridView1.SelectedRows[0].Cells["email"].Value.ToString();
            phonetxt.Text = dataGridView1.SelectedRows[0].Cells["phone"].Value.ToString();
            addtxt.Text = dataGridView1.SelectedRows[0].Cells["add"].Value.ToString();
        }

        private void xoadata_Click(object sender, EventArgs e)
        {
            sinhvien sv = new sinhvien();
            sv.PrkId = prktxt.Text;
            SinhVienDBMng.xoasv(sv);
            loadfile();
        }

        private void updatedata_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnn = connectDB.DataConnection())
            {
                int rows = dataGridView1.Rows.Count;
                for (int i = 0; i < rows; ++i)
                {
                    SqlCommand dCmd = new SqlCommand("Delete Table_1", cnn);
                    string oString = @"Insert into Table_1 Values(@SinhvienPrkID,@SinhvienID,@SinVienName,@SinvienEmail,@SinvienPhone,@SinhvienAddr)";
                    SqlCommand oCmd = new SqlCommand(oString, cnn);
                    oCmd.Parameters.AddWithValue("@SinhvienPrkID", dataGridView1.Rows[i].Cells["prkid"].Value.ToString());
                    oCmd.Parameters.AddWithValue("@SinhvienID", dataGridView1.Rows[i].Cells["id"].Value.ToString());
                    oCmd.Parameters.AddWithValue("@SinVienName", dataGridView1.Rows[i].Cells["name"].Value.ToString());
                    oCmd.Parameters.AddWithValue("@SinvienEmail", dataGridView1.Rows[i].Cells["email"].Value.ToString());
                    oCmd.Parameters.AddWithValue("@SinvienPhone", dataGridView1.Rows[i].Cells["phone"].Value.ToString());
                    oCmd.Parameters.AddWithValue("@SinhvienAddr", dataGridView1.Rows[i].Cells["add"].Value.ToString());
                    cnn.Open();
                    if(i == 0) dCmd.ExecuteNonQuery();
                    oCmd.ExecuteNonQuery();
                    cnn.Close();
                }
                MessageBox.Show("Update Success");
            }
        }

        private void view_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }
    }
}
