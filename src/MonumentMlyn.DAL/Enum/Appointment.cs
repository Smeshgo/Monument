using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MonumentMlyn.DAL.Enum
{

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Appointment
    {
        Памятник = 1,
        Сходи,
        Чпу,
        Інше
    }
}