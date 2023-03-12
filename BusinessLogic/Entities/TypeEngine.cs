namespace Core.Entities
{
    public class TypeEngine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<TypeEngine> Engines { get; set; }
    }
}
