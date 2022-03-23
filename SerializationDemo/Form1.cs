using System;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;




namespace SerializationDemo
{
    public partial class SerializForm : Form
    {
        public SerializForm()
        {
            InitializeComponent();
        } 
        
                
        private void btnBianryWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Department dept = new Department();
                dept.Id = Convert.ToInt32(txtId.Text);
                dept.Name = txtName.Text;
                dept.Location = txtLocation.Text;
                FileStream fs = new FileStream(@"E:\DeptBinary.dat", FileMode.Create, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, dept);
                fs.Close();
                MessageBox.Show("file added");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnBianryRead_Click(object sender, EventArgs e)
        {
            try
            {
                Department dept = new Department();
                FileStream fs = new FileStream(@"E:\DeptBinary.dat", FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                dept = (Department)bf.Deserialize(fs);
                txtId.Text = dept.Id.ToString();
                txtName.Text = dept.Name;
                txtLocation.Text = dept.Location;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnXmlWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Department dept = new Department();
                dept.Id = Convert.ToInt32(txtId.Text);
                dept.Name = txtName.Text;
                dept.Location = txtLocation.Text;
                FileStream fs = new FileStream(@"E:\DeptXml.xml", FileMode.Create, FileAccess.Write);
                XmlSerializer xml = new XmlSerializer(typeof(Department));
                xml.Serialize(fs, dept);
                fs.Close();
                MessageBox.Show("file added");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnXmlRead_Click(object sender, EventArgs e)
        {
            try
            {
                Department dept = new Department();
                FileStream fs = new FileStream(@"E:\DeptXml.xml", FileMode.Open, FileAccess.Read);
                XmlSerializer xml = new XmlSerializer(typeof(Department));
                dept = (Department)xml.Deserialize(fs);
                txtId.Text = dept.Id.ToString();
                txtName.Text = dept.Name;
                txtLocation.Text = dept.Location;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSoapWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Department dept = new Department();
                dept.Id = Convert.ToInt32(txtId.Text);
                dept.Name = txtName.Text;
                dept.Location = txtLocation.Text;
                FileStream fs = new FileStream(@"E:\DeptSoap.soap", FileMode.Create, FileAccess.Write);
                SoapFormatter sf = new SoapFormatter();
                sf.Serialize(fs, dept);
                fs.Close();
                MessageBox.Show("file added");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void btnSoapRead_Click(object sender, EventArgs e)
        {
            try
            {
                Department dept = new Department();
                FileStream fs = new FileStream(@"E:\DeptSoap.soap", FileMode.Open, FileAccess.Read);
                SoapFormatter sf = new SoapFormatter();
                dept = (Department)sf.Deserialize(fs);
                txtId.Text = dept.Id.ToString();
                txtName.Text = dept.Name;
                txtLocation.Text = dept.Location;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnJsonwrite_Click(object sender, EventArgs e)
        {
            try
            {
                Department dept = new Department();
                dept.Id = Convert.ToInt32(txtId.Text);
                dept.Name = txtName.Text;
                dept.Location = txtLocation.Text;
                FileStream fs = new FileStream(@"E:\Dept.Json", FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize(fs, dept);
                fs.Close();
                MessageBox.Show("file added");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnJsonRead_Click(object sender, EventArgs e)
        {
            try
            {
                Department dept = new Department();
                FileStream fs = new FileStream(@"E:\Dept.Json", FileMode.Open, FileAccess.Read)
                {

                };
                dept = JsonSerializer.Deserialize<Department>(fs);
                txtId.Text = dept.Id.ToString();
                txtName.Text = dept.Name;
                txtLocation.Text = dept.Location;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

   
    
}
