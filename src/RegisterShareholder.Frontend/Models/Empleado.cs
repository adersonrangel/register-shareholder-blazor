using System;

namespace RegisterShareholder.Frontend.Models;

public class Empleado
{
    public Guid Id { get; set; }
    public  required string Name { get; set; }
    public required string LastName { get; set; }
    public int Age { get; set; }
}
