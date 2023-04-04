using lab3.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Text.Json.Nodes;

namespace lab3.Pages
{
    public class about_usModel : DefaultModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JsonNode data;
        public about_usModel(ILogger<IndexModel> logger, IDataReader reader) : base(reader, "about_us")
        {
            _logger = logger;
        }
        public void OnGet()
        {
            title = _dataReader.GetData("about-us")["title"];
        }
    }
}
