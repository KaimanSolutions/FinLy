using System.ComponentModel.DataAnnotations;

namespace finly.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public string BuildingNumber { get; set; }

        [StringLength(50)]
        public string BuildingName { get; set; }
        
        [StringLength(50)]
        public string SubBuldingNumber { get; set; }

        [StringLength(50)]
        public string SubBuildingSubName { get; set; }

        [StringLength(255)]
        public string StreetThoroughfare { get; set; }

        [StringLength(255)]
        public string Locality { get; set; }

        [StringLength(255)]
        public string TownCity { get; set; }

        [StringLength(255)]
        public string District { get; set; }

        [StringLength(255)]
        public string County { get; set; }

        [StringLength(25)]
        public string Postcode { get; set; }

        [StringLength(255)]
        public string Country { get; set; }

        public decimal Latitude { get; set; }

        public decimal Longitude { get; set; }
    }
}