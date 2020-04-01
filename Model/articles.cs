using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Model
{
    public partial class articles
    {
        ///<summary>博文ID</summary>
        public long article_id { get; set; }

        ///<summary>发表用户ID</summary>
        public long user_id { get; set; }

        ///<summary>博文标题</summary>
        public string article_title { get; set; }

        ///<summary>博文内容</summary>
        public string article_content { get; set; }

        ///<summary>浏览量</summary>
        public long article_views { get; set; }

        ///<summary>评论总数</summary>
        public long article_comment_count { get; set; }

        ///<summary>发表时间</summary>
        public DateTime article_date { get; set; }

        ///<summary></summary>
        public long article_like_count { get; set; }

    }
}
