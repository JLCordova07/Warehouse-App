namespace Inventario.api.Models
{
    public class ContainerModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string CodeName { get; set; }
        public string? Description { get; set; }
        public int SectionId { get; set; }
        public List<ItemCategoryModel>? Items { get; set; }
        public ContainerModel()
        {
            
        }
        public ContainerModel(int id, string codeName, string description, int sectionId, List<ItemCategoryModel>? items)
        {
            Id = id;
            CodeName = codeName;
            Description = description;
            SectionId = sectionId;
            Items = items;
        }
    }
}
