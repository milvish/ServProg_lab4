using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using lab3.Services;
using System.Text.Json.Nodes;


namespace lab3.Pages
{
    public class DefaultModel : PageModel
    {
        protected IDataReader _dataReader;
        public string _pageName;
        public JsonNode title;

        public DefaultModel(IDataReader dataService, string name)
        {
            _dataReader = dataService;
            _pageName = name;
        }
    }
}