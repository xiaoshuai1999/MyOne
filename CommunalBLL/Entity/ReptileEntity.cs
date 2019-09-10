using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunalBLL.Entity
{
    public class ReptileEntity
    {
        public string return_count { get; set; }
        public string has_more { get; set; }
        public string page_id { get; set; }
        public ck _ck { get; set; }
        public string html { get; set; }
        public List<Date> data { get; set; }
    }
    public class ck
    {
    }
    public class Date {
        public string media_name { get; set; }
        public string ban_comment { get; set; }
        public string @abstract { get; set; }
        public List<listDate> image_list { get; set; }
        public string Datetime { get; set; }
        public string article_type { get; set; }
        public string more_mode { get; set; }
        public string tag { get; set; }
        public string has_m3u8_video { get; set; }
        public string keywords { get; set; }
        public string display_dt { get; set; }
        public string has_mp4_video { get; set; }
        public string aggr_type { get; set; }
        public string cell_type { get; set; }
        public string article_sub_type { get; set; }
        public string bury_count { get; set; }
        public string title { get; set; }
        public string source_icon_style { get; set; }
        public string tip { get; set; }
        public string has_video { get; set; }
        public string share_url { get; set; }
        public string source { get; set; }
        public string comment_count { get; set; }
        public string article_url { get; set; }
        public string publish_time { get; set; }
        public string group_flags { get; set; }
        public string gallary_image_count { get; set; }
        public object action_extra { get; set; }
        public string tag_id { get; set; }
        public string source_url { get; set; }
        public string display_url { get; set; }
        public string is_stick { get; set; }
        public string item_id { get; set; }
        public string repin_count { get; set; }
        public string cell_flag { get; set; }
        public string source_open_url { get; set; }
        public string level { get; set; }
        public string digg_count { get; set; }
        public string behot_time { get; set; }
        public string hot { get; set; }
        public string cursor { get; set; }
        public string url { get; set; }
        public string user_repin { get; set; }
        public string has_image { get; set; }
        public string video_style { get; set; }
        public  media_info media_info { get; set; }
        public string group_id { get; set; }
    }

    public class listDate {
        public string url { get; set; }
        public string width { get; set; }
        public string height { get; set; }
    }
    public class media_info
    {
        public string avatar_url { get; set; }
        public string media_id { get; set; }
        public string name { get; set; }
        public string user_verified { get; set; }
    }
}
