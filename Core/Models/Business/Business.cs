using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Models.Business
{
    public class Business : DependencyEntity
    {
        public string Name { get; set; }

        public string PictureUrl { get; set; }

        public string Website { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public Address Address { get; set; }

        public double Rating { get; set; }

        public List<Review> Reviews { get; set; }

        [ForeignKey(nameof(ApplicationUser))]
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
