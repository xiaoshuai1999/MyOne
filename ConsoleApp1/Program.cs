using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            HttpDownload(@"https://p3.pstatp.com/list/pgc-image/5253b4c9ebad4636a9bd40d1c846ef0a", @"E:\shuaishuai");
            //HttpDownload(@"http://www.scedumedia.com/image/20190320/595fc51b8-9008-4044-96c3-5cdcf8ea6eb3.jpg", @"E\shuaishuai");
        }

        public static bool HttpDownload(string url, string path)
        {
            string tempPath = System.IO.Path.GetDirectoryName(path);
            System.IO.Directory.CreateDirectory(tempPath);  
            string tempFile = "download" + @"\" + System.IO.Path.GetFileName(url)+".jpg";
            if (System.IO.File.Exists(tempFile))
            {
                System.IO.File.Delete(tempFile);    //存在则删除
            }
            
            FileStream fs = new FileStream(tempFile, FileMode.Create);
            // 设置参数
            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            //发送请求并获取相应回应数据
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
   
            Stream responseStream = response.GetResponseStream();
          
            byte[] bArr = new byte[1024];
            int size = responseStream.Read(bArr, 0, (int)bArr.Length);
            while (size > 0)
            {
                fs.Write(bArr, 0, size);
                size = responseStream.Read(bArr, 0, (int)bArr.Length);
            }
            fs.Close();
            responseStream.Close();
           return true;
        }
    }
}
