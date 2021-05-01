using DeskBooker.Core.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DeskBooker.Core.Domain
{
    public class DeskBookingBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        [DataType(DataType.Date)]
        [DateInFuture]
        [DateWithoutTime]
        public DateTime Date { get; set; }
    }
}
