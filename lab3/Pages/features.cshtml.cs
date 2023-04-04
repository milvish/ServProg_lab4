using lab3.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Text.Json.Nodes;

namespace lab3.Pages
{
    public class featuresModel : DefaultModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JsonNode data;
        public featuresModel(ILogger<IndexModel> logger, IDataReader reader) : base(reader, "features")
        {
            _logger = logger;
        }
        public void OnGet()
        {
            title = _dataReader.GetData("features")["title"];
        }
    }
}
