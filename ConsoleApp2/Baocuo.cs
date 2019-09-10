using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public static class Baocuo
    {
        public static bool HttpDownload(string url, string path)
        {
            string tempPath = System.IO.Path.GetDirectoryName(path);
            System.IO.Directory.CreateDirectory(tempPath);  //创建临时文件目录
            string tempFile = path + @"\" + System.IO.Path.GetFileName(url)+".jpg"; //临时文件
       
            FileStream fs = new FileStream(tempFile, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
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

