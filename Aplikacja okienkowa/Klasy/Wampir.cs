using System;
using System.Collections.Generic;
using System.Text;

namespace Aplikacja_okienkowa
{
	class Wampir:Postac
	{
		public Wampir()
		{
			hp = 1000;
			energi = 0; //furia
			special = 0; //adrenalina
			maxhp = hp;
			mess = "";
		}
		public Wampir(int x, int y, int z)
		{
			hp = x;
			energi = y;
			special = z;
			maxhp = x;
			mess = "";
		}
		public override void Skill_1(ref Postac x)
		{
			double pomocnicza1 = (maxhp-hp)*0.3;
			if (pomocnicza1 <= 0) { pomocnicza1 = 10; }
			int pomocnicza = (int)pomocnicza1;
			mess = "Zadano " + pomocnicza + " obrażeń\n";

			x.hp = x.hp - pomocnicza;
			pomocnicza1 = (maxhp - hp) * 0.4;
			pomocnicza = (int)pomocnicza1;
			pomocnicza1 = pomocnicza * 0.1;
			pomocnicza = (int)pomocnicza1;
			energi = energi + pomocnicza;
			hp = hp + pomocnicza*3;
			mess = mess+"Zyskano "+pomocnicza+" energii i uleczono się o "+ pomocnicza*3;

		}
		public override void Skill_2(ref Postac x)
		{

			if (special >= 100)
			{
				x.hp = x.hp - 200;
				special = special - 100;
				hp = hp + 200;
				mess = "Wyssano 200 życia";
			}
			else
			{
				x.hp = x.hp - 40;
				hp = hp + 40;
				special = special + energi;
				energi = 0;
				mess = "Wyssano 40 życia";
			}

		}
		public override void Skill_3(ref Postac x)
		{
			double pomocnicza1;
			if (maxhp < hp)
			{
				x.hp = x.hp - ((hp-maxhp)/3); //33% nadmiarowi
				mess = "Zadano "+((hp-maxhp)/3)+ " obrażeń";
			}
			else
			{
				energi = energi + 30;
				mess = "Doładowano 30 energii";
			}
		}
		public override void Skill_4(ref Postac x)
		{

			
			double pomocnicza1 = x.energi * 0.4;
			int pomocnicza = (int)pomocnicza1;
			energi = energi + pomocnicza;
			x.energi = 0;

			mess = "Wyssano całą energię z wroga i pozyskano 40% z niej";

		}

		public override string Edit(string mess)
		{
			return mess;
		}
	}
}
