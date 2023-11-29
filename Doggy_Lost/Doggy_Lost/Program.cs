using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Doggy_Lost
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string lastLine = File.ReadLines("Saving.txt").LastOrDefault();
            string[] parts = lastLine.Split(',');
            string formName = parts[0];

            // Знайти тип за його іменем
            Type formType = Type.GetType(formName);

            // Створити екземпляр форми за типом
            Form form = (Form)Activator.CreateInstance(formType);

            // Запустити програму з цією формою
            Application.Run(form);
                
        }
    }
}
