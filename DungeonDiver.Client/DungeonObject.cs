using System;

namespace DungeonDiver.Client;

public class DungeonObject
{
    public DungeonObject(int id) => Id = id;

    public int Id { get; init; }
}
