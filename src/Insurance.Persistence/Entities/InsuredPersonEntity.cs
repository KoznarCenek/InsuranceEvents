namespace Isuranse.Persistence.Entities;

public class InsuredPersonEntity
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string PhoneNumber { get; set; }
    public DateTime BirthDateTime { get; set; }
}