using System;

namespace Domain;

public class Subject
{
    public string id { get; set; } = Guid.NewGuid().ToString();
    public required string Name { get; set; }
    public required string Description { get; set; }
    public required DateTime DatePublished { get; set; }
}
