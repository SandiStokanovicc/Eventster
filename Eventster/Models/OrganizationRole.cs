using System.Text.Json.Serialization;
using Newtonsoft.Json.Converters;

namespace Eventster.Models
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OrganizationRole
    {
        Owner = 1,
        Moderator = 2,
        Member = 3,
        Applied = 4,
    }

}
