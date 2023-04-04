using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using MetadataExtractor;
using System.Drawing.Imaging;


namespace ImageMetaData_Task
{
    public partial class Form2 : Form
    {
        public Image image;
        public string imageName;
        public string path = @"C:\Users\Hassan\Desktop\apiImages";
        public Form2()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private async void btn_getAllImageNames_Click(object sender, EventArgs e)
        {
            lv_imageNames.Clear();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri($"{BaseURL.BASE_URL}/ImageMetaDataAPI/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync("api/image/GetAllImageNames");

                if (response.IsSuccessStatusCode)
                {
                    // Read the response content as a string array
                    string responseData = await response.Content.ReadAsStringAsync();
                    string[] data = JsonConvert.DeserializeObject<string[]>(responseData);

                    // Populate the ListBox control with the names
                    foreach (string item in data)
                    {
                        ListViewItem listViewItem = new ListViewItem(item);
                        lv_imageNames.Items.Add(listViewItem);
                    }
                }
            }

        }

        private async void btn_fetchImage_Click(object sender, EventArgs e)
        {
            try
            {
                imageName = lv_imageNames.SelectedItems[0].Text;
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync($"{BaseURL.BASE_URL}/ImageMetaDataAPI/api/image/GetImage?imageName={imageName}");

                    if (response.IsSuccessStatusCode)
                    {
                        Stream stream = await response.Content.ReadAsStreamAsync();
                        image = Image.FromStream(stream);

                        // Display the image in a PictureBox control
                        pictureBox2.Image = image;

                        // Save the image to a file
                        image.Save($"{path}/{imageName}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_viewMetadata_Click(object sender, EventArgs e)
        {
            lv_imageMetaData.Clear();
            string row;
            IEnumerable<MetadataExtractor.Directory> directories = ImageMetadataReader.ReadMetadata($"{path}/{imageName}");
            foreach (var directory in directories)
            {
                foreach (var tag in directory.Tags)
                {
                    row = $"{directory.Name} - {tag.Name} = {tag.Description}";
                    lv_imageMetaData.Items.Add(row);
                }
            }
        }
    }
}
