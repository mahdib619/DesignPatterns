namespace P01_Memento
{
    public class Editor //Originator
    {
        public string Content { get; set; }
        public string Title { get; set; }

        public EditorState CreateState()
        {
            return new()
            {
                Editor = this,
                Content = Content,
                Title = Title
            };
        }
    }
}
