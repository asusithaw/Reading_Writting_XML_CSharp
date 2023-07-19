using System.Data;
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int n = dataGridView.Rows.Add();
            dataGridView.Rows[n].Cells[0].Value = txtId.Text;
            dataGridView.Rows[n].Cells[1].Value = txtName.Text;
            dataGridView.Rows[n].Cells[2].Value = txtAddress.Text;
            dataGridView.Rows[n].Cells[3].Value = txtAge.Text;
            EmptyTexts();
        }

        private void EmptyTexts()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtAddress.Text = "";
            txtAge.Text = "";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            dataGridView.SelectedRows[0].Cells[0].Value = txtId.Text;
            dataGridView.SelectedRows[0].Cells[1].Value = txtName.Text;
            dataGridView.SelectedRows[0].Cells[2].Value = txtAddress.Text;
            dataGridView.SelectedRows[0].Cells[3].Value = txtAge.Text;
            EmptyTexts();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.RemoveAt(dataGridView.SelectedRows[0].Index);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.TableName = "Labour";
            dt.Columns.Add("id");
            dt.Columns.Add("name");
            dt.Columns.Add("address");
            dt.Columns.Add("age");
            ds.Tables.Add(dt);

            foreach (DataGridViewRow r in dataGridView.Rows)
            {
                DataRow row = ds.Tables["Labour"].NewRow();
                row["id"] = r.Cells[0].Value;
                row["name"] = r.Cells[1].Value;
                row["address"] = r.Cells[2].Value;
                row["age"] = r.Cells[3].Value;
                ds.Tables["Labour"].Rows.Add(row);
            }

            ds.WriteXml("D:\\Labour.xml");
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml("D:\\Labour.xml");
            dataGridView.Rows.Clear();
            foreach (DataRow item in ds.Tables["Labour"].Rows)
            {
                int n = dataGridView.Rows.Add();
                dataGridView.Rows[n].Cells[0].Value = item[0];
                dataGridView.Rows[n].Cells[1].Value = item[1];
                dataGridView.Rows[n].Cells[2].Value = item[2];
                dataGridView.Rows[n].Cells[3].Value = item[3];
            }
        }

        private void dataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            txtId.Text = dataGridView.SelectedRows[0].Cells[0].Value.ToString();
            txtName.Text = dataGridView.SelectedRows[0].Cells[1].Value.ToString();
            txtAddress.Text = dataGridView.SelectedRows[0].Cells[2].Value.ToString();
            txtAge.Text = dataGridView.SelectedRows[0].Cells[3].Value.ToString();
        }
        
    }
}