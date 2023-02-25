using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.IO;
using System.Windows.Media.Imaging;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetadataExtractor;
using MetadataExtractor.Formats.Exif;
using MetadataExtractor.IO;
//using System.Drawing.Imaging;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MetadataExtractor.Formats.Jpeg;
using ExifLibrary;

namespace ImageMetaData_Task
{
    public partial class Form1 : Form
    {
        public string filePath;
        public string output = "C:\\Users\\Hassan\\Desktop";
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
            lv_metadate.Clear();
            string row;
            IEnumerable<MetadataExtractor.Directory> directories = ImageMetadataReader.ReadMetadata(filePath);
            foreach (var directory in directories)
            {
                foreach (var tag in directory.Tags)
                {
                    row = $"{directory.Name} - {tag.Name} = {tag.Description}";
                    lv_metadate.Items.Add(row);
                }
            }

        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            //Values
            //string people = txt_people.Text;
            //string events = txt_event.Text;
            ////float lat = float.Parse(txt_lat.Text);
            //float lng = float.Parse(txt_long.Text);
            //DateTime date = dtp.Value;
            try
            {
                var file = ImageFile.FromFile(filePath);
                // note the explicit cast to ushort
                file.Properties.Set(ExifTag.UserComment, "Amna & Hassan");
                file.Save($"{output}/newImage.jpg");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR - {ex.Message}" );
            }


        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                var file = ImageFile.FromFile(filePath);
                // note the explicit cast to ushort
                file.Properties.Set(ExifTag.UserComment, "AMNAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
                file.Save($"{output}/newImages.jpg");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR - {ex.Message}");
            }
        }
    }
}
