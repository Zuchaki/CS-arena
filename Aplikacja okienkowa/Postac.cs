using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;


namespace Aplikacja_okienkowa
{
	class Postac
	{

		//zmienne wykorzystane do opisania:

		//poziomu zdrowia
		public int hp;

		//energi, specjalnej statystyki, maxhp
		public int energi, special, maxhp;
		public string mess;
		//public string Opis_skill_1, Opis_skill_2, Opis_skill_3, Opis_skill_4;


		//funkcje wirtualne umiejętności (dokąldniej zostały opisane w pliku "NowaPostac.cs")
		public virtual void Skill_1(ref Postac x) { }
		public virtual void Skill_2(ref Postac x) { }
		public virtual void Skill_3(ref Postac x) { }
		public virtual void Skill_4(ref Postac x) { }

		//funkcja wirtualna która zwraca wartość mess i wyświetla informacje o danej turze w prawym rogu
		public virtual string Edit(string mess) { return "";  }

	}
}
