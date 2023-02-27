using System;
using System.Net.Http;
using System.Windows.Forms;
using System.Drawing;
using Newtonsoft.Json;
using System.Net;

namespace NASA_By_Janar
{
    /*il prépare le terrain pour l'appel d'API à l'API NASA.*/
    public partial class Form1 : Form
    {
        private readonly HttpClient client = new HttpClient();
        private readonly string Key = "nwsFOLWrxqeIl0xofkX1kfqEpXhmx1SclEwkXCJd";
        private readonly string Image_Du_Jour = "https://api.nasa.gov/planetary/apod?api_key=";
        private readonly string all_planets = "https://api.nasa.gov/EPIC/api/natural/images?api_key=";

        public Form1()
        {
            InitializeComponent();

            var button1 = new Button
            {
                Text = "Img Jour"
            };
            button1.Click += (sender, args) => GetDataFromAPI(Image_Du_Jour);

            var button2 = new Button
            {
                Text = "API 2"
            };
            button2.Click += (sender, args) => GetDataFromAPI(all_planets);

            Controls.Add(button1);
            Controls.Add(button2);

            pictureBox1.Visible = false;
            label1.Visible = false;
            backButton.Visible = false;
        }

        private async void GetDataFromAPI(string apiUrl)
        {
            try
            {
                var jsonData = await client.GetStringAsync(apiUrl + Key);
                dynamic json = JsonConvert.DeserializeObject(jsonData);
                string imageUrl = json.url;
                string date = json.date;
                string title = json.title;
                string explanation = json.explanation;
                explanation = explanation.Replace(",", ",");

                var imageBytes = await client.GetByteArrayAsync(imageUrl);
                using (var memoryStream = new MemoryStream(imageBytes))
                {
                    var image = Image.FromStream(memoryStream);
                    pictureBox1.Image = image;
                }

                label1.Text = "Date: " + date + Environment.NewLine +
                              Environment.NewLine + "Title: " + title + Environment.NewLine + Environment.NewLine +
                              "Explanation: " + Environment.NewLine + " " + explanation;

                pictureBox1.Visible = true;
                label1.Visible = true;
                backButton.Visible = true;
            }
            catch (WebException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            label1.Visible = false;
            backButton.Visible = false;
        }
    }
}
