using System;
using System.Reflection;
using System.Windows.Forms;

namespace GravityTidalCorrection
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            const string zedgraphlib = "GravityTidalCorrection.ZedGraph.dll";
            const string projnetlib = "GravityTidalCorrection.ProjNet.dll";
            const string filehelplib = "GravityTidalCorrection.FileHelpers.dll";

            EmbeddedAssembly.Load(zedgraphlib,"ZedGraph.dll");
            EmbeddedAssembly.Load(projnetlib,"ProjNet.dll");
            EmbeddedAssembly.Load(filehelplib,"FileHelpers.dll");
            
            AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(CurrentDomain_AssemblyResolve);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

        }

        static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            return EmbeddedAssembly.Get(args.Name);
        }
    }
}
