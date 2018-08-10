namespace MyShop.Infastructure.Helper
{
    public class HttpHelper
    {
        public static bool IsSuccessStatusCode(int statusCode)
        {
            return statusCode >= 200 && statusCode <= 299;
        }
    }
}