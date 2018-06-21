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
using VkApi.Exeptions;

namespace VkApiTests
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Log.Create();
        }


        private const string __login = "";
        private const string __password = "";

        Vk VK = new Vk();

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var response = await VK.Audio.Get();
                Console.WriteLine("Audio count: " + response.response.count);

            }
            catch (AudioExeptions.TokenConfirmationRequired)
            {
                Console.WriteLine("refresh token needed");
                Console.WriteLine("refreshing...");
                VK = new Vk(await VK.Auth.RefreshToken());
                Console.WriteLine("done");
            }
            catch (CommonExeptions.AuthError)
            {
                Console.WriteLine("access_token needed");
                Console.WriteLine("authing...");

                if (await VK.Auth.Authorize(__login, __password))
                    Console.WriteLine("done");
                else
                    throw new Exception();
            }

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            var response = await VK.Status.Set("memento mori");
            Console.WriteLine(response);
        }


    }
}
