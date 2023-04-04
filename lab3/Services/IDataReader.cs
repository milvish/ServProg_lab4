using System.Text.Json.Nodes;

namespace lab3.Services
{
    public interface IDataReader
    {
        public JsonNode GetData(string key);
    }
}