namespace P01_Memento
{
    public class EditorState//Memento
    {
        public Editor Editor { get; init; }
        public string Content { get; init; }
        public string Title { get; init; }

        public void Restore()
        {
            Editor.Content = Content;
            Editor.Title = Title;
        }
    }
}
