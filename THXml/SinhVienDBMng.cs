using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;
using THXml;
using System.Data.SqlClient;

namespace THXml
{
    class SinhVienDBMng
    {
        public static string path = @"E:\WFC#\THXml\THXml\bin\Debug\XmlSinhVien_ADD_EDIT_DEL.xml";
        public static void Themsinhvien(XmlDocument xmlDoc)
        {
            XPathNavigator sv = xmlDoc.CreateNavigator();
            XmlDocument xmlFile = new XmlDocument();
            xmlFile.Load(path);
            XPathNavigator nav = xmlFile.CreateNavigator();
            nav.SelectSingleNode("//VOUCHERS").AppendChild(sv.SelectSingleNode("HEADER"));
            xmlFile.Save(path);
            string xml = nav.SelectSingleNode("//VOUCHERS").InnerXml.ToString();
            string connetionString = null;
            connetionString = "Data Source=.;Initial Catalog=;User ID=sa;Password=123";
            using (SqlConnection cnn = new SqlConnection(connetionString))
            {

                string oString = @"Update Table_1 set DATA = @xml";
                SqlCommand oCmd = new SqlCommand(oString, cnn);
                oCmd.Parameters.AddWithValue("@xml", xml);
                cnn.Open();
                oCmd.ExecuteNonQuery();
                cnn.Close();
            }
        }


        public static void themsv (sinhvien tdoc )
        
        {
            XElement eml = new XElement(new XElement("HEADER", 
                                                new XAttribute("SinhvienPrkID",tdoc.PrkId),
                                                new XAttribute("SinhvienID",tdoc.Id),
                                                new XAttribute("SinVienName",tdoc.Name),
                                                new XAttribute("SinvienEmail",tdoc.Email),
                                                new XAttribute("SinvienPhone",tdoc.Phone),
                                                new XAttribute("SinhvienAddr",tdoc.Addr)));
            XmlDocument doc = new XmlDocument();
            doc.Load(@"E:\WFC#\THXml\THXml\bin\Debug\XmlSinhVien_ADD_EDIT_DEL.xml");
            XPathNavigator nav = doc.CreateNavigator();
            nav.SelectSingleNode(@"BIZREQUEST/DATAAREA/VOUCHERS[last()]").AppendChild(eml.ToString());
            doc.Save(@"E:\WFC#\THXml\THXml\bin\Debug\XmlSinhVien_ADD_EDIT_DEL.xml");
        }
        public static void suasv (sinhvien sdoc)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"E:\WFC#\THXml\THXml\bin\Debug\XmlSinhVien_ADD_EDIT_DEL.xml");
            XPathNavigator nav = doc.CreateNavigator();
            XPathNavigator sv = nav.SelectSingleNode($"BIZREQUEST/DATAAREA/VOUCHERS/HEADER[@SinhvienPrkID='{sdoc.PrkId}']");
            sv.SelectSingleNode("@SinhvienID").SetValue(sdoc.Id);
            sv.SelectSingleNode("@SinVienName").SetValue(sdoc.Name);
            sv.SelectSingleNode("@SinvienEmail").SetValue(sdoc.Email);
            sv.SelectSingleNode("@SinvienPhone").SetValue(sdoc.Phone);
            sv.SelectSingleNode("@SinhvienAddr").SetValue(sdoc.Addr);
            doc.Save(@"E:\WFC#\THXml\THXml\bin\Debug\XmlSinhVien_ADD_EDIT_DEL.xml");

        }
        public static void xoasv (sinhvien xdoc)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"E:\WFC#\THXml\THXml\bin\Debug\XmlSinhVien_ADD_EDIT_DEL.xml");
            XPathNavigator nav = doc.CreateNavigator();
            XPathNavigator sv = nav.SelectSingleNode($"BIZREQUEST/DATAAREA/VOUCHERS/HEADER[@SinhvienPrkID='{xdoc.PrkId}']");
            sv.DeleteSelf();
            doc.Save(@"E:\WFC#\THXml\THXml\bin\Debug\XmlSinhVien_ADD_EDIT_DEL.xml");
        }

        public static XmlDocument GetDanhsachSinvien()
        {
            XmlDocument xmlDoc = new XmlDocument();
            XDocument xml = new XDocument(new XDeclaration("1.0","utf-8",null),
                                          new XElement("BIZREQUEST",
                                              new XElement("DATAAREA",
                                                 new XElement("VOUCHERS",
                                                    new XElement("VLINES")
                                          ))));
            xmlDoc.LoadXml(xml.ToString());
            XPathNavigator nav = xmlDoc.CreateNavigator();

            string connetionString = null;
            connetionString = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=XML2303;User ID=sa;Password=123";
            using (SqlConnection cnn = new SqlConnection(connetionString))
            {
                string oString = "select * from Table_1";
                SqlCommand oCmd = new SqlCommand(oString, cnn);
                cnn.Open();
                using (SqlDataReader oReader = oCmd.ExecuteReader())
                {

                    while (oReader.Read())
                    {
                        XDocument eml = new XDocument( new XElement("LINE",
                                            new XAttribute("SinhvienPrkID",oReader["PrkID"].ToString()),
                                            new XAttribute("SinhvienID", oReader["ID"].ToString()),
                                            new XAttribute("SinVienName", oReader["Name"].ToString()),
                                            new XAttribute("SinhvienAddr", oReader["Address"].ToString())
                                                    ));
                        XPathNavigator e = eml.CreateNavigator();
                        nav.SelectSingleNode("//VLINES").AppendChild(e.SelectSingleNode("//LINE"));
                    }

                   cnn.Close();
               }
            }
            
            return xmlDoc;
        }
    }
}
