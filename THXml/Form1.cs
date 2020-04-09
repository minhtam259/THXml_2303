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
using System.Xml.Linq;

namespace THXml
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void loaddata_Click(object sender, EventArgs e)
        {
            LoadSinhVienToControl();
        }

        private void themdata_Click(object sender, EventArgs e)
        {

            SinhVienDBMng.themsv(GetXDoc());
            LoadSinhVienToControl();
        }

        private void suadata_Click(object sender, EventArgs e)
        {

            SinhVienDBMng.suasv(GetXDoc());
            LoadSinhVienToControl();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            prktxt.Text = dataGridView1.SelectedRows[0].Cells["prkid"].Value.ToString();
            idtxt.Text = dataGridView1.SelectedRows[0].Cells["id"].Value.ToString();
            nametxt.Text = dataGridView1.SelectedRows[0].Cells["name"].Value.ToString();
            addtxt.Text = dataGridView1.SelectedRows[0].Cells["add"].Value.ToString();
        }

        private void xoadata_Click(object sender, EventArgs e)
        {
    
            SinhVienDBMng.xoasv(GetXDoc());
            LoadSinhVienToControl();

        }

        private XmlDocument GetXDoc()
        {
            XDocument xDoc = new XDocument(new XElement("BIZREQUEST",
                                    new XElement("DATAAREA",
                                        new XElement("VOUCHERS"))));
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(xDoc.CreateReader());
            XPathNavigator nav = xmlDoc.CreateNavigator();
            XElement header = new XElement("HEADER",
                 new XAttribute("SinhvienPrkID", prktxt.Text),
                 new XAttribute("SinhvienID", idtxt.Text),
                 new XAttribute("SinhvienName", nametxt.Text),
                 new XAttribute("SinhvienAddr", addtxt.Text),
                 new XAttribute("SinhvienEmail", emailtxt.Text),
                 new XAttribute("SinhvienPhone", phonetxt.Text));
            nav.SelectSingleNode("//VOUCHERS").AppendChild(header.CreateReader());

            return xmlDoc;
        }
        private void LoadSinhVienToControl()
        {
            dataGridView1.Rows.Clear();
            XmlDocument XmlSinhVien_View = SinhVienDBMng.GetDanhsachSinvien();
            XPathNavigator nav = XmlSinhVien_View.CreateNavigator();
            XPathNodeIterator nodes = nav.Select("//LINE");
            int r = 0;
            foreach (XPathNavigator v in nodes)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[r].Cells["id"].Value = v.SelectSingleNode("@SinhvienID").Value.ToString();
                dataGridView1.Rows[r].Cells["prkid"].Value = v.SelectSingleNode("@SinhvienPrkID").Value.ToString();
                dataGridView1.Rows[r].Cells["name"].Value = v.SelectSingleNode("@SinVienName").Value.ToString();
                dataGridView1.Rows[r].Cells["add"].Value = v.SelectSingleNode("@SinhvienAddr").Value.ToString();
                ++r;
            }
        }
    }
}
