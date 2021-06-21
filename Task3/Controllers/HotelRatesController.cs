using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace Task3.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class HotelRatesController : ApiController
    {
        /// <summary>
        /// request to filter out the hotel rates a/c to hotel ID and arrival date
        /// </summary>
        /// <param name="hotelID">Hotel ID(7294)</param>
        /// <param name="arrivalDate">dd.MM.yyyy format (e.g: 15.03.2016)</param>
        /// <returns>return the filter list in json</returns>
        public HttpResponseMessage Get(int hotelID, string arrivalDate)
        {
            JsonData items;
            string rawJson = "No data found";
            using (StreamReader jsonStream = new StreamReader(@"E:\task 2 - hotelrates.json"))
            {
                string json = jsonStream.ReadToEnd();
                items = JsonConvert.DeserializeObject<JsonData>(json);
            }

            if (items.hotel != null && items.hotel.hotelID == hotelID)
            {
                var data = items.hotelRates.Where(x => x.targetDay.ToString("dd.MM.yyyy") == arrivalDate);
                if (data != null && data.Count() > 0)
                {
                    rawJson = JsonConvert.SerializeObject(data);
                }
            }

            var response = Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new StringContent(rawJson, Encoding.UTF8, "application/json");
            return response;
        }

    }
}
