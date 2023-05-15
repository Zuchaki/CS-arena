using System;
using System.Collections.Generic;
using System.Text;

namespace Aplikacja_okienkowa
{
	class NowaPostac: Postac
	{

		//konstruktor domyślny
		public NowaPostac()
		{
			hp = 1;
			energi = 1; // energia
			special = 1; //adrenalina
			maxhp = hp;
			mess = "";
		}

		//konstruktor parametryczny
		public NowaPostac(int x, int y, int z)
		{
			hp = x;
			energi = y;
			special = z;
			maxhp = x;
			mess = "";
		}

		//instrukcja do funkcji które są uzupełnieniem funkcji virtualnej z klasy Postac
		//Te funkcje mówią co ma się stać gdy gracz kliknie karty 1, 2, 3 i 4
		//|ref Postac x| odwołuje się do naszego wroga (Komputera) przeciwko któremu będziemy grać. Dzięki takiemu zabiegowi możemy zmieniać jego parametry "atakować"
		public override void Skill_1(ref Postac x)
		{
			//x.hp - hp wroga
			//x.energia - energia wroga
			//x.special - adrenalina wroga

			//mess = "" - zmienna która przekazana dalej (automatycznie) mówi co ma byc wyswietlone w prawym bloku po turze

		}
		public override void Skill_2(ref Postac x)
		{

	
		}
		public override void Skill_3(ref Postac x)
		{

		}
		public override void Skill_4(ref Postac x)
		{


		}

		//funkcja która zwraca wartość mess i wyświetla informacje o danej turze w prawym rogu
		public override string Edit(string mess)
		{
			return mess;
		}

	}
}
