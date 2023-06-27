using System.Text.RegularExpressions;

namespace Insurance.Api.Dto.Output;

public class InsuredPersonDto
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string PhoneNumber { get; set; }
    public DateTime BirthDateTime { get; set; }

    /// <summary>
    /// ověří zda telefoní číslo obsahuje jen + a dvanáct číslic
    /// </summary>
    /// <param name="telNo">telefoní číslo ve formátu example +420123456789</param>
    /// <returns>vrací false pokud číslo neodpovídá formátu</returns>
    public bool ValidPhoneNo { get; set; }

}