using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ImageMetaData_Task
{
    public partial class Form1 : Form
    {
        public string filePath;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_chooseImage_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pictureBox.Image = new Bitmap(open.FileName);
                // image file path  
                filePath = open.FileName;
            }
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            Image image = Image.FromFile(filePath);
            PropertyItem[] propertyItems = image.PropertyItems;
            foreach (PropertyItem propertyItem in propertyItems)
            {
                string row = $"Id: {propertyItem.Id}, Type: {propertyItem.Type}, Value: {Encoding.ASCII.GetString(propertyItem.Value)}";
                lv_metadate.Items.Add(row);

                //lv_metadate.Items.Add($"Id: {propertyItem.Id},");
                //lv_metadate.Items.Add($"Type: {propertyItem.Type},");
                //lv_metadate.Items.Add($"Value: {Encoding.ASCII.GetString(propertyItem.Value)},");

                //Console.WriteLine($"Id: {propertyItem.Id}, Type: {propertyItem.Type}, Value: {Encoding.ASCII.GetString(propertyItem.Value)}");
            }
            image.Dispose();


        }
    }
}
