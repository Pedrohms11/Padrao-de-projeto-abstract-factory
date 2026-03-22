using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace AppFActoryAbstract.Models;

public class WordEditor : IDocumentEditor
{
    private TextBox _textBox;

    public UIElement Render()
    {
        _textBox = new TextBox()
        {
            AcceptsReturn = true,
            TextWrapping = TextWrapping.Wrap,
            Height = 200,
            Margin = new Thickness(10)
        };
        return _textBox;
    }

    public string GetContent() => _textBox?.Text ?? string.Empty;
}
// WordExporter.cs
public class WordExporter : IDocumentExporter
{
    public void Export(string content, string filePath)
    {
        // Simula exportação para Word (.docx)
        File.WriteAllText(filePath, content);
        MessageBox.Show($"Documento Word salvo em: {filePath}");
    }
}
