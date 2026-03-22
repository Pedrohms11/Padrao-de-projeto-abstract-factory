using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using AppFActoryAbstract.Models;
using Microsoft.Win32;

namespace AppFActoryAbstract;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private IDocumentFactory _currentFactory;
    private IDocumentEditor _currentEditor;
    public MainWindow()
    {
        InitializeComponent();
        // Inicia com Word
        _currentFactory = new WordDocumentFactory();
        BuildUI();
    }
    private void BuildUI()
    {
        // Cria o editor usando a fábrica atual
        _currentEditor = _currentFactory.CreateEditor();
        var editorControl = _currentEditor.Render();

        // Remove o controle anterior do container
        EditorContainer.Child = null;
        EditorContainer.Child = editorControl;
    }

    private void SwitchButton_Click(object sender, RoutedEventArgs e)
    {
        // Troca a fábrica conforme o formato selecionado
        var selectedFormat = (FormatComboBox.SelectedItem as ComboBoxItem)?.Content.ToString();
        _currentFactory = selectedFormat == "PDF"
            ? (IDocumentFactory)new PdfDocumentFactory()
            : new WordDocumentFactory();

        BuildUI(); // Reconstrói a interface de edição
    }
    private void ExportButton_Click(object sender, RoutedEventArgs e)
    {
        var content = _currentEditor.GetContent();
        if (string.IsNullOrWhiteSpace(content))
        {
            MessageBox.Show("Digite algum conteúdo antes de exportar.");
            return;
        }

        // Pede um local para salvar
        var saveDialog = new SaveFileDialog
        {
            Filter = _currentFactory is WordDocumentFactory ? "Documento Word (*.docx)|*.docx" : "Documento PDF (*.pdf)|*.pdf",
            DefaultExt = _currentFactory is WordDocumentFactory ? "docx" : "pdf"
        };

        if (saveDialog.ShowDialog() == true)
        {
            var exporter = _currentFactory.CreateExporter();
            exporter.Export(content, saveDialog.FileName);
        }
    }
}