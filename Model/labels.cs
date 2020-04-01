using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Model
{
    public partial class labels
    {
        ///<summary>标签ID</summary>
        public long label_id { get; set; }

        ///<summary>标签名称</summary>
        public string label_name { get; set; }

        ///<summary>标签别名</summary>
        public string label_alias { get; set; }

        ///<summary>标签描述</summary>
        public string label_description { get; set; }

    }
}
