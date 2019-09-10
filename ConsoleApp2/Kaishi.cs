using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Kaishi
    {
        public static bool HttpDownload(string url, string path)
        {
            //string tempPath = System.IO.Path.GetDirectoryName(path);
            //System.IO.Directory.CreateDirectory(tempPath);
            string tempFile = path + @"\" + System.IO.Path.GetFileName(url) + ".mp4";
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
