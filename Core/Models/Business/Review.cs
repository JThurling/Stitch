using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Models.Business
{
    public class Review : DependencyEntity
    {
        public string UserName { get; set; }

        public string Comment { get; set; }

        public int Rating { get; set; }

        public DateTime DateCommented { get; set; } = DateTime.Now;

        public string Like { get; set; }

        public string Dislike { get; set; }

        [ForeignKey(nameof(Business))]
        public int BusinessId { get; set; }

        public Business Business { get; set; }
    }
}
