using System;
using System.Windows.Forms;

namespace proj_test_1;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main(string[] args)
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        // LastChangeOfThisCommit
        //bug fixx
        ApplicationConfiguration.Initialize();
        Application.Run(new Form1());
    }
}