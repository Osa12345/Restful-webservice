using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Threading.Tasks;
using Task3;
using Task3.Controllers;

namespace Task3Test
{
    public class UnitTestTask3
    {

        [Test]
        public async Task Test1()
        {
            int hotelID = 7294;
            string arrivalDate = "15.03.2016";

            //string apiAddress = "https://localhost:44337/api/HotelRates?hotelID=7294&arrivalDate=2016-03-15";


            //Arrange
            HotelRatesController apiController = new HotelRatesController();

            
            var HttpResponseMessage = await apiController.Get(hotelID, arrivalDate);


            

            Assert.Equals(HttpStatusCode.OK, HttpResponseMessage.StatusCode);



            //string requestParams = string.Empty;
            //List<KeyValuePair<string, string>> allIputParams = new List<KeyValuePair<string, string>>();

            //// Converting Request Params to Key Value Pair.  
            //allIputParams.Add(new KeyValuePair<string, int>("hotelID", 7294));

            //allIputParams.Add(new KeyValuePair<string, string>("priority", "M"));

            //// URL Request Query parameters.  
            //requestParams = new FormUrlEncodedContent(allIputParams).ReadAsStringAsync().Result;



            //string apiUrl = apiAddress;
            //Uri baseAddress = new Uri(apiUrl);
            //HttpClient client;
            //client = new HttpClient();
            //client.BaseAddress = baseAddress;
            //HttpResponseMessage response = client.GetAsync(client.BaseAddress).Result;

            //if (response.IsSuccessStatusCode)
            //{
            //    string data = response.Content.ReadAsStringAsync().Result;
            //    Assert.IsNotNull(data);
            //}
            //List<AccountViewModel> accountModel = new List<AccountViewModel>();
            //HttpResponseMessage response = client.GetAsync(client.BaseAddress).Result;
            //string ipAddress = GetLocalIPAddress();
            
        }


        //public static string GetLocalIPAddress()
        //{
        //    var host = Dns.GetHostEntry(Dns.GetHostName());
        //    foreach (var ip in host.AddressList)
        //    {
        //        if (ip.AddressFamily == AddressFamily.InterNetwork)
        //        {
        //            return ip.ToString();
        //        }
        //    }
        //    throw new Exception("No network adapters with an IPv4 address in the system!");
        //}
    }
}