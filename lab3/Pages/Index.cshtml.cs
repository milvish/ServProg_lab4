using lab3.Services;
using System.Text.Json.Nodes;

namespace lab3.Pages
{
    public class IndexModel : DefaultModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JsonNode data;
        
        public IndexModel(ILogger<IndexModel> logger, IDataReader reader):base(reader, "index")
        {
            _logger = logger;
        }

        public void OnGet()
        {
            title = _dataReader.GetData("index")["title"];
        }
    }
}
