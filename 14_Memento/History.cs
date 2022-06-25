using System.Collections.Generic;

namespace P01_Memento
{
    public class History//CareTaker
    {
        public Stack<EditorState> States { get; set; } = new();
    }
}
