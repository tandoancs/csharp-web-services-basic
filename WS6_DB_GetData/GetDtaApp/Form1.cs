using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Helpers;
using Newtonsoft.Json;

namespace GetDtaApp
{
    public partial class Form1 : Form
    {

        GetDtaApp.localhost.DataWS ws = new GetDtaApp.localhost.DataWS();
        HttpClient client = new HttpClient();

        public Form1()
        {
            InitializeComponent();
        }

        private void WebServiceSettings()
        {
            client.BaseAddress = new Uri("https://localhost:44318/DataWS.asmx");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WebServiceSettings();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string Id = TxtId.Text;
            if (Id.Length == 0 )
            {
                MessageBox.Show("Please input ID value to search");
            } else
            {
                string userItemJson = ws.DataTableForUsers(TxtId.Text);

                DataTable dtStudents = JsonConvert.DeserializeObject<DataTable>(userItemJson);
                DgvUsers.DataSource = dtStudents;
            }
            
        }

        private void BtnAllUsers_Click(object sender, EventArgs e)
        {
            string usersJson = ws.DataTableForUsers("");

            DataTable dtUsers = JsonConvert.DeserializeObject<DataTable>(usersJson);
            DgvUsers.DataSource = dtUsers;
        }
    }
}
