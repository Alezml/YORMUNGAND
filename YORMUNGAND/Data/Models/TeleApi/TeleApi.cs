using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using YORMUNGAND.Data.Repository;
using YORMUNGAND.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using TeleSharp.TL;
using TeleSharp.TL.Messages;
using TLSharp.Core;
using System.IO;
using System.Net.NetworkInformation;
using System.Net;
using System.Text;

namespace YORMUNGAND.Data.Models
{
    public class TeleApi
    {

        private string hash;
        private string code;
        private readonly AppDBContent appDBContent;
        private TeleApiRepository _tarep;
        public TeleApi(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
            _tarep = new TeleApiRepository(appDBContent);
        }
        private static string GET(string Url, string Data)
        {
            System.Net.WebRequest req = System.Net.WebRequest.Create(Url + "?" + Data);
            System.Net.WebResponse resp = req.GetResponse();
            System.IO.Stream stream = resp.GetResponseStream();
            System.IO.StreamReader sr = new System.IO.StreamReader(stream);
            string Out = sr.ReadToEnd();
            sr.Close();
            return Out;
        }
        public async Task SendMsg(string msg)
        {
            try
            {
                //string XX = TeleApi.GET("https://vk.com/", "");
                //File.WriteAllText(@"C:\inetpub\pilot\123.txt", XX);
                IPStatus status = IPStatus.TimedOut;
                string response = "";
                try
                {
                    string url = "https://vk.com/";

                    using (var webClient = new WebClient())
                    {
                        webClient.Credentials = CredentialCache.DefaultCredentials;

                        IWebProxy proxy = new WebProxy(new Uri("http://ms-mwgsrv001.bee.vimpelcom.ru:9090"), true);
                        proxy.Credentials = CredentialCache.DefaultCredentials;
                        webClient.Proxy = proxy;
                        webClient.UseDefaultCredentials = true;

                        response = webClient.DownloadString(url);//, "C:\\Users\\LKarachevtsev\\Desktop\\1.txt");
                    }
                    
                }
                catch (Exception ex){
                    _tarep.WriteError("1" +ex.Message + CredentialCache.DefaultNetworkCredentials.UserName);
                }
                if (status != IPStatus.Success)
                {
                    _tarep.WriteError("2 " + CredentialCache.DefaultNetworkCredentials.UserName);
                }
                else
                {
                    _tarep.WriteError("3 " + CredentialCache.DefaultNetworkCredentials.UserName);
                }
                

                var session = new FileSessionStore();
                var client = new TelegramClient(5998269, "0db150b3ba23c7511628894e05f7e442", session, "session");
                await client.ConnectAsync();

                //Console.WriteLine(client.IsConnected);
                //Console.WriteLine(client.IsUserAuthorized());
                if (_tarep.IsNeedNewHash())
                {
                    hash = await client.SendCodeRequestAsync("79611591619");
                    _tarep.AddNewHash(hash);
                }
                bool x = await _tarep.CodeIsExist();
                if (x)
                {
                    hash = _tarep.GetHash();
                    code = _tarep.GetCode();
                    var user = await client.MakeAuthAsync("79611591619", hash, code);
                    var result = await client.GetContactsAsync();

                    //get user dialogs
                    var dialogs = (TLDialogs)await client.GetUserDialogsAsync();

                    var atray = new List<string>();
                    foreach (var item in dialogs.Chats)
                    {
                        if (item.GetType() == typeof(TLChannel))
                        {
                            atray.Add(((TLChannel)item).Title);
                        }
                    }
                    var chat = dialogs.Chats
                        .Where(c => c.GetType() == typeof(TLChannel))
                        .Cast<TLChannel>()
                        .FirstOrDefault(c => c.Title == "- RPA group -");

                    await client.SendMessageAsync(new TLInputPeerChannel() { ChannelId = chat.Id, AccessHash = chat.AccessHash.Value }, msg);
                }
            }
            catch (Exception ex)
            {
                //_tarep.WriteError(ex.ToString());
            }
        }
    }
}
