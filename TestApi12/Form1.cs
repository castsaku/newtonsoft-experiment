using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApi12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var baseAddress = new Uri("http://yugiohprices.com/api/");

            using (var httpClient = new HttpClient { BaseAddress = baseAddress })
            {

                using (var response = await httpClient.GetAsync("card_data/Dark Magician"))
                {

                    string responseData = await response.Content.ReadAsStringAsync();

                    var data = JsonConvert.DeserializeObject<Item>(responseData);

                    Data dataVar = new Data();

                    Item item = new Item();

                    item.data = dataVar;

                    item.data.name = data.data.name;

                    label1.Text = data.data.name;
                }
            }

            var baseAddress2 = new Uri("https://en.wikipedia.org/w/api.php");

            using (var httpClient2 = new HttpClient { BaseAddress = baseAddress2 })
            {
                var url = "https://en.wikipedia.org/w/api.php";
                url = url + "?origin=*";
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
