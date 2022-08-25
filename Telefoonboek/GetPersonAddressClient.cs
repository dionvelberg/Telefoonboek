using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Telefoonboek
{
    public class GetPersonAddressClient
    {
        private 
        static HttpClient client = new HttpClient();
        public GetPersonAddressClient() {

            client.BaseAddress = new Uri(Constants.apiBaseAddress);
            client.DefaultRequestHeaders.Add("token", Constants.apiToken);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<PersonAddress> GetPersonAddress(string zipcode, string number)
        {
            PersonAddress personAddress = null;
            HttpResponseMessage response = await client.GetAsync(String.Format("?postcode={0}&number={1}", zipcode, number));
            if (response.IsSuccessStatusCode)
            {
                personAddress = await response.Content.ReadAsAsync<PersonAddress>();
            }
            return personAddress;
        }

    }
}
