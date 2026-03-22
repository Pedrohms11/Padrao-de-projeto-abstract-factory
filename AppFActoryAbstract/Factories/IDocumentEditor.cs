using System.Windows;

namespace AppFActoryAbstract.Models;
//Classe de produto abstrato
public interface IDocumentEditor
{
    UIElement Render(); // Retona um controle para edição
    string GetContent(); // Obtem o texto digitado
}

public interface IDocumentExporter
{
    void Export(string content, string filePath);
}