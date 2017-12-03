using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace ts
{
    public partial class Form1 : Form
    {
        DataTable table;
        public Form1()
        {
            InitializeComponent();
            
     
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string json = System.IO.File.ReadAllText(@"C:\Users\svt\source\repos\ts\data.json");
            var settings = new JsonSerializerSettings
            {
                Converters = new[] { new RecordDataTableConverter() },
            };

            var main_table = JsonConvert.DeserializeObject<Product_List>(json);
            table = JsonConvert.DeserializeObject<DataTable>(json, settings);
            db_table.DataSource = main_table.products;

            txt.Text = table.Rows[0]["processor"].ToString();
            txt2.Text = table.Rows[0]["clock_frequency"].ToString();
            txt3.Text = table.Rows[0]["NumberOfCores"].ToString();
            txt4.Text = table.Rows[0]["socket"].ToString();
            txt5.Text = table.Rows[0]["Form_fac_Case"].ToString();
            txt6.Text = table.Rows[0]["type_ram"].ToString();
            txt7.Text = table.Rows[0]["volume_ram"].ToString();
            txt8.Text = table.Rows[0]["frequency_ram"].ToString();
            txt9.Text = table.Rows[0]["volume_hdd"].ToString();
            txt10.Text = table.Rows[0]["videocarta"].ToString();
            txt11.Text = table.Rows[0]["volume_video"].ToString();
            txt12.Text = table.Rows[0]["PowerSupply"].ToString();
        }
        public class RecordDataTableConverter : Newtonsoft.Json.Converters.DataTableConverter
        {
            public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null)
                    return null;
                if (reader.TokenType == JsonToken.StartObject)
                {
                    var token = JToken.Load(reader);
                    token = new JArray(token.SelectTokens("products[*].characteristics"));
                    using (var subReader = token.CreateReader())
                    {
                        while (subReader.TokenType == JsonToken.None)
                            subReader.Read();
                        return base.ReadJson(subReader, objectType, existingValue, serializer); // Use base class to convert
                    }
                }
                else
                {
                    return base.ReadJson(reader, objectType, existingValue, serializer);
                }
            }
        }

        class Product
        {
            [JsonProperty ("name")]
            public string name { get; set; }
            [JsonProperty("url")]
            public string url { get; set; }
            [JsonProperty("price")]
            public string price { get; set; }
            [JsonProperty("type")]
            public string type { get; set; }
        }
        class Product_List
        {
            public List<Product> products { get; set; }

        }

        private void db_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = db_table.CurrentRow.Index;
            txt.Text = table.Rows[i]["processor"].ToString();
            txt2.Text = table.Rows[i]["clock_frequency"].ToString();
            txt3.Text = table.Rows[i]["NumberOfCores"].ToString();
            txt4.Text = table.Rows[i]["socket"].ToString();
            txt5.Text = table.Rows[i]["Form_fac_Case"].ToString();
            txt6.Text = table.Rows[i]["type_ram"].ToString();
            txt7.Text = table.Rows[i]["volume_ram"].ToString();
            txt8.Text = table.Rows[i]["frequency_ram"].ToString();
            txt9.Text = table.Rows[i]["volume_hdd"].ToString();
            txt10.Text = table.Rows[i]["videocarta"].ToString();
            txt11.Text = table.Rows[i]["volume_video"].ToString();
            txt12.Text = table.Rows[i]["PowerSupply"].ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
