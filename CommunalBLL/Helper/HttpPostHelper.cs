using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using CommunalBLL.Entity;
using Newtonsoft.Json;
using DN.Framework.Utility;
using Newtonsoft.Json.Linq;
using System.Web;
using System.Text.RegularExpressions;

namespace CommunalBLL.Helper
{
    public static class HttpPostHelper
    {

        /// <summary>
        /// 获取文章列表
        /// </summary>  
        public static void GetWenZhangList()
        {
            string url = @"https://m.toutiao.com/list/?tag=news_society&ac=wap&count=20&format=json_raw&as=A1459CCAF383722&cp=5CA3D3479282EE1&max_behot_time=1554191513&_signature=.ooSrQAAojL3xmi4yZ6fRv6KEr&i=1554191513";
            var json = GetStrHttp(url);

            ReptileEntity info = Serializer.DeserializeObject<Entity.ReptileEntity>(json);
            foreach (var item in info.data)
            {
                if (item.image_list.Count()>=3)
                {
                    
                }
            }
        }


        public static void GetWenZhangDetails(string UrlDetails = @"https://m.toutiao.com/i6675482833361830411/info/?i=6675482833361830411")
        {
            var json = GetStrHttp(UrlDetails);
            ReptileEntityDetailsEntity info = Serializer.DeserializeObject<ReptileEntityDetailsEntity>(json);
        }
      
        /// <summary>
        /// 跨域访问
        /// </summary>
        /// <returns></returns>
        public static string GetStrHttp(string Url)
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


        /// <summary>
        /// 字符串转  从 Unicode转成中文
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string StringToUnicode(string str)
        {
            string outStr = "";
            Regex reg = new Regex(@"(?i)\\u([0-9a-f]{4})");
            outStr = reg.Replace(str, delegate (Match m1)
            {
                return ((char)Convert.ToInt32(m1.Groups[1].Value, 16)).ToString();
            }
            );
            return outStr;
        }
        /// <summary>
        /// 替换字符串
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string GetReplace(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                name.Replace(@"\", "");
                name.Replace(@"今日头条", "");
                name.Replace(@"今日头条极速版", "");
                return name;
            }
            return "";
        }
    }
}
