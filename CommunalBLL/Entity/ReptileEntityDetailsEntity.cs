using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunalBLL.Entity
{
    public class ReptileEntityDetailsEntity
    {
        public _ck _ck { get; set; }
        public data data { get; set; }

        public string success { get; set; }

    }
    public class _ck
    {

    }

    public class data
    {
        public string detail_source { get; set; }
        public media_user media_user { get; set; }
        public string publish_time { get; set; }
        public List<hotwords> hotwords { get; set; }

        public string title { get; set; }
        public string url { get; set; }
        public List<labels> labels { get; set; }
        public string impression_count { get; set; }
        public string is_original { get; set; }
        public string is_pgc_article { get; set; }
        public string content { get; set; }
        public string source { get; set; }
        public string comment_count { get; set; }
        public string logo_show_strategy { get; set; }
        public string creator_uid { get; set; }
    }

    public class media_user {
        public string screen_name { get; set; }
        public string no_display_pgc_icon { get; set; }
        public string avatar_url { get; set; }
        public string id { get; set; }
        public user_auth_info user_auth_info { get; set; }

    }
    public class user_auth_info
    {
        public string auth_type { get; set; }
        public string auth_info { get; set; }
    }

    public class hotwords
    {
        public string stress_type { get; set; }
        public string hot_word { get; set; }
    }

    public class labels
    {

    }
}
