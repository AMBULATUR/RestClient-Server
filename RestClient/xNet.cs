using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.IO;
using System.Net;

namespace RestClient
{
    class xNet
    {
        public enum PostMethods
        {
            /// <summary>
            /// Чтение файла
            /// <para>1 Аргумент {currentAddr}</para>
            /// </summary>
            GET,
            /// <summary>
            /// Перезапись файла
            /// <para>2 Аргументa {currentAddr,textString}</para>
            /// </summary>
            PUT,
            /// <summary>
            /// Добавление в конец файла
            /// <para>2 Аргументa {currentAddr,textString}</para>
            /// </summary>
            POST,
            /// <summary>
            /// Удаление файла
            /// <para>1 Аргумент {currentAddr}</para>
            /// </summary>
            DELETE,
            /// <summary>
            /// Копирование файла
            /// <para>2 Аргумента {currentAddr,expectedAddr}</para>
            /// </summary>
            COPY,
            /// <summary>
            /// Перемещение файла
            /// <para>2 Аргумента {currentAddr,expectedAddr}</para>
            /// </summary>
            MOVE,
            /// <summary>
            /// Status
            /// </summary>
            STATUS
        }

        private static xNet instance;
        public bool Init { get; private set; }
        private string Server = @"http://trize.ru/post.php";
        private xNet()
        {
            Init = true;
        }

        public static xNet GetInstance()
        {
            if (instance == null)
                instance = new xNet();
            return instance;
        }

        public string ParseArgs(string[] args)
        {
            if (args == null)
                throw new NotImplementedException("[!] args == NULL");
            string result = "&";
            int iterator = 0;
            foreach (var argument in args)
            {
                result += $"arg{iterator++}={argument}&";
            }
            return result;

        }
        public string SendPost(PostMethods method, string[] args)
        {

            WebRequest request = WebRequest.Create(Server);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            byte[] Data = Encoding.GetEncoding(1251).GetBytes("method=" + method.ToString() + ParseArgs(args));
            request.ContentLength = Data.Length;
            Stream siteStream = request.GetRequestStream();
            siteStream.Write(Data, 0, Data.Length);
            siteStream.Close();
            HttpWebResponse result = (HttpWebResponse)request.GetResponse(); //tl;dr HttpWebResponse contains status code
            string responseString;
            using (Stream stream = result.GetResponseStream())//dispose tl;dr
            {
                StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                responseString = reader.ReadToEnd();
            }
            responseString += $"\nStatus Code : {result.StatusCode} / {result.StatusDescription}";
            return responseString;
        }

    }

}
