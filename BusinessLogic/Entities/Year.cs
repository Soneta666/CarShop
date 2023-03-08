namespace Core.Entities
{
    public class Year
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public ICollection<Model> Models { get; set; }
    }
}
