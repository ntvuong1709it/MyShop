using System;
using RestSharp;

namespace Blockchain
{
    public class BlockchainApi
    {
        private const string BaseUrl = "localhost:3000";

        public static T Execute<T>(RestRequest request) where T : new()
        {
            var client = new RestClient();
            client.BaseUrl = new Uri(BaseUrl);

            var response = client.Execute<T>(request);

            if (response.ErrorException != null)
            {
                var message = "Error retrieving response. Check inner details for more info.";
                var ex = new ApplicationException(message, response.ErrorException);
                throw ex;
            }

            return response.Data;
        }
    }
}
