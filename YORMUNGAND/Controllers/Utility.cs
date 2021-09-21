using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using UserDataApi.Data.Models;

namespace YORMUNGAND.Controllers
{
    public static class Utility
    {
        public static UserData GetUserDataByDomainName(string sessionId, string domainName, out bool result)
        {
            UserData ud = new();
            try
            {
                WebRequest request = WebRequest.Create("http://ms-techrprg005:82/UserByDomainName?token=D5C989DA-22B9-41ED-8C6A-B60B3CC293AD&domainname=" + domainName + "&session_id=" + sessionId);
                request.Method = "POST"; // для отправки используется метод Post
                                         // данные для отправки
                string data = "token=D5C989DA-22B9-41ED-8C6A-B60B3CC293AD&phone=" + domainName + "&session_id=" + sessionId;
                // преобразуем данные в массив байтов
                byte[] byteArray = System.Text.Encoding.UTF8.GetBytes(data);
                // устанавливаем тип содержимого - параметр ContentType
                request.ContentType = "application/json; charset=utf-8";
                // Устанавливаем заголовок Content-Length запроса - свойство ContentLength
                request.ContentLength = byteArray.Length;

                //записываем данные в поток запроса
                using (Stream dataStream = request.GetRequestStream())
                {
                    dataStream.Write(byteArray, 0, byteArray.Length);
                }

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                using (Stream stream = response.GetResponseStream())
                {
                    using StreamReader reader = new(stream);
                    ud = JsonConvert.DeserializeObject<UserData>(reader.ReadToEnd().Replace("\n", ""));
                }
                result = response.StatusCode == HttpStatusCode.OK;
                response.Close();
            }
            catch (Exception)
            {
                result = false;
            }
            return ud;
        }
    }
}
