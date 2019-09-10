using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class SouhuCaiji
    {

        public static string Url = "http://www.myzaker.com/channel/9";
        public static void GetReptile()
        {
            try
            {
                HtmlWeb webclient = new HtmlWeb();
                HtmlDocument doc = webclient.Load(Url);
                var list = doc.DocumentNode.SelectNodes("//div[@class='figure flex-block']/a[@class='img']");
                if (list != null)
                {
                    foreach (var item in list)
                    {
                        var styleimg = item.Attributes["style"].Value;
                        if (!string.IsNullOrEmpty(styleimg))//没有图片不采集 这个文章
                        {
                            var href = item.Attributes["href"].Value;
                            GetWebHtml(href);
                            var title = item.Attributes["title"].Value;
                        }
                    }
                }
            }
            catch { }
        }

        /// <summary>
        /// 文章详情列表
        /// </summary>
        /// <param name="url">详情url地址给</param>
        public static void GetWebHtml(string DetailsUrl)
        {
            HtmlWeb webclient = new HtmlWeb();
            string DetailsUrl2 = "http:" + DetailsUrl;  //在传地址时 没有带http报错 在这里自己加上http
            HtmlDocument doc = webclient.Load(DetailsUrl2);
            var list = doc.DocumentNode.SelectNodes("//div[@class='article_content']");
            if (list != null&&list.Count==1)
            {
                var sss = list[0].InnerHtml.Replace("data-original", "src");  
            }
        }
    }
}
