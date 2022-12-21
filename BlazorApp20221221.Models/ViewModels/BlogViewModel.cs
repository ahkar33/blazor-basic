using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorApp20221221.Models.ViewModels
{
    public class BlogViewModel
    {
        public int BlogId { get; set; }
        public string BlogTitle { get; set; }
        public string BlogAuthor { get; set; }
        public string BlogContent { get; set; }
    }
}
