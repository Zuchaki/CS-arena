using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikacja_okienkowa
{
	static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.SetHighDpiMode(HighDpiMode.SystemAware);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Arena());

			//Rycerz r1 = new Rycerz();
			//Rycerz r2 = new Rycerz();

			//Postac Gracz = (Postac)r1;
			//Postac Wrog = (Postac)r2;

			//Gracz.Skill_1(ref Wrog);


				//Gracz.Skill_1(ref Wrog);
			
		}
	}
}
