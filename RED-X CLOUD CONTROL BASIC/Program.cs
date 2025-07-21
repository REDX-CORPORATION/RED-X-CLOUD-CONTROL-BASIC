using RED_X_CLOUD_CONTROL_BASIC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AImbot_Load
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread] // Required for Windows Forms to support UI components like drag-drop, clipboard, etc.
        static void Main()
        {
            // Enables modern visual styles (rounded buttons, modern themes, etc.)
            Application.EnableVisualStyles();

            // Use GDI+ for better text rendering compatibility
            Application.SetCompatibleTextRenderingDefault(false);

            // Launch the main form (Form1)
            Application.Run(new Form1());
        }
    }
}
