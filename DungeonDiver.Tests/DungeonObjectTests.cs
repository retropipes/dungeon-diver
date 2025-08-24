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
}
