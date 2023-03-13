namespace Core.Entities
{
    public class Model
    {
        public int Id { get; set; }
        public int? IdYear { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Year Year { get; set; }
        public ICollection<Car> Cars { get; set; }
    }
}
