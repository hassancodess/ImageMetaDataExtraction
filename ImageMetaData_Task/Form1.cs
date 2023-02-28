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
using ExifLibrary;
using MetadataExtractor.Formats.Jpeg;
using ImageMagick;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Net.Mime.MediaTypeNames;
using System.Security.Policy;
using System.Net.Http.Headers;
using System.Net.Http;

namespace ImageMetaData_Task
{
    public partial class Form1 : Form
    {
        public string filePath;
        public string output = "C:\\Users\\Hassan\\Desktop\\images";
        public string outputImageName;
        public string outputFilePath;
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

            try
            {
                using (MagickImage image = new MagickImage(filePath))
                {
                    var profile = new ExifProfile();
                    profile.SetValue(ImageMagick.ExifTag.Copyright, "Dirk Lemstrajgjggfgfghfghf");

                    image.SetProfile(profile);

                    outputImageName = filePath.Split('\\').Last();
                    outputFilePath = $"{output}/{outputImageName}";

                    image.Write(outputFilePath);
                    MessageBox.Show("Metadata Inserted & New Image Created on Desktop/images");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    using (var image = ImageFile.FromFile(filePath))
            //    {
            //        var file = ImageFile.FromFile(filePath);
            //        // note the explicit cast to ushort
            //        //file.SetPropertyItem
            //        file.Properties.Set(ExifTag.UserComment, "AMNAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
            //        file.Save(filePath);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"ERROR - {ex.Message}");
            //}
        }

        private async void btn_postImage_Click(object sender, EventArgs e)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    // TODO: Set the base URL of your Web API
                    client.BaseAddress = new Uri($"{BaseURL.BASE_URL}/ImageMetaDataAPI/");

                    // TODO: Add any required headers (such as authentication headers)
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    // TODO: Create a new instance of the MultipartFormDataContent class to add the file to the request
                    var content = new MultipartFormDataContent();

                    // TODO: Add the file to the request
                    var fileContent = new ByteArrayContent(File.ReadAllBytes(outputFilePath));
                    //fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse("image/jpeg");
                    fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse("multipart/form-data");
                    content.Add(fileContent, "image", outputImageName);

                    // TODO: Send the request to the Web API
                    HttpResponseMessage response = await client.PostAsync("api/image/addimage", content);

                    MessageBox.Show("Uploaded");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
