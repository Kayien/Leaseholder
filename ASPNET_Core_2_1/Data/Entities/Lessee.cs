using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ASPNET_Core_2_1.Data.Entities
{
    public class Lessee
    {
        public int Id { get; set; }

        public User User { get; set; }
        public ICollection<Contract> Contracts { get; set; }

    }
}
