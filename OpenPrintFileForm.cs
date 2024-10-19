using System.Text;

namespace PW4SPP;

public partial class OpenPrintFileForm : Form
{
    public StreamReader Reader;

    public OpenPrintFileForm() => InitializeComponent();

    private void Form_Load(object sender, EventArgs e)
    {
        textBox.Clear();
        PrintDocumentMenuItem.Visible = false;
        OpenFileDialog.FileName = null;
    }

    private void OpenDocumentMenuItem_Click(object sender, EventArgs e)
    {
        OpenFileDialog.Filter = "Текстовые файлы (*.txt) |*.txt|All files (*.*)|*.*";
        OpenFileDialog.ShowDialog();

        if (OpenFileDialog.FileName == null)
            return;

        try
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            StreamReader reader = new(OpenFileDialog.FileName, Encoding.GetEncoding(1251));

            textBox.Text = reader.ReadToEnd();
            reader.Close();
            PrintDocumentMenuItem.Visible = true;
        }
        catch (FileNotFoundException ex)
        {
            MessageBox.Show(ex.Message + "\nНет такого файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }

    private void PrintDocumentMenuItem_Click(object sender, EventArgs e)
    {
        try
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            Encoding encoding = Encoding.GetEncoding(1251);
            Reader = new(OpenFileDialog.FileName, encoding);

            try
            {
                PrintDocument.Print();
            }
            finally
            {
                Reader.Close();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void PrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
    {
        float linesOnPage;
        float y = .0f;

        int leftSide = e.MarginBounds.Left;
        int topSide = e.MarginBounds.Top;
        string? line = string.Empty;
        Font font = new("Times New Roman", 12.0f);

        linesOnPage = e.MarginBounds.Height / font.GetHeight(e.Graphics);

        int i = 0;
        while (i < linesOnPage)
        {
            line = Reader.ReadLine();

            if (line == null)
                break;

            y = topSide + i * font.GetHeight(e.Graphics);

            e.Graphics.DrawString(line, font, Brushes.Black, leftSide, y, new StringFormat());

            i++;
        }

        if (line != null)
            e.HasMorePages = true;
        else
            e.HasMorePages = false;
    }

    private void ExitToolStripMenuItem_Click(object sender, EventArgs e) => Close();
}
