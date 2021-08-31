using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MonumentMlyn.DAL.Enum
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CategoryPhoto
    {
        Стаття = 1,
        Одинарні,
        Подвійні,
        Елітні
    }
}