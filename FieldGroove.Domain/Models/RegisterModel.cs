using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldGroove.Domain.Models;

    public class RegisterModel
    {
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? CompanyName { get; set; }

        public long? Phone { get; set; }

        public string? Email { get; set; }

        public string? Password { get; set; }

        public string? PasswordAgain { get; set; }

        public string? TimeZone { get; set; }


    }

