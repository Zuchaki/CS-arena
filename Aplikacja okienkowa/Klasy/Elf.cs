using System;
using System.Collections.Generic;
using System.Text;

namespace Aplikacja_okienkowa
{
	class Elf:Postac
	{
		public Elf()
		{
			hp = 1000;
			energi = 100; // energia
			special = 1; //adrenalina
			maxhp = hp;
			mess = "";
		}
		public Elf(int x, int y, int z)
		{
			hp = x;
			energi = y;
			special = z;
			maxhp = x;
			mess = "";
		}
		int atak = 0;
		public override void Skill_1(ref Postac x)
		{
			//x.hp - hp wroga
			//x.energia - energia wroga
			//x.special - adrenalina wroga

			//mess = "" - CodePagesEncodingProvider ma byc wyswietlone w prawym bloku po turze

			Random rnd = new Random();
			int rand;
			Random szczescie_rnd = new Random();
			int szczescie;
			int totalDMG = 0;

			for (int i=0; energi>2; i++)
			{
				rand = rnd.Next(4); //0-3

				if (rand == 0)
				{
					/*if (i == 0)
					{
						mess = mess + "MISS";
					}
					else
					{
						mess = mess + ", MISS";
					}*/
					energi = energi - 3;

				}
				else
				{
					szczescie = szczescie_rnd.Next(3); //0-2

					if (szczescie == 0)
					{
						atak = 20 * (special + 1);
						x.hp = x.hp - atak;
						/*
							if (i == 0)
							{
								mess = mess + "" + atak;
							}
							else
							{
								mess = mess + ", " +atak;
							}
						*/
						totalDMG = totalDMG + atak;
						energi = energi - 3;
					}
					else
					{
						atak = 10 * (special + 1);
						x.hp = x.hp - atak;
						/*
							if (i == 0)
							{
								mess = mess + "" + atak;
							}
							else
							{
								mess = mess + ", " +atak;
							}
						*/
						totalDMG = totalDMG + atak;
						energi = energi - 3;
					}
				}
			}
			special = 0;
			mess = "zadano "+totalDMG+" obrażeń";


		}
		public override void Skill_2(ref Postac x)
		{
			if (special == 0)
			{
				special = 1;
				energi = energi + 12;
				mess = "+1 adrenaliny\n+12 energii";
			}
			else
			{
				energi = energi + 36;
				mess = "+36 energii";
			}
		}
		public override void Skill_3(ref Postac x)
		{
			Random szczescie_rnd = new Random();
			int szczescie;

			szczescie = szczescie_rnd.Next(3); //0-2

			if (szczescie == 0)
			{
				atak = 200 * (special + 1);
				x.hp = x.hp - atak;
				mess = "zadano " + atak + "obrażeń";
			}
			else
			{
				atak = 100 * (special + 1);
				x.hp = x.hp - atak;
				mess = "zadano " + atak + "obrażeń";
			}
			special = 0;

		}
		public override void Skill_4(ref Postac x)
		{
			if(energi >= 30)
			{
				hp = hp + (energi*4);
				mess = "wyleczono się o " + (energi * 4) + " za koszt "+energi+" energii";
				energi = 0;
			}
			else
			{
				hp = hp + 100;
				mess = "wyleczono się o 100";
			}
		}

		public override string Edit(string mess)
		{
			return mess;
		}
	}
}
