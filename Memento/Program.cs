using System;
namespace Memento
{
    class Program
    {
        static void Main()
        {
            TextEditorMemento textEditor = new("Hello World!");
            TextEditorMemento textEditor2 = new("Hello Moon");

            TextEditor editor = new(textEditor);
            TextEditor editor2 = new(textEditor2);

            Memento editorMemento = editor.CreateMemento();
            Memento editorMemento1 = editor2.CreateMemento();
            Store store = new();
            store.Add(editorMemento);
            Memento previousMemento = store.Previous();
            store.Add(editorMemento1);
            TextEditor restoredEditor = new(previousMemento);
            Console.WriteLine(restoredEditor.GetState());

            Console.ReadLine();
        }
    }
}