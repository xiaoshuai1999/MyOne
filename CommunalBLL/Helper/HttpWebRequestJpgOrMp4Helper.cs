using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CommunalBLL.Helper
{
    public class HttpWebRequestJpgOrMp4Helper
    {
        /// <summary>
        /// 保存 网页Http 图片 以及 mp4视频 
        /// </summary>
        /// <param name="url">http 获取地址</param>
        /// <param name="path">保存地址</param>
        /// <returns></returns>
        private static string Type = ".mp4"; 

        public static bool HttpDownload(string url= "https://vod.topys.com/07649eb34c164c39a96032fcf667839c/a5708727e83349c7a898e433bb350e9a-aafccd8b6ee7edfde39b50154f1ab7a8-sd.mp4", string path = @"C:\website")
        {
            string tempPath = System.IO.Path.GetDirectoryName(path);
            System.IO.Directory.CreateDirectory(tempPath);
            string tempFile = path + @"\" + System.IO.Path.GetFileName(url) + Type;
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

        /// <summary>
        /// 跨域访问  获取 html  
        /// </summary>
        /// <returns></returns>
        public static string GetStrHttpHtml(string Url)
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(Url);
            request.Method = "post";  //要爬今日头条 使用Ajax就得用 Get 而使用后台爬就得使用get 
            request.ContentType = "application/x-www-form-urlencoded;charset=utf-8";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);
            string Json = reader.ReadToEnd();
            return Json;
        }
    }
}
