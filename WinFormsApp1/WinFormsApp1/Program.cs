using System.Drawing;
using System.Reflection;

namespace WinFormsApp1
{
    internal static class Program
    {

        public interface IArayuz
        {
            void Metot();
        }

    
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }

    
    }
}