using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MonumentMlyn.DAL.Enum
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CategoryMaterial
    {
        Стелла = 1,
        Тумба,
        Нулі,
        Накривки,
        Інша
    }
}