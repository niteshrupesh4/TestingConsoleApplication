using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TestingConsoleApplication
{
    public class PlaidStripe
    {
        static void Main(string[] args)
        {
            string test = "{  \"client_id\": \"5696a3917119b3e14ad4a13d\",  \"secret\": \"8ccee1e4964f169df103b6b16b7bf4\",  \"public_token\": \"public-sandbox-32731aba-4854-48b9-8af5-bb4bad172331\"}";
            
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls |
                                       SecurityProtocolType.Tls11 |
                                       SecurityProtocolType.Tls12;


            string url = "https://sandbox.plaid.com/item/public_token/exchange?client_id=5696a3917119b3e14ad4a13d&secret=8ccee1e4964f169df103b6b16b7bf4&public_token=public-sandbox-32731aba-4854-48b9-8af5-bb4bad172331"; 
            string strResponseValue = string.Empty;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.ContentLength = 0;
            request.Method = "POST";
           
            //********* NEW CODE TO SUPPORT POSTING *********

            request.ContentType = "application/json"; //Really Important
            //using (StreamWriter swJSONPayload = new StreamWriter(request.GetRequestStream()))
            //{
            //    swJSONPayload.Write(test);
            //    swJSONPayload.Close();
            //}

            HttpWebResponse response = null;

            try
            {
                response = (HttpWebResponse)request.GetResponse();
                //Proecess the resppnse stream... (could be JSON, XML or HTML etc..._
                using (Stream responseStream = response.GetResponseStream())
                {
                    if (responseStream != null)
                    {
                        using (StreamReader reader = new StreamReader(responseStream))
                        {
                            strResponseValue = reader.ReadToEnd();
                            string responseMessage = reader.ReadToEnd();
                            //dynamic jsonValue = JObject.Parse(responseMessage);
                        }
                    }
                }

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    Stream receiveStream = response.GetResponseStream();
                    StreamReader readStream = null;

                    if (response.CharacterSet == null)
                    {
                        readStream = new StreamReader(receiveStream);
                    }
                    else
                    {
                        readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
                    }

                    string data = readStream.ReadToEnd();

                    response.Close();
                    readStream.Close();
                }
            }
            catch (Exception ex)
            {
                strResponseValue = "{\"errorMessages\":[\"" + ex.Message.ToString() + "\"],\"errors\":{}}";
                Console.WriteLine(strResponseValue);
            }
            finally
            {
                if (response != null)
                {
                    ((IDisposable)response).Dispose();
                }
            }

        }
    }
}
