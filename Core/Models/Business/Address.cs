using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Models.Business
{
    public class Address : DependencyEntity
    {
        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public string ProvinceState { get; set; }

        public float Latitude { get; set; }

        public float Longitude { get; set; }

        [ForeignKey(nameof(Business))]
        public int BusinessId { get; set; }

        public Business Business { get; set; }
    }
}
