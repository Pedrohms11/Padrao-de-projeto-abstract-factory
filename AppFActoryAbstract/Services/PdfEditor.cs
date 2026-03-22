using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using AppFActoryAbstract.Models;

namespace AppFActoryAbstract.Services;

public class PdfEditor : IDocumentEditor

{
    private RichTextBox _richTextBox;

    public UIElement Render()
    {
        _richTextBox = new RichTextBox
        {
            Height = 200,
            Margin = new Thickness(10)
        };
        return _richTextBox;
    }

    public string GetContent()
    {
        if (_richTextBox == null) return string.Empty;
        return new TextRange(_richTextBox.Document.ContentStart, _richTextBox.Document.ContentEnd).Text;
    }
}

// PdfExporter.cs
public class PdfExporter : IDocumentExporter
{
    public void Export(string content, string filePath)
    {
        // Simula exportação para PDF (usando uma biblioteca fictícia)
        // Na prática, você usaria iTextSharp, PdfSharp, etc.
        File.WriteAllText(filePath, content);
        MessageBox.Show($"Documento PDF salvo em: {filePath}");
    }

}