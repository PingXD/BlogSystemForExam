using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Model
{
    public partial class sorts
    {
        ///<summary>分类ID</summary>
        public long sort_id { get; set; }

        ///<summary>分类名称</summary>
        public string sort_name { get; set; }

        ///<summary>分类别名</summary>
        public string sort_alias { get; set; }

        ///<summary>分类描述</summary>
        public string sort_description { get; set; }

        ///<summary>父分类ID</summary>
        public long parent_sort_id { get; set; }

    }
}
