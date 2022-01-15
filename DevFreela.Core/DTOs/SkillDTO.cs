namespace DevFreela.Core.DTOs
{
    public class SkillDTO
    {
        public SkillDTO(int id, string description)
        {
            Id = id;
            Description = description;
        }

        public int Id { get; private set; }
        public string Description { get; private set; }
    }
}