using BlazorApp20221221.DataAccess;
using BlazorApp20221221.Models.DataModels;
using BlazorApp20221221.Models.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazorApp20221221.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DapperService service = new DapperService();
            var result = service.Execute("insert into tbl_blog values('test', 'test', 'test')");

            var lst = service.Get<BlogDataModel>("select * from tbl_blog");
            List<BlogViewModel> model = lst.Select(x => new BlogViewModel
            {
                BlogId = x.Blog_Id,
                BlogTitle = x.Blog_Title,
                BlogAuthor = x.Blog_Author,
                BlogContent = x.Blog_Content,
            }).ToList();

            Console.WriteLine(JsonConvert.SerializeObject(model, Formatting.Indented));

            Console.ReadKey();
        }
    }
}
