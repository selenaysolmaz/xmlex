using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Xml;
using System.Xml.XPath;

namespace XMLVeriIslemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string dosyaYolu = Application.StartupPath + "\\CalisanListesi.xml";

        const string veritabani = @"Data Source=PC-402;Initial Catalog=Northwind;Integrated Security=True";

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri(dosyaYolu);
        }

        private void btnVeriOku_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml(dosyaYolu);
            dataGridView1.DataSource = ds.Tables[0];
            webBrowser1.Url = new Uri(dosyaYolu);
        }

        private void btnVeriBul_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(dosyaYolu);
            XmlNode secilenNode = xmlDoc.ChildNodes[1]; // ile calısanlaa ulasır alttaki döngüdede calısanların bilgileirini alır. yani calısanlarda döner döngü.
            bool bulundu = false;
            foreach (XmlNode item in secilenNode)
            {
                if (item.ChildNodes[0].InnerText == "Can" || item.Attributes["TCNo"].Value == "12345678901")
                {
                    MessageBox.Show("Aranan kisi foreach yaprak bulundu: \n\n" + item.ChildNodes[0].InnerText + " " + item.ChildNodes[1].InnerText + "\n" + item.ChildNodes[2].InnerText + "\n" + "TCNo : " + item.Attributes["TCNo"].Value);
                    bulundu = true;
                    break;
                }
            }
            if (!bulundu)
            {
                MessageBox.Show("Aranan kisi 'Can' bulunamadı.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            webBrowser1.Url = new Uri(dosyaYolu);
        }

        private void btnXPathileTekBul_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(dosyaYolu);
            XmlNode secilenNode = xmlDoc.SelectSingleNode("Calisanlar/Calisan[Adi='Melek']");
            //XmlNode secilenNode = xmlDoc.SelectSingleNode("Calisanlar/Calisan[@TCNo=12345678902]");

            if (secilenNode != null)
            {
                MessageBox.Show("Aranan kisi XPath ile kolayca bulundu:\n\n"
                    + secilenNode.ChildNodes[0].InnerText + " "
                    + secilenNode.ChildNodes[1].InnerText + "\n"
                    + secilenNode.ChildNodes[2].InnerText + "\n"
                    + "TCNo: " + secilenNode.Attributes["TCNo"].Value);
            }
            else
            {
                MessageBox.Show("Aranan kisi 'Melek' bulunamadi.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            webBrowser1.Url = new Uri(dosyaYolu);

        }

        private void btnXPathileVerileriBul_Click(object sender, EventArgs e)
        {
            XPathDocument xmlDoc = new XPathDocument(dosyaYolu);
            XPathNavigator xNav = xmlDoc.CreateNavigator();
            XPathNodeIterator secilenNode = xNav.Select("Calisanlar/Calisan/Adi");

            string metin = "";
            while (secilenNode.MoveNext())
            {
                if (secilenNode.Current.InnerXml.StartsWith("C")) metin += secilenNode.Current.InnerXml + "\n";
            }

            if (metin != "")
            {
                MessageBox.Show("adi c ile baslayanlar: \n\n" + metin);

            }
            else
            {
                MessageBox.Show("adi c ile baslayan bulunamadı ");
                webBrowser1.Url = new Uri(dosyaYolu);
            }

        }

        private void btnVeriDegistir_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(dosyaYolu);
            XmlNode secilenNode = xmlDoc.SelectSingleNode("Calisanlar/Calisan[Adi='Melek']");
            if (secilenNode != null)
            {
                //soyadına ekle
                secilenNode.ChildNodes[1].InnerText += "galipler";
                xmlDoc.Save(dosyaYolu);

                MessageBox.Show("soyada ekleme yapıldı. \n\n"
                    + secilenNode.ChildNodes[0].InnerText + " " + secilenNode.ChildNodes[1].InnerText);

            }
            else
            {

                MessageBox.Show("aranan kişi melek bulunamadı.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            webBrowser1.Url=new Uri(dosyaYolu);
        }

        private void btnXMLVeriSil_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(dosyaYolu);
            XmlNode secilenNode = xmlDoc.SelectSingleNode("Calisanlar/Calisan[Adi='Melek']");
            if (secilenNode != null)
            {
                xmlDoc.DocumentElement.RemoveChild(secilenNode);
                xmlDoc.Save(dosyaYolu);
                MessageBox.Show("melek dosyadan silindi");
            }
            else
            {
                MessageBox.Show("aranan kisi melek bulunamadı.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            webBrowser1.Url = new Uri(dosyaYolu);
        }

        private void btnAddChild_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(dosyaYolu);
            XmlElement yeniEleman = xmlDoc.CreateElement("Calisan");

            XmlAttribute attrTCNo = xmlDoc.CreateAttribute("TCNo");
            attrTCNo.Value = "12345678904";
            yeniEleman.Attributes.Append(attrTCNo);

            XmlNode xAdi = xmlDoc.CreateElement("Adi");
            xAdi.InnerText = "Buse";
            yeniEleman.AppendChild(xAdi);

            XmlNode xSoyadi = xmlDoc.CreateElement("Soyadi");
            xSoyadi.InnerText = "Zengin";
            yeniEleman.AppendChild(xSoyadi);

            xmlDoc.DocumentElement.AppendChild(yeniEleman);

            xmlDoc.Save(dosyaYolu);

            MessageBox.Show(" 'Buse' eklendi. ");

            webBrowser1.Url=new Uri(dosyaYolu);

        }

        private void btnSQLtoXML_Click(object sender, EventArgs e)
        {
            SqlConnection cnm = new SqlConnection(veritabani);
            SqlDataAdapter adp = new SqlDataAdapter("select * from products", cnm);
            DataTable dt = new DataTable("Products");
            adp.Fill(dt);
            DataSet ds = new DataSet("Products");
            ds.Tables.Add(dt);

           // string dosya=Application.StartupPath+\\SQLtoXML.xml";

            FolderBrowserDialog fd = new FolderBrowserDialog();
            DialogResult dr = fd.ShowDialog();
            if (dr != DialogResult.OK)
                return;
            string dosya = fd.SelectedPath + "\\SQLtoXML.xml";

            ds.WriteXml(dosya);
            MessageBox.Show("SQL den gelen veriler XML dosyasına yazıldı.\n " + dosya);
            webBrowser1.Url = new Uri(dosya);


        }

        private void btnXMLtoSQL_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fd = new FolderBrowserDialog();
            DialogResult dr = fd.ShowDialog();
            if(dr == DialogResult.OK)
            {
                string dosya=fd.SelectedPath+ "\\SQLtoXML.xml";
                if (File.Exists(dosya))
                {
                    SqlConnection cnn = new SqlConnection(veritabani);
                    SqlDataAdapter adp = new SqlDataAdapter("select * from ProductsX", cnn);
                    SqlCommandBuilder cb = new SqlCommandBuilder(adp);
                    DataSet ds = new DataSet();
                    ds.ReadXml(dosya);
                    adp.Update(ds.Tables[0]);

                    MessageBox.Show("xml den okunan veriler ProductsX tablosuna kaydedildi.");
                    webBrowser1.Url = new Uri(dosya);
                }
                else
                {
                    MessageBox.Show("dosya bulunamadı \n" + dosya,"", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnSchemaOlustur_Click(object sender, EventArgs e)
        {


        }

        private void btnSQLdenSchema_Click(object sender, EventArgs e)
        {


        }

        private void btnXMLSchemaDogrula_Click(object sender, EventArgs e)
        {


        }


    }
}
