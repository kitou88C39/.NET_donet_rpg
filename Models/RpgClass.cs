using System.Text.Json.Serialization;

namespace Dotnet_rpg.Models;
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
public class RpgClass
{
    Knight = 1,
    Mage = 2,
    Cleric = 3
}
}