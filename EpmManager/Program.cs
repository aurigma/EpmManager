/*
 *  Created on 10/18/2014 by Andrew Simontsev (Aurigma, Inc). 
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EpmManager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            // It makes sense to run it only on 64-bit machines with Windows 8 or higher only 
            if (!(
                       System.Environment.OSVersion.Platform == PlatformID.Win32NT
                    && ((System.Environment.OSVersion.Version.Major == 6 && System.Environment.OSVersion.Version.Minor >= 2)
                      || System.Environment.OSVersion.Version.Major > 6)
                    && System.Environment.Is64BitOperatingSystem
                ))
            {
                MessageBox.Show(@"You should run this application only on Windows 8 or higher 64-bit version.");
                Application.Exit();
            }
            else 
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
        }
    }
}
