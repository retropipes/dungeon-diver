using System.Text.Json;
using DungeonDiver.Client;

namespace DungeonDiver.Tests;

public class DungeonObjectTests
{
    [Fact]
    public void Create_WithId1()
    {
        var dungeonObject = new DungeonObject(id: 1, solid: true);
        Assert.Equal(1, dungeonObject.Id);
        Assert.True(dungeonObject.Solid);
    }

    [Fact]
    public void Create_WithId1_AndImage()
    {
        var dungeonObject = new DungeonObject(id: 1, image: "tile.png", solid: false);
        Assert.Equal(1, dungeonObject.Id);
        Assert.Equal("tile.png", dungeonObject.Image);
        var dungeonObjectJson = JsonSerializer.Serialize(dungeonObject);
        var recreatedDungeonObject = JsonSerializer.Deserialize<DungeonObject>(dungeonObjectJson)!;
        // Serialization does NOT persist the Image property
        Assert.Null(recreatedDungeonObject.Image);
    }

    [Fact]
    public void Create_WithId1_AndNotSolid()
    {
        var dungeonObject = new DungeonObject(id: 1, solid: false);
        Assert.Equal(1, dungeonObject.Id);
        Assert.False(dungeonObject.Solid);
    }
}
