using System.Text.RegularExpressions;

namespace Insurance.Domain.Models;

public class InsuredPersonModel
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string PhoneNumber { get; set; }
    public DateTime BirthDateTime { get; set; }

    /// <summary>
    /// ověří zda telefoní číslo obsahuje jen + a dvanáct číslic
    /// </summary>
    /// <param name="telNo">telefoní číslo ve formátu example +420123456789</param>
    /// <returns>vrací false pokud číslo neodpovídá formátu</returns>
    public static bool ValidPhoneNo(string telNo)
    {
        return Regex.Match(telNo, @"^(\+[0-9]{12})$").Success;
    }

}