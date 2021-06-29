namespace DevFreela.Application.InputModels
{
    public class CreateCommentInputModel
    {
        public string Content { get; private set; }
        public int IdProject { get; private set; }
        public int IdUser { get; private set; }
    }
}