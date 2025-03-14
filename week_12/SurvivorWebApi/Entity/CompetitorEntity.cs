using System.ComponentModel.DataAnnotations.Schema;

namespace SurvivorWebApi.Entity
{
    public class CompetitorEntity : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CategoryId { get; set; }


        // bunu koymayı unutma
        [ForeignKey(nameof(CategoryId))]
        public CategoryEntity Category { get; set; }
    }
}