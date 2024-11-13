using System.ComponentModel.DataAnnotations;

namespace Store.Data.Entities.IdentityEntites
{
    public class Address
    {
        public long Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string PostalCode { get; set; }
        [Required]
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
