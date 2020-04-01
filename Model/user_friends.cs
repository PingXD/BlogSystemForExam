using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Model
{
    public partial class user_friends
    {
        ///<summary>标识ID</summary>
        public long id { get; set; }

        ///<summary>用户ID</summary>
        public long user_id { get; set; }

        ///<summary>好友ID</summary>
        public long user_friends_id { get; set; }

        ///<summary>好友备注</summary>
        public string user_note { get; set; }

        ///<summary>好友状态</summary>
        public string user_status { get; set; }

    }
}
