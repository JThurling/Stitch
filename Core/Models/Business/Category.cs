using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Models.Business
{
    public class Category : DependencyEntity
    {
        public string Name { get; set; }

        [ForeignKey(nameof(Business))]
        public int BusinessId { get; set; }

        public Business Business { get; set; }
    }
}
