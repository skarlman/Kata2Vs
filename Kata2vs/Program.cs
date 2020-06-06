using System;
using System.Diagnostics;
using WK.Libraries.SharpClipboardNS;
using static WK.Libraries.SharpClipboardNS.SharpClipboard;

namespace Kata2vs
{
    class Program
    {
        static SharpClipboard clipboard = new SharpClipboard();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            // Attach your code to the ClipboardChanged event to listen to cuts/copies.
            clipboard.ClipboardChanged += ClipboardChanged;

            Console.ReadLine();

        }

        private static void ClipboardChanged(Object sender, ClipboardChangedEventArgs e)
        {
            // Is the content copied of text type?
            if (e.ContentType == SharpClipboard.ContentTypes.Text)
            {
                // Get the cut/copied text.
                Console.WriteLine(clipboard.ClipboardText);
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
    }
}
