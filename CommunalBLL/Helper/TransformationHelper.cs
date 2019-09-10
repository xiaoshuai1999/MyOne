using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CommunalBLL.Helper
{
    /// <summary>
    /// 转换文字
    /// </summary>
    public class TransformationHelper
    {
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
    }
}
