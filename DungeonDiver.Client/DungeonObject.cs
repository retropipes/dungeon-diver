using System;
using System.Text.Json.Serialization;

namespace DungeonDiver.Client;

public class DungeonObject
{
    [JsonConstructor]
    public DungeonObject(int id) => Id = id;

    public DungeonObject(int id, string image)
    {
        Id = id;
        Image = image;
    }

    public int Id { get; init; }

    [JsonIgnore]
    public string? Image { get; init; }
}
