namespace SurvivorWebApi.Entity
{
    public class CategoryEntity : BaseEntity
    {
        public string Name { get; set; }

        public List<CompetitorEntity> Competitors { get; set; }
    }
}