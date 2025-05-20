// See https://aka.ms/new-console-template for more information

using _18.备忘录模式;

var editor = new TextEditor();
var history = new History();

editor.Type("Hello ");
history.Push(editor.Save());

editor.Type("World!");
Console.WriteLine("当前内容：" + editor.GetContent()); // Hello World!

editor.Restore(history.Pop());
Console.WriteLine("撤销后内容：" + editor.GetContent()); // Hello 