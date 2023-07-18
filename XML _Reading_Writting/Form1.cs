using System.Xml;
using System.Xml.Linq;

namespace XML__Reading_Writting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                MessageBox.Show("Please Fill the required field");
                txtSearch.Focus();
            }
            else
            {
                lstItems.Items.Clear();
                XmlDocument doc = new XmlDocument();
                doc.Load("STUDENTFile.xml");

                foreach (XmlElement node in doc.DocumentElement)
                {
                    string id = node.Attributes[0].InnerText;

                    if (id == txtSearch.Text)
                    {
                        foreach (XmlNode childNode in node.ChildNodes)
                        {
                            lstItems.Items.Add(childNode.InnerText);
                        }
                    }
                }
            }
        }

        public void ReadXMLWithXElements()
        {
            XElement xdoc = XElement.Load("STUDENTFile.xml");

            IEnumerable<XElement> students = xdoc.Elements();

            foreach (var student in students)
            {                
                lstItems.Items.Add(student.Element("name").Value);
                lstItems.Items.Add(student.Element("address").Value);
                lstItems.Items.Add(student.Element("age").Value);
            }
        }
        

        private void Form1_Shown(object sender, EventArgs e)
        {
            ReadXMLWithXElements();
        }
    }
}