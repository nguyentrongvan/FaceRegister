using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace FaceRegister.FaceMoudule
{
    class RegisterMaster
    {
        public static  async Task APIRegistMaster(string base64Image)
        {
            HttpClient api_client = new HttpClient();
            api_client.BaseAddress = new Uri("http://192.168.1.53:8888");
            api_client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            string json = System.Text.Json.JsonSerializer.Serialize(new
            {
                img = base64Image,
                model = "Facenet512"
            });


            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var result = await api_client.PostAsync("/face_register/apiv1/represent", content);
            if (result.IsSuccessStatusCode)
            {
                string resultContent = await result.Content.ReadAsStringAsync();
                JObject data = JObject.Parse(resultContent);
                if ((string)data["code"] == "0")
                {
                   
                }
                else
                {
                    Console.WriteLine((string)data["message"]);
                }
            }
        }
    }
}
