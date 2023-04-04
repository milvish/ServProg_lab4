using lab3.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Text.Json.Nodes;

namespace lab3.Pages
{
    public class pricingModel : DefaultModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JsonNode data;
        public pricingModel(ILogger<IndexModel> logger, IDataReader reader) : base(reader, "pricing")
        {
            _logger = logger;
        }
        public void OnGet()
        {
            title = _dataReader.GetData("pricing")["title"];
        }
    }
}
