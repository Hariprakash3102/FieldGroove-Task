using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FieldGroove.Domain.Models;

public class RegisterModel
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int? Id { get; set; }
    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? CompanyName { get; set; }

    public long? Phone { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public string? PasswordAgain { get; set; }

    public string? TimeZone { get; set; }

    public string? StreetAddress1 { get; set; }

    public string? StreetAddress2 { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public long? Zip { get; set; }
}

