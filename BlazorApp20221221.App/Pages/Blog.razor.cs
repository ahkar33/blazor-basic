using BlazorApp20221221.DataAccess;
using BlazorApp20221221.Models.DataModels;
using BlazorApp20221221.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp20221221.App.Pages
{
    public partial class Blog
    {
        public List<BlogViewModel> lst { get; set; }
        DapperService service = new DapperService();
        public BlogViewModel reqModel { get; set; } = new BlogViewModel();

        protected override async Task OnInitializedAsync()
        {
            List();
        }

        void Save()
        {
            service.Execute($"insert into tbl_blog values('{reqModel.BlogTitle}', '{reqModel.BlogAuthor}', '{reqModel.BlogContent}')");
            List();
        }

        void List()
        {

            var result = service.Get<BlogDataModel>("select * from tbl_blog");
            lst = result.Select(x => new BlogViewModel
            {
                BlogId = x.Blog_Id,
                BlogTitle = x.Blog_Title,
                BlogAuthor = x.Blog_Author,
                BlogContent = x.Blog_Content,
            }).ToList();
        }
    }
}
