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

        Vk VK = new Vk(__login, __password, Scope.all);

        private async void button1_Click(object sender, EventArgs e)
        {
            VK = new Vk(await VK.Auth.refreshToken());


            var response = await Net.Request<dAudio.Get>("audio.get");

            if (response.error is null)
                Console.WriteLine("Audio count: " + response.response.count);
            else
                Console.WriteLine(response.error.error_msg);
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            var response = await VK.Status.Set("memento mori");
            Console.WriteLine(response);
        }


    }
}
