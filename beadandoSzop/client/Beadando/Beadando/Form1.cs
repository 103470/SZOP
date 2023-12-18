using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using RestSharp;
using RestSharp.Serializers.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

namespace Beadando
{
    public partial class Form1 : Form
    {
        public const string serverPath = "http://localhost/beadandoSzop/";
        public static RestClient client;
        public bool loggedIn = false;
        public static string loggedInName = null;
        public static string loggedInPwd = null;
        public string Username = null;
        public string Password = null;


        public Form1()
        {
            InitializeComponent();

            client = new RestClient(Form1.serverPath);
            btnLogout.Visible = false;
        }



        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == MenuItemUsers && loggedIn)
            {
                RestRequest request = new RestRequest("szerver/users/index.php", Method.Get);
                request.RequestFormat = DataFormat.Json;
                request.AddJsonBody(new
                {
                    username = loggedInName,
                    password = loggedInPwd
                });
                RestResponse response = client.Execute(request);

                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show("Be kell jelentkeznie a használathoz!");
                    return;
                }
                RestResponse response1 = client.Execute<List<User>>(request);

                if (response1.Content.Contains("\"isAdmin\":\"1\""))
                {
                    Users userform = new Users();
                    userform.ShowDialog();
                }
            }
            else if (e.ClickedItem == MenuItemCars && loggedIn)
            {
                Cars carform = new Cars();
                carform.ShowDialog();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            RestRequest request = new RestRequest("szerver/users/index.php", Method.Get);
            request.RequestFormat = DataFormat.Json;

            Username = txtUsername.Text;
            //byte[] encodedPassword = new UTF8Encoding().GetBytes(txtPassword.Text);
            //byte[] md5Password = MD5.Create().ComputeHash(encodedPassword);
            //Password = Convert.ToHexString(md5Password);
            Password = txtPassword.Text;

            request.AddJsonBody(new
            {
                username = Username,
                password = Password
            });
            string a = Username;
            string b = Password;
            RestResponse response = client.Execute(request);

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("Login nem sikerült");
                return;
            }

            RestResponse response1 = client.Execute<List<User>>(request);


            if (response1.Content.Contains(a) && response1.Content.Contains(b))
            {
                groupBoxLogin.Visible = false;
                btnLogout.Visible = true;
                loggedIn = true;
                loggedInName = a;
                loggedInPwd = b;
            }
        }


        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            groupBoxLogin.Visible = true;
            btnLogout.Visible = false;
            loggedIn = false;
        }
    }
}
