using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Model
{
    public partial class comments
    {
        ///<summary>评论ID</summary>
        public long comment_id { get; set; }

        ///<summary>发表用户ID</summary>
        public long user_id { get; set; }

        ///<summary>评论博文ID</summary>
        public long article_id { get; set; }

        ///<summary>点赞数</summary>
        public long comment_like_count { get; set; }

        ///<summary>评论日期</summary>
        public DateTime comment_date { get; set; }

        ///<summary>评论内容</summary>
        public string comment_content { get; set; }

        ///<summary>父评论ID</summary>
        public long parent_comment_id { get; set; }

    }
}
