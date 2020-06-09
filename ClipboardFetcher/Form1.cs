using Microsoft.CSharp.RuntimeBinder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WK.Libraries.SharpClipboardNS;
using static WK.Libraries.SharpClipboardNS.SharpClipboard;

namespace ClipboardFetcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            clipboard.ClipboardChanged += ClipboardChanged;
        }
        SharpClipboard clipboard = new SharpClipboard();
        private void ClipboardChanged(Object sender, ClipboardChangedEventArgs e)
        {
            // Is the content copied of text type?
            if (e.ContentType == SharpClipboard.ContentTypes.Text)
            {
                var text = clipboard.ClipboardText;
                if (!text.StartsWith("KATACODE:"))
                    return;

                ParseKata(text);
            }

            // Is the content copied of image type?
            else if (e.ContentType == SharpClipboard.ContentTypes.Image)
            {
                // Get the cut/copied image.
                //Image img = clipboard.ClipboardImage;
            }

            // Is the content copied of file type?
            else if (e.ContentType == SharpClipboard.ContentTypes.Files)
            {
                // Get the cut/copied file/files.
                //Debug.WriteLine(clipboard.ClipboardFiles.ToArray());

                // ...or use 'ClipboardFile' to get a single copied file.
                //Debug.WriteLine(clipboard.ClipboardFile);
            }

            // If the cut/copied content is complex, use 'Other'.
            else if (e.ContentType == SharpClipboard.ContentTypes.Other)
            {
                // Do something with 'clipboard.ClipboardObject' or 'e.Content' here...
            }
        }

        private void ParseKata(string text)
        {
            text = text.Replace("\r", "");
            text = text.Replace(((char) 8203).ToString(), "");

            string[] theLines = text.Split('\n');
            var usings = theLines.Where(l => l.ToLower().Trim().StartsWith("using")).Distinct();
            
            var slug = theLines.First().Substring(9).Trim().GenerateSlug();
            txtSlug.Text = slug;

            var cleaned = theLines
                .Skip(1)
                .Select((l, i) => i % 2 == 1 ? l : (string) null)
                .Where(l => l != null && !l.Trim().StartsWith("using"));

            var result = string.Join(Environment.NewLine, usings) 
                + $"{Environment.NewLine}{Environment.NewLine}namespace {slug.Replace("-", "_")}{Environment.NewLine}{{{Environment.NewLine}"
                + string.Join(Environment.NewLine, cleaned)
                + Environment.NewLine
                + "}";

            // Get the cut/copied text.
            textBox1.Text = result;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            var path = txtCodePath.Text;

            File.WriteAllText(Path.Combine(path, txtSlug.Text + ".cs"), textBox1.Text);
        }
    }
}
