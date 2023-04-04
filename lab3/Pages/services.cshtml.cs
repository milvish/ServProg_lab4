using lab3.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Text.Json.Nodes;

namespace lab3.Pages
{
    public class servicesModel : DefaultModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JsonNode data;
        public servicesModel(ILogger<IndexModel> logger, IDataReader reader) : base(reader, "services")
        {
            _logger = logger;
        }
        public void OnGet()
        {
            title = _dataReader.GetData("services")["title"];
        }
    }
}
