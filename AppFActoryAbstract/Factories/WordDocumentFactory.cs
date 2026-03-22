using AppFActoryAbstract.Services;

namespace AppFActoryAbstract.Models;

// WordDocumentFactory.cs
public class WordDocumentFactory : IDocumentFactory
{
    public IDocumentEditor CreateEditor() => new WordEditor();
    public IDocumentExporter CreateExporter() => new WordExporter();
}

// PdfDocumentFactory.cs
public class PdfDocumentFactory : IDocumentFactory
{
    public IDocumentEditor CreateEditor() => new PdfEditor();
    public IDocumentExporter CreateExporter() => new PdfExporter();
}