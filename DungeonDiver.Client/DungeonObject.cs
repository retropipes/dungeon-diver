using System.Text.Json.Serialization;

namespace DungeonDiver.Client;

public class DungeonObject
{
    [JsonConstructor]
    public DungeonObject(int id, bool solid)
    {
        Id = id;
        Solid = solid;
    }

    public DungeonObject(int id, string image, bool solid)
    {
        Id = id;
        Image = image;
        Solid = solid;
    }

    public int Id { get; init; }

    [JsonIgnore]
    public string? Image { get; init; }

    public bool Solid { get; init; }
}
