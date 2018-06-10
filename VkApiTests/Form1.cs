using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VkApi;
using VkApi.Methods;
using VkApi.Models;
using VkApi.Extensions;

namespace VkApiTests
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private const string __login = "";
        private const string __password = "";

        Vk VK = new Vk(__login, __password, Auth.Scope.all);

        private async void button1_Click(object sender, EventArgs e)
        {

            var response = await Net.Request<dAudio.Get>("audio.get", access_token: VK.getToken());

            if (response.error is null)
                Console.WriteLine("null");
        }

        private async void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
