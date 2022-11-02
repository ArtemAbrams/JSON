using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using hometask;
JSON json = new JSON();
json.Serialization(new House(12, "Artem", new CPublishingHouse(5, "a", "a")));
json.Deserialization();