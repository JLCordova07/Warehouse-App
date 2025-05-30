namespace Inventario.api.Models
{
    public class LevelModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string CodeName { get; set; }
        public string? Description { get; set; }
        public int RackId { get; set; }
        public List<SectionModel>? Zones { get; set; }
        public LevelModel()
        {

        }
        public LevelModel(int id, string name, string codeName, string description, int rackId, List<SectionModel>? zones)
        {
            Id = id;
            Name = name;
            CodeName = codeName;
            Description = description;
            RackId = rackId;
            Zones = zones;
        }
    }
}
