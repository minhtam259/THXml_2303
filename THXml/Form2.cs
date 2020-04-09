using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using THXml;
using System.Xml;
using System.Xml.XPath;


namespace THXml
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadSinhVienToControl();
        }

        private void LoadSinhVienToControl()
        {
            dataGrid2.Rows.Clear();
            XmlDocument XmlSinhVien_View = SinhVienDBMng.GetDanhsachSinvien();
            XPathNavigator nav = XmlSinhVien_View.CreateNavigator();
            XPathNodeIterator nodes = nav.Select("//LINE");
            int r = 0;
            foreach (XPathNavigator v in nodes)
            {
                dataGrid2.Rows.Add();
                dataGrid2.Rows[r].Cells["id"].Value = v.SelectSingleNode("@SinhvienID").Value.ToString();
                dataGrid2.Rows[r].Cells["prkid"].Value = v.SelectSingleNode("@SinhvienPrkID").Value.ToString();
                dataGrid2.Rows[r].Cells["name"].Value = v.SelectSingleNode("@SinVienName").Value.ToString();
                dataGrid2.Rows[r].Cells["addr"].Value = v.SelectSingleNode("@SinhvienAddr").Value.ToString();
                ++r;
            }
        }

    }
}
