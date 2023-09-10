using System.ComponentModel.DataAnnotations;
using MassTransit;

public class BaseEntity
{
    public Guid Id { get; set; } = NewId.Next().ToGuid();

    [DataType(DataType.Date)]
    public DateTime CreatedAt { get; set; }
    
    [DataType(DataType.Date)]
    public DateTime UpdatedAt { get; set; }
}