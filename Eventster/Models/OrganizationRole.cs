using System.Text.Json.Serialization;

namespace Eventster.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum OrganizationRole
    {
        Owner = 1,
        Moderator = 2,
        Member = 3,
        Applied = 4,
    }

}
