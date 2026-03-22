namespace AppFActoryAbstract.Models;

// IDocumentFactory.cs
public interface IDocumentFactory
{
    IDocumentEditor CreateEditor();
    IDocumentExporter CreateExporter();
}