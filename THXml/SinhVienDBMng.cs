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
        public static string connectionString = @"Data Source=TAM\SQLEXPRESS;Initial Catalog=XML2303;User ID=sa;Password=123";
        
        public static void themsv (XmlDocument tdoc )
        
        {
            XPathNavigator nav = tdoc.CreateNavigator();
            XPathNavigator headers = nav.SelectSingleNode("//HEADER");
            connectionString = @"Data Source=TAM\SQLEXPRESS;Initial Catalog=XML2303;User ID=sa;Password=123";
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();

                string SinhvienPrkID = headers.SelectSingleNode("//@SinhvienPrkID").Value;
                string SinhvienID = headers.SelectSingleNode("//@SinhvienID").Value;
                string SinhvienName = headers.SelectSingleNode("//@SinhvienName").Value;
                string SinhvienAddr = headers.SelectSingleNode("//@SinhvienAddr").Value;
                string SinhvienEmail = headers.SelectSingleNode("//@SinhvienEmail").Value;
                string SinhvienPhone = headers.SelectSingleNode("//@SinhvienPhone").Value;
                string oString = @"insert into Table_1 
                                    values(@SinhvienPrkID,@SinhvienID,@SinhvienName,@SinhvienAddr,@SinhvienEmail,@SinhvienPhone)";
                SqlCommand oCmd = new SqlCommand(oString, cnn);
                oCmd.Parameters.AddWithValue("@SinhvienPrkID", SinhvienPrkID);
                oCmd.Parameters.AddWithValue("@SinhvienID", SinhvienID);
                oCmd.Parameters.AddWithValue("@SinhvienName", SinhvienName);
                oCmd.Parameters.AddWithValue("@SinhvienAddr", SinhvienAddr);
                oCmd.Parameters.AddWithValue("@SinhvienEmail", SinhvienEmail);
                oCmd.Parameters.AddWithValue("@SinhvienPhone", SinhvienPhone);

                oCmd.ExecuteNonQuery();
                cnn.Close();
            }
        }
        public static void suasv (XmlDocument sdoc)
        {

            XPathNavigator nav = sdoc.CreateNavigator();
            XPathNavigator headers = nav.SelectSingleNode("//HEADER");
            string connetionString = null;
            connetionString = @"Data Source=TAM\SQLEXPRESS;Initial Catalog=XML2303;User ID=sa;Password=123";
            using (SqlConnection cnn = new SqlConnection(connetionString))
            {
                string SinhvienPrkID = headers.SelectSingleNode("//@SinhvienPrkID").Value;
                string SinhvienID = headers.SelectSingleNode("//@SinhvienID").Value;
                string SinhvienName = headers.SelectSingleNode("//@SinhvienName").Value;
                string SinhvienAddr = headers.SelectSingleNode("//@SinhvienAddr").Value;
                string SinhvienEmail = headers.SelectSingleNode("//@SinhvienEmail").Value;
                string SinhvienPhone = headers.SelectSingleNode("//@SinhvienPhone").Value;
                string oString = @"Update Table_1 set 
                                        Name = @SinhvienName, Address = @SinhvienAddr, Email = @SinhvienEmail
                                        ,Phone = @SinhvienPhone
                                        where ID = @SinhvienID and PrkID = @SinhvienPrkID";
                SqlCommand oCmd = new SqlCommand(oString, cnn);
                oCmd.Parameters.AddWithValue("@SinhvienPrkID", SinhvienPrkID);
                oCmd.Parameters.AddWithValue("@SinhvienID", SinhvienID);
                oCmd.Parameters.AddWithValue("@SinhvienName", SinhvienName);
                oCmd.Parameters.AddWithValue("@SinhvienAddr", SinhvienAddr);
                oCmd.Parameters.AddWithValue("@SinhvienEmail", SinhvienEmail);
                oCmd.Parameters.AddWithValue("@SinhvienPhone", SinhvienPhone);
                cnn.Open();
                oCmd.ExecuteNonQuery();
                cnn.Close();
            }

        }
        public static void xoasv (XmlDocument xdoc)
        {
            
            XPathNavigator nav = xdoc.CreateNavigator();
            XPathNavigator headers = nav.SelectSingleNode("//HEADER");
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                string SinhvienPrkID = headers.SelectSingleNode("//@SinhvienPrkID").Value;
                SqlCommand oCmd = new SqlCommand();
                oCmd.Connection = cnn;
                oCmd.CommandType = System.Data.CommandType.Text;
                oCmd.CommandTimeout = 300;
                string oString = String.Format("DELETE FROM Table_1 Where PrkID = @SinhvienPrkID");
                oCmd.Parameters.AddWithValue("@SinhvienPrkID", SinhvienPrkID);
                oCmd.CommandText = oString;
                cnn.Open();
                oCmd.ExecuteNonQuery();
                cnn.Close();
            }
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
            connetionString = @"Data Source=TAM\SQLEXPRESS;Initial Catalog=XML2303;User ID=sa;Password=123";
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
