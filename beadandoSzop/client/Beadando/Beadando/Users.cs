using Microsoft.VisualBasic.ApplicationServices;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using RestSharp;


namespace Beadando
{
    public partial class Users : Form
    {
       
        public Users()
        {
            InitializeComponent();
            ListUsers();

           
        }

        private void ListUsers()
        {
            RestRequest request = new RestRequest("szerver/users/index.php", Method.Get);
            request.RequestFormat = DataFormat.Json;

            RestResponse response = Form1.client.Execute(request);

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show(response.StatusDescription);
                return;
            }
            List<User> users = JsonSerializer.Deserialize<List<User>>(response.Content);
            dataGridView1.DataSource = users;
            //textBox1.Text=response1.ToString();

            /*dataGridView1.Rows.Clear();
            dataGridView1.DataSource = response1;*/
            /*foreach (User u in new JsonSerializer().Deserialize<List<User>>(response))
                dataGridView1.Rows.Add(u.Name);*/


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            labelId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtUsername.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPassword.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            RestRequest request = new RestRequest("szerver/users/index.php", Method.Post);
            request.RequestFormat = DataFormat.Json;

            request.AddJsonBody(new
            {
                username = txtUsername.Text,
                password = txtPassword.Text,
                name = txtName.Text,
                isAdmin = txtAdmin.Text
            });


            RestResponse response = Form1.client.Execute(request);

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show(response.StatusDescription);
                return;
            }

            ListUsers();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            RestRequest request = new RestRequest("szerver/users/index.php", Method.Delete);
            request.RequestFormat = DataFormat.Json;

            request.AddJsonBody(new
            {
                id = int.Parse(labelId.Text),
            });


            RestResponse response = Form1.client.Execute(request);

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show(response.StatusDescription);
                return;
            }

            ListUsers();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            RestRequest request = new RestRequest("szerver/users/index.php", Method.Put);
            request.RequestFormat = DataFormat.Json;

            request.AddJsonBody(new
            {
                id = int.Parse(labelId.Text),
                username = txtUsername.Text,
                password = txtPassword.Text,
                name = txtName.Text,
                isAdmin = txtAdmin.Text
            });


            RestResponse response = Form1.client.Execute(request);

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show(response.StatusDescription);
                return;
            }

            ListUsers();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
