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

            //if (response.error != null)
            //    throw new CommonExeption.CommonApiExeption { error_code = response.error.error_code, error_description = response.error.error_msg };

            return response;
        }



    }
}
