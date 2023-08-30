using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Http;  
using System.IO;


namespace SendRandomNumbers
{
    internal class SendMessage
    {
        internal static HttpClient client = new HttpClient();
        
        internal static void Send(List<int> message)
        {
            string mess = "";
            //Получить URI из файла
            string URI = File.ReadLines("URI.txt").First();
            // определяем данные запроса
            for(int i = 0; i<message.Count; i++)
            {
                mess = mess + message[i].ToString() + "; ";
            }

            var request = (HttpWebRequest)WebRequest.Create(URI);

            var postData = Uri.EscapeDataString(mess);
            var data = Encoding.ASCII.GetBytes(postData);

            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = data.Length;

            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }
            try
            {
                var response = (HttpWebResponse)request.GetResponse();

                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
                Console.WriteLine();
                Console.WriteLine("Отправка данных выполнена успешно");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine($"Ошибка отправки данных: {ex.Message}");
                Console.ReadLine();
            }
        }
        
    }
}
