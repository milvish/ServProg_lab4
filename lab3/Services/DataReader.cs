using System.IO;
using System.Text.Json.Nodes;


namespace lab3.Services
{
	public class DataReader : IDataReader
	{
		public readonly string filename = "data.json";

		public JsonNode GetData(string key)
		{
			StreamReader sr = new StreamReader(filename);
			var input = sr.ReadToEnd();
			var jsonObject = JsonNode.Parse(input)!.AsObject();
			return jsonObject["pages"][key];
		}

	}
}
