using lab3.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Reflection;
using System.Text.Json.Nodes;

namespace lab3.Pages
{
    public class testimonialsModel : DefaultModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JsonNode data;
        public testimonialsModel(ILogger<IndexModel> logger, IDataReader reader) : base(reader, "testimonials")
        {
            _logger = logger;
        }
        public void OnGet()
        {
            title = _dataReader.GetData("testimonials")["title"];
        }
    }
}
