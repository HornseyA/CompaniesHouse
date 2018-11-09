using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CallCompaniesHouseAPITest
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public Company GetCompanyByCompanyCode (string url)
            {
                try
                {
                    using (var client = new HttpClient())
                    using (var response = client.GetAsync(url).Result)
                    using (var content = response.Content)
                    {
                        if (!response.IsSuccessStatusCode) throw new ResponseNotFoundException();
                        var json = content.ReadAsStringAsync().Result;

                        var companyResults = JsonConvert.DeserializeObject<Company>(json);

                        return companyResults;
                    }
                }

                catch (Exception e)
                {
                    throw new ResponseNotFoundException(e);

         
                }
            }
        }


}
    

