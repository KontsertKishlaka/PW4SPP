namespace PW4SPP
{
    partial class OpenPrintFileForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox = new TextBox();
            menuStrip = new MenuStrip();
            StripMenu = new ToolStripMenuItem();
            OpenDocumentMenuItem = new ToolStripMenuItem();
            PrintDocumentMenuItem = new ToolStripMenuItem();
            ExitToolStripMenuItem = new ToolStripMenuItem();
            OpenFileDialog = new OpenFileDialog();
            PrintDocument = new System.Drawing.Printing.PrintDocument();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // textBox
            // 
            textBox.Location = new Point(12, 31);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.ReadOnly = true;
            textBox.ScrollBars = ScrollBars.Vertical;
            textBox.Size = new Size(1238, 630);
            textBox.TabIndex = 0;
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { StripMenu });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(1262, 28);
            menuStrip.TabIndex = 1;
            menuStrip.Text = "menuStrip1";
            // 
            // StripMenu
            // 
            StripMenu.DropDownItems.AddRange(new ToolStripItem[] { OpenDocumentMenuItem, PrintDocumentMenuItem, ExitToolStripMenuItem });
            StripMenu.Name = "StripMenu";
            StripMenu.Size = new Size(59, 24);
            StripMenu.Text = "Файл";
            // 
            // OpenDocumentMenuItem
            // 
            OpenDocumentMenuItem.Name = "OpenDocumentMenuItem";
            OpenDocumentMenuItem.Size = new Size(224, 26);
            OpenDocumentMenuItem.Text = "Открыть";
            OpenDocumentMenuItem.Click += OpenDocumentMenuItem_Click;
            // 
            // PrintDocumentMenuItem
            // 
            PrintDocumentMenuItem.Name = "PrintDocumentMenuItem";
            PrintDocumentMenuItem.Size = new Size(224, 26);
            PrintDocumentMenuItem.Text = "Печать";
            PrintDocumentMenuItem.Click += PrintDocumentMenuItem_Click;
            // 
            // ExitToolStripMenuItem
            // 
            ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            ExitToolStripMenuItem.Size = new Size(224, 26);
            ExitToolStripMenuItem.Text = "Выход";
            ExitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
            // 
            // OpenFileDialog
            // 
            OpenFileDialog.FileName = "OpenFileDialog";
            // 
            // PrintDocument
            // 
            PrintDocument.PrintPage += PrintDocument_PrintPage;
            // 
            // OpenPrintFileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(textBox);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "OpenPrintFileForm";
            Text = "Форма открытия и печати текстового файла";
            Load += Form_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox;
        private MenuStrip menuStrip;
        private ToolStripMenuItem StripMenu;
        private ToolStripMenuItem OpenDocumentMenuItem;
        private ToolStripMenuItem PrintDocumentMenuItem;
        private ToolStripMenuItem ExitToolStripMenuItem;
        private OpenFileDialog OpenFileDialog;
        private System.Drawing.Printing.PrintDocument PrintDocument;
    }
}
