using System;
using System.IO;
using System.Net;
using System.Text;

namespace TestingConsoleApplication
{
    public class Address
    {
        public string addressLine1 { get; set; }
        public string city { get; set; }
        public string zip { get; set; }
        public string state { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //string source = "my name is marco.i am from italy.";
            //string[] stringSeparators = new string[] { "." };
            //var result = source.Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);
            //StringBuilder val = new StringBuilder();
            //foreach (var item in result)
            //{
            //   val.Append(System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(item) + ".");
            //}
            //Console.WriteLine(val);



            string responseMesesage, bearerToken = string.Empty;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
      

            string credentials = Convert.ToBase64String(Encoding.ASCII.GetBytes("exaltpay" + ":" + "Partner1700"));

            var request3 = (HttpWebRequest)WebRequest.Create("https://apisandbox.integritypays.com/v1/auth");
            request3.Method = "Post";
            //request.ContentLength = 45;
            //request.ContentType = "application/json";
            request3.Accept = "application/json";
            request3.KeepAlive = true;
            request3.Headers[HttpRequestHeader.AcceptEncoding] = "gzip, deflate";
            request3.Headers[HttpRequestHeader.CacheControl] = "no-cache";
            request3.Headers[HttpRequestHeader.Authorization] = "Basic " + credentials;

            var data3 = Encoding.UTF8.GetBytes(credentials);
            using (var stream = request3.GetRequestStream())
            {
                stream.Write(data3, 0, data3.Length);
            }

            WebResponse response3 = request3.GetResponse();
            if (((HttpWebResponse)response3).StatusDescription == "OK")
            {
                using (var stream = response3.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(stream);
                    responseMesesage = reader.ReadToEnd();
                    //dynamic jsonValue = JObject.Parse(responseMessage);
                    //bearerToken = jsonValue.bearerToken;
                    stream.Close();
                }
            }
            response3.Close();

            //Address obj = new Address()
            //{
            //    addressLine1 ="Noida",
            //    city ="Noida1",
            //    zip ="Noida3",
            //    state ="Noida2",
            //};
            //string jsonOrder = JsonConvert.SerializeObject(obj);
            string tt = "{\"addressLine1\":\"sample string 1\", \"city\": \"sample string 2\",\"zip\": \"sample string 3\",\"state\": \"sample string 4\"}";
            string valtt = "{\"DoingBusinessAs\":\"My Business Name\",\"LegalBusinessName\":\"My Legal Business Name\",\"LegalBusinessAddress\":{\"AddressLine1\":\"Valid Address\",\"City\":\"Chicago\",\"Zip\":\"60606\",\"State\":\"IL\"},\"DbaAddress\": {\"AddressLine1\":\"Valid Address\",\"City\":\"Chicago\",\"Zip\":\"60606\",\"State\":\"IL\"},\"OwnerContacts\": [{\"firstName\":\"Nitesh\",\"lastName\":\"Kushwaha\",\"email\":\"niteshtest400+1@gmail.com\",\"phone\":\"8888888888\",\"address\":{\"addressLine1\":\"Valid Address\",\"city\":\"Chicago\",\"zip\":\"60606\",\"state\":\"IL\"},\"equityPercentage\": 50,\"isPrimaryContact\": true,\"SSN\":\"123456789\"},{\"firstName\":\"Nitesh\",\"lastName\":\"Kushwaha\",\"email\":\"niteshtest400+1@gmail.com\",\"phone\":\"8888888888\",\"address\": {\"addressLine1\":\"Valid Address\",\"city\":\"Chicago\",\"zip\":\"60606\",\"state\":\"IL\"},\"equityPercentage\": 50,\"isPrimaryContact\": false}],\"BankAccount\": {\"NameOnAccount\":\"Nitesh Kushwaha\",\"RoutingNumber\":\"123456789\",\"AccountNumber\":\"123456789\"},\"FedTaxId\":\"123456789\"}";
            string test = "{\"DoingBusinessAs\":\"individual\",\"LegalBusinessName\":\"Apple Inc.\",\"EnableGatewayEmails\":\"false\",\"LegalBusinessAddress\":{\"AddressLine1\":\"Noida\",\"City\":\"Noida\",\"Zip\":\"979798798\",\"State\":\"AL\"},\"DbaAddress\":{\"AddressLine1\":\"Noida\",\"City\":\"Noida\",\"Zip\":\"979798798\",\"State\":\"AL\"},\"OwnerContacts\":[{\"firstName\":\"nitesh\",\"lastName\":\"lkumar\",\"email\":\"niteshtest400+112@gmail.com\",\"phone\":\"(897) 987-9878\",\"address\":{\"addressLine1\":\"Noida\",\"city\":\"Noida\",\"zip\":\"12345\",\"state\":\"MI\"},\"equityPercentage\":\"100\",\"isPrimaryContact\":\"true\",\"SSN\":\"798-79-8798\"}],\"BankAccount\":{\"NameOnAccount\":\"Nitesh\",\"RoutingNumber\":\"110000000\",\"AccountNumber\":\"000123456789\"},\"FedTaxId\":\"342178923\"}";
     
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls |
                                       SecurityProtocolType.Tls11 |
                                       SecurityProtocolType.Tls12;
            

            string url = "https://apisandbox.integritypays.com/v1/boarding";
            string url1 = "http://localhost:60662/api/Values";
            string token = "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsImtpZCI6InJHViJ9.eyJpc3MiOiJpcHNqd3QiLCJzdWIiOjQwLCJpYXQiOjE1MjQwNjA5NjAsImV4cCI6MTUyNDA2ODE2MCwiYXVkIjoiYXBpc2FuZGJveC5pbnRlZ3JpdHlwYXlzLmNvbSIsImVtYWlsIjoiZGZlcmtldEBpbnRlZ3JpdHlwYXltZW50c3lzdGVtLmNvbSIsInByZWZlcnJlZF91c2VybmFtZSI6ImV4YWx0cGF5Iiwicm9sZXMiOlsiQm9hcmRpbmdBUEkgVXNlciIsIkJvYXJkaW5nQVBJIFVzZXIiXSwicGVybXMiOlsiQ2FuQWNjZXNzIiwiQ2FuTW9kaWZ5IiwiQ2FuQWRkIiwiQ2FuQWNjZXNzIiwiQ2FuTW9kaWZ5IiwiQ2FuQWRkIl19.CJvF0yBTxUeAOVRLZn-w6V7IPjM71scCGaZVKMdXrgt65y6tBQc735ZnMXlK3F33HC6sP4u_wBpz41BRfrqbaoL_qJC8m_8dX4wQGlmzeI4vB4DSesPL_2BZOHK--1KYy6kepof7VfSPNyZelS3ig2uSlYoOunBTUNSgcRPg04s";
            string strResponseValue = string.Empty;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            
            request.Method = "POST";
            //req.ContentType = "application/x-www-from-urlencoded";
            request.Headers["Authorization"] = "Bearer " + token;
            request.Headers["Cache-Control"] = "no-cache";
            request.Headers["accept-encoding"] = "gzip, deflate";

            //request.Headers.Add("Authorization " + "bearerToken eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsImtpZCI6InJHViJ9.eyJpc3MiOiJpcHNqd3QiLCJzdWIiOjQwLCJpYXQiOjE1MjQwNTY2NjgsImV4cCI6MTUyNDA2Mzg2OCwiYXVkIjoiYXBpc2FuZGJveC5pbnRlZ3JpdHlwYXlzLmNvbSIsImVtYWlsIjoiZGZlcmtldEBpbnRlZ3JpdHlwYXltZW50c3lzdGVtLmNvbSIsInByZWZlcnJlZF91c2VybmFtZSI6ImV4YWx0cGF5Iiwicm9sZXMiOlsiQm9hcmRpbmdBUEkgVXNlciIsIkJvYXJkaW5nQVBJIFVzZXIiXSwicGVybXMiOlsiQ2FuQWNjZXNzIiwiQ2FuTW9kaWZ5IiwiQ2FuQWRkIiwiQ2FuQWNjZXNzIiwiQ2FuTW9kaWZ5IiwiQ2FuQWRkIl19.PByhgoWPaq4mNwulo7WXDQKvaEJ-WJ2gNuhMws8B8LUdRFdppDirO0MiT-AH8EnOyvcchSUvjLh-Lfmb5XsqEXZs-7CH8T5UIs-j50wbnzUm9torW1LcsaYiLtLoX8IjQ0N7jwhy7YLNidc2KxPciXgegjy9Hnhi45w_QFeNg2w");


            //********* NEW CODE TO SUPPORT POSTING *********

            request.ContentType = "application/json"; //Really Important
                using (StreamWriter swJSONPayload = new StreamWriter(request.GetRequestStream()))
                {
                    swJSONPayload.Write(valtt);
                    swJSONPayload.Close();
                }

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

            Console.ReadLine();
        }
    }
}
