using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Model
{
    public partial class users
    {
        ///<summary>用户ID</summary>
        public long user_id { get; set; }

        ///<summary>用户IP</summary>
        public string user_ip { get; set; }

        ///<summary>用户名</summary>
        public string user_name { get; set; }

        ///<summary>用户密码</summary>
        public string user_password { get; set; }

        ///<summary>用户邮箱</summary>
        public string user_email { get; set; }

        ///<summary>用户头像</summary>
        public string user_profile_photo { get; set; }

        ///<summary>注册时间</summary>
        public DateTime user_registration_time { get; set; }

        ///<summary>用户生日</summary>
        public string user_birthday { get; set; }

        ///<summary>用户年龄</summary>
        public Byte user_age { get; set; }

        ///<summary>用户手机号</summary>
        public string user_telephone_number { get; set; }

        ///<summary>用户昵称</summary>_
        public string user_nickname { get; set; }

    }
}
