using Microsoft.Extensions.Configuration;
using Microsoft.Identity.Client;

namespace WebApp.Helpers
{
    public static class GenerateToken
    {
        private static string _clientID { get; set; }
        private static string  _clientSecret{ get; set; }
        private static string _tenantID { get; set; }
        private static string _scope { get; set; }
        static GenerateToken()
        {
            _clientID = "76f5b655-0364-427c-a730-6e6e8f3211e7";
            _clientSecret = "3Lj8Q~USXi6ApEUStqRwvi0pGDTDvj~6TG-5DcYK";
            _tenantID = "fbadfc59-b650-4877-b930-13cbaaf2e0dc";
            _scope = "0c81e5bc-a5ec-4b13-9c78-2fcbb75b1ba0/.default";
        }

        public static string GenerateClientToken()
        {
            string token = string.Empty;
            IConfidentialClientApplication _clientApp = ConfidentialClientApplicationBuilder
                                                        .Create(_clientID)
                                                        .WithClientSecret(_clientSecret)
                                                        .WithAuthority(AzureCloudInstance.AzurePublic, _tenantID)
                                                        .Build();
            AuthenticationResult result;

            try
            {
                result = _clientApp.AcquireTokenForClient(new string[] {_scope})
                        .ExecuteAsync(CancellationToken.None).Result;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
            if (result != null)
            {
                token = result.AccessToken;
            }

            return token;
                    
        }
    }
}