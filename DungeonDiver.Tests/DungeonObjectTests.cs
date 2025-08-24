using System.Text.Json;
using DungeonDiver.Client;

namespace DungeonDiver.Tests;

public class DungeonObjectTests
{
    [Fact]
    public void Create_WithId1()
    {
        var dungeonObject = new DungeonObject(id: 1);
        Assert.Equal(1, dungeonObject.Id);
    }

    [Fact]
    public void Create_WithId1_AndImage()
    {
        var dungeonObject = new DungeonObject(id: 1, image: "tile.png");
        Assert.Equal(1, dungeonObject.Id);
        Assert.Equal("tile.png", dungeonObject.Image);
        var dungeonObjectJson = JsonSerializer.Serialize(dungeonObject);
        var recreatedDungeonObject = JsonSerializer.Deserialize<DungeonObject>(dungeonObjectJson)!;
        // Serialization does NOT persist the Image property
        Assert.Null(recreatedDungeonObject.Image);
    }
}
