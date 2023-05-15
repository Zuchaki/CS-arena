using System;
using System.Collections.Generic;
using System.Text;

namespace Aplikacja_okienkowa
{
	class Rycerz:Postac
	{

		public Rycerz()
		{
			hp = 2250;
			energi = 130; //furia
			special = 0; //adrenalina
			maxhp = 2250;
			mess = "";
		}
		public Rycerz(int x, int y, int z)
		{
			hp = x;
			energi = y;
			special = z;
			maxhp = x;
			mess = "";
		}
		public override void Skill_1(ref Postac x)
		{
			double pomocnicza1 = energi * 0.3 + special * 2;
			int pomocnicza = (int)pomocnicza1;

			x.hp = x.hp - pomocnicza;
			int hpenint = x.hp;
			special = special + 2;
			mess = "Zadano " + pomocnicza + " obrażeń\nZyskano 2 adrenaliny";

		}
		public override void Skill_2(ref Postac x) 
		{

				if (energi < 50)
				{
				hp = hp + 30;
				mess = "Wyleczono się o 50 \ndoładowano 30 energii";
				energi = energi + 30;
				}
				else
				{
					energi = energi - 50;
					hp = hp + 200;
					mess = "Wyleczono się o 200";
				}
			
		}
		public override void Skill_3(ref Postac x)
		{
			string obr="";
			mess = "";
			double pomocnicza1 = 0.1;
			int pomocnicza;
			Random rnd = new Random();
			int rand;
			for(int i=0; i<10; i++)
			{
				rand = rnd.Next(10);

				switch (rand)
				{
					case 1:
						pomocnicza1 = 1;
						pomocnicza = (int)pomocnicza1;
						x.hp = x.hp - pomocnicza;
						obr = obr + "1, ";
						break;
					case 2:
						pomocnicza1 = 2;
						pomocnicza = (int)pomocnicza1;
						x.hp = x.hp - pomocnicza;
						obr = obr + "2, ";
						break;
					case 3:
						pomocnicza1 = 150;
						pomocnicza = (int)pomocnicza1;
						x.hp = x.hp - pomocnicza;
						obr = obr + "150, ";
						break;
					case 4:
						pomocnicza1 = 50;
						pomocnicza = (int)pomocnicza1;
						x.hp = x.hp - pomocnicza;
						obr = obr + "50, ";
						break;
					case 5:
						obr = obr + "miss, ";
						break;
					case 6:
						obr = obr + "miss, ";
						break;
					case 7:
						obr = obr + "miss, ";
						break;
					case 8:
						obr = obr + "miss, ";
						break;
					case 9:
						obr = obr + "miss, ";
						break;
					case 0:
						obr = obr + "miss, ";
						break;
				}
				mess = "Zadano [" + obr + "] obrażeń";
			}
		}
		public override void Skill_4(ref Postac x)
		{
			special = special + 2;
			energi = energi + 10;
			hp = hp + 20;
			mess = "uleczono o 20, dodano 2 adrenaliny oraz 10 energii";
		}

		public override string Edit(string mess) 
		{ 
			return mess; 
		}
	}

}
