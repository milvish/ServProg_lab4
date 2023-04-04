using lab3.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Text.Json.Nodes;

namespace lab3.Pages
{
    public class portfolioModel : DefaultModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JsonNode data;
        public portfolioModel(ILogger<IndexModel> logger, IDataReader reader) : base(reader, "portfolio")
        {
            _logger = logger;
        }
        public void OnGet()
        {
            title = _dataReader.GetData("portfolio")["title"];
        }
    }
}
