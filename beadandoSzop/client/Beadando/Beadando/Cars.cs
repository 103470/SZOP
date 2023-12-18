using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;
using RestSharp;
using RestSharp.Serializers;
using RestSharp.Serializers.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Beadando
{
    public partial class Cars : Form
    {
        Car car = null;

        public Cars()
        {
            InitializeComponent();
            ListCars();


        }

        private void ListCars()
        {
            RestRequest request = new RestRequest("szerver/cars/index.php", Method.Get);
            request.RequestFormat = DataFormat.Json;

            RestResponse response = Form1.client.Execute(request);

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show(response.StatusDescription);
                return;
            }

            List<Car> cars = JsonSerializer.Deserialize<List<Car>>(response.Content);

            dataGridView1.DataSource = cars;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            RestRequest request = new RestRequest("szerver/cars/index.php", Method.Delete);
            request.RequestFormat = DataFormat.Json;

            request.AddJsonBody(new
            {
                id = labelId.Text
            });


            RestResponse response = Form1.client.Execute(request);

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show(response.StatusDescription);
                return;
            }

            ListCars();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            RestRequest request = new RestRequest("szerver/cars/index.php", Method.Post);
            request.RequestFormat = DataFormat.Json;

            request.AddJsonBody(new
            {
                marka = txtMarka.Text,
                tipus = txtTipus.Text,
                evjarat = txtEvjarat.Text,
                kivitel = txtKivitel.Text,
                uzemanyag = txtUzemanyag.Text,
                ar = txtAr.Text

            });


            RestResponse response = Form1.client.Execute(request);

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show(response.StatusDescription);
                return;
            }

            ListCars();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            RestRequest request = new RestRequest("szerver/cars/index.php", Method.Put);
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(new
            {
                id = int.Parse(labelId.Text),
                marka = txtMarka.Text,
                tipus = txtTipus.Text,
                evjarat = txtEvjarat.Text,
                kivitel = txtKivitel.Text,
                uzemanyag = txtUzemanyag.Text,
                ar = txtAr.Text,
                username = Form1.loggedInName,
                password = Form1.loggedInPwd
            });


            RestResponse response = Form1.client.Execute(request);

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show(response.StatusDescription);
                return;
            }

            ListCars();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            labelId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtMarka.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtTipus.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtEvjarat.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtKivitel.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtUzemanyag.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtAr.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }
    }
}
