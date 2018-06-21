using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VkApi.Exeptions;
using VkApi.Models;

namespace VkApi.Methods
{
    public class Audio
    {

        public async Task<dAudio.Get> Get()
        {
            var response = await Net.Request<dAudio.Get>("audio.get", new System.Collections.Specialized.NameValueCollection
            {

            });

            if (response.error != null)
            {
                switch (response.error.error_code)
                {
                    case 25:
                        throw new AudioExeptions.TokenConfirmationRequired(response.error.error_code, response.error.error_msg);

                    case 19:
                        throw new AudioExeptions.ContentBlocked(response.error.error_code, response.error.error_msg);
                }
            }



            return response;
        }



    }
}
