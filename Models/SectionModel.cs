namespace Inventario.api.Models
{
    public class SectionModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string CodeName { get; set; }
        public string? Description { get; set; }
        public int LevelId { get; set; }
        public List<ContainerModel>? Containers { get; set; }
        public SectionModel()
        {
            
        }
        public SectionModel(int id, string name, string codeName, string description, int levelId, List<ContainerModel>? containers)
        {
            Id = id;
            Name = name;
            CodeName = codeName;
            Description = description;
            LevelId = levelId;
            Containers = containers;
        }
    }
}
