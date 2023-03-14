namespace Core.Entities
{
    public class Year
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public ICollection<Model> Models { get; set; }
        public ICollection<Car> Cars { get; set; }
    }
}
