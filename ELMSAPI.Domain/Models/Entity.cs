namespace ELMSAPI.Domain.Models;
public class Entity
{
    public Ulid Id { get; init; }
    public DateTime DateCreated { get; init; }
    public DateTime DateModified { get; set; }
    public required string Status { get; set; }
}
