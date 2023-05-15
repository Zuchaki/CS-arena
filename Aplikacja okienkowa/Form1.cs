using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikacja_okienkowa
{
	partial class Arena : Form
	{
		//licznik tur
		int i = 0;


		//Klasy stworzone tylko do odczytu wykorzystywane w celu napisania nazw umiejętności na kartach
		static readonly Rycerz TestRycerz = new Rycerz();
		static readonly Wampir TestWampier = new Wampir();
		static readonly Elf TestElf = new Elf();

		//stworzone postaci (x1 to gracz x2 to komputer)
		//do komputera wykorzystany został konstruktor parametryczny by wzmocnić wroga ktory korzsysta z sztyucznej inteligencji
		//do obiektow gracza został wykorzystany konstruktor domyślny z zbalansowanymi statystykami
		static Rycerz r1 = new Rycerz();
		static Rycerz r2 = new Rycerz(4000,0,30);
		static Wampir w1 = new Wampir();
		static Wampir w2 = new Wampir(1000,100,150);
		static Elf e1 = new Elf();
		static Elf e2 = new Elf(2000, 102, 1);
		static Rycerz r3 = new Rycerz();

		//wtorzenie obiektów bazowych do których przypisany za pomocą polimorfizmu zostanie przypisana obiekt z odpowiednią klasą postaci
		Postac Gracz = (Postac)TestRycerz;
		Postac Wrog = (Postac)w2;


		//losowanie postaci jaką grał bedzie komputer
		Random rnd = new Random();
		int rand;
		void los_wrog()
		{
			rand = rnd.Next(3);
			if (rand == 0)
			{
				Wrog = (Postac)w2;
			}
			else if(rand == 1)
			{
				Wrog = (Postac)r2;
			}
			else
			{
				Wrog = (Postac)e2;
			}
		}
		


		//Funkcja wykorzystana niżej do wyłączenia widoku wyboru postaci
		void Hiden()
		{
			wyborbox.Hide();
			button5.Hide();
			button6.Hide();
			button7.Hide();
			label2.Hide();
			Wyswietl();
			Wynik.Text = "";
			Wynik.Hide();
		}

		//Wybur postaci którą grął będzie gracz
		private void button5_Click(object sender, EventArgs e)
		{
			//uruchamia się funkcja losująca klasę postaci rywala
			los_wrog();

			//przypisanie do objektu Gracz obiektu r1
			Gracz = (Postac)r1;

			//Funkcja wykorzystana do wyłączenia widoku wyboru postaci
			Hiden();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			los_wrog();
			Gracz = (Postac)w1;
			Hiden();
		}
		private void button7_Click(object sender, EventArgs e)
		{
			los_wrog();
			Gracz = (Postac)e1;
			Hiden();
		}



		public Arena()
		{
			InitializeComponent();

			//wyświetla informacje: Opis umiejętności na kartach, statystyki gracza i wroga, informacje co stało się w danej turze
			Wyswietl();

			//Label którego celem jest wyświetlić informacje o wygranej, przegranej, remisie (aktualnie gra trwa więc nie wyświelta nic
			Wynik.Text = "";
		}

		//funkcja wykorzystana do sprawdzenia wyniku i wyświetleniu informacji o wygranej, przegranej, remisie
		private void WynikWalki()
		{
			if (Gracz.hp > 0 && Wrog.hp > 0)
			{
				Wynik.Hide();
				Wynik.Text = "";
			}
			else if (Gracz.hp <= 0 && Wrog.hp <= 0)
			{
				Wynik.Show();
				Wynik.Text = "REMIS";
			}
			else if (Gracz.hp <= 0 && Wrog.hp > 0)
			{
				Wynik.Show();
				Wynik.Text = "PRZEGRANA";
			}
			else
			{
				Wynik.Show();
				Wynik.Text = "WYGRANA";
			}
		}

		//funkcja stworzona do wyświetlenia: 
		private void Wyswietl()
		{
			//Wyświetlenie statystyk w odpowiednich labelach
			EnemyHp.Text = "HP: " + Wrog.hp + "/" + Wrog.maxhp.ToString();
			PlayerHp.Text = "HP: " + Gracz.hp + "/" + Gracz.maxhp.ToString();
			EnemyW1.Text = "Energia: " + Wrog.energi.ToString();
			PlayerW1.Text = "Energia: " + Gracz.energi.ToString();
			EnemyW2.Text = "Adrenalina: " + Wrog.special.ToString();
			PlayerW2.Text = "Adrenalina: " + Gracz.special.ToString();

			//wyświetlenie informacji o rundzie w prawym boku ekrannu
			label1.Text = "\n\n\nTURA " + i+"\n\n";
			label1.Text = label1.Text + "\nGracz: " + Gracz.Edit(Gracz.mess) + "\n".ToString();
			label1.Text = label1.Text + "\nKomputer: " + Wrog.Edit(Wrog.mess) + "\n".ToString();

			//wyświetlenie nazwy umiejętności na kartach
			if (Gracz.GetType() == TestRycerz.GetType())
			{
				button1.Text = "Cios zakonu:\n\nZadaj obrażenia równe 20% Energii + 200% Adrenaliny (" + (Gracz.energi * 0.3 + Gracz.special * 2) + ") oraz syskaj 2 Adrenaliny";
				button2.Text = "Potężne leczenie:\n\nJeśli masz więcej niż 50 Energii\n+200 HP\n-50 Energii\n\n------------------------------------------\n\nMedytacja\n\nJeśli masz mniej niż 50 Energii\n+50 HP\n+30 Energii";
				button3.Text = "Furia:\n\nWykonaj 10 szybkich ataków gdzie każdey z nich może zadać\n1 obrażeń (10% szans)\n2 obrażeń (10% szans)\n150 obrażeń (10% szans)\n50 obrażeń (10% szans)\nspudłować (60% szans)";
				button4.Text = "Zachartowanie:\n\n+20 HP\n+10 Energii\n+2 Siły";
			}
			if (Gracz.GetType() == TestWampier.GetType())
			{
				button1.Text = "Głód:\n(dla HP mniejszego niż 1000)\n\nZadajesz 30% obrażeń brakujacego zdrowia (" + (int)((Gracz.maxhp - Gracz.hp) * 0.4) + ")\n+Energie 10% zadanych obrażeń ("+ (int)((Gracz.maxhp-Gracz.hp)*0.04)+ ")\n+30% zadanych obrażeń (" + (int)((Gracz.maxhp - Gracz.hp) * 0.12) + ")\n\n------------------------------------------\n\nNasycony:\n(dla HP wiekszego niż 1000)\n\nZadaj 10 obrażeń\n+3 Energii\n+5HP";
				button2.Text = "Księga krwi:\n(dla adrenaliny większej niż 100)\n\nWysysasz 200HP od wroga za koszt 100 adrenaliny\n\n------------------------------------------\n\nZwój krwi:\n(Dla adrenaliny mniejszej niż 100)\n\nWysysasz 40hp i zamieniasz całą Energie na Adrenaline";
				button3.Text = "Pradawna moc:\n(dla HP większego niż 1000)\n\nZadejesz obrazenia równe 33% nadmiarowi hp (" + ((Gracz.hp - Gracz.maxhp)/3) + ")\n\n------------------------------------------\n\nSen:\n(Dla HP mniejszego niż 1000)\n\n+30 Energii";
				button4.Text = "Sadyzm:\n\nWysysasz całą energie wroga i przechwytujesz jej 40%";
			}
			if (Gracz.GetType() == TestElf.GetType())
			{
				button1.Text = "Deszcz strzał:\n\nWystrzeliwujesz serię strzał gdzie każda strzała kosztuje 3 energii i zadaje\n50 obrażeń(75% szans)\nPudło(25% szans)\n\nSzczęście - zadaj podwójne obrażenia(33% szans)\n\nAdrenalina = 1 - pomnóż obrażenia razy 2";
				button2.Text = "Zemsta:\n(dla adrenaliny równej 0)\n\n+1 Adrenaliny\n+12 Energii\n\n------------------------------------------\n\nOczekiwanie na rozkaz:\n(Dla adrenaliny równej 1)\n\n+36 Energii";
				button3.Text = "Celny strzał:\n\nZadaj 100 obrażeń\n\nSzczęście - zadaj podwójne obrażenia(33% szans)\n\nAdrenalina = 1 - pommnóż obrażenia razy 2";
				button4.Text = "Leczenie magią:\n(dla energii większej lub równej 30)\n\nWylecz się o 400% energi ("+(Gracz.energi*4)+")\n\n------------------------------------------\n\nLeczenie eliksirami:\n(Dla energii mniejszej niż 30)\n\nWylecz sie o 100";
			}
		}


		//funkcja losuje jaki ruch wykona Komputer
		private void Ruch_wrog()
		{
			rand = rnd.Next(4);
			switch (rand)
			{
				case 0:
					Wrog.Skill_1(ref Gracz);
					break;
				case 1:
					Wrog.Skill_2(ref Gracz);
					break;
				case 2:
					Wrog.Skill_3(ref Gracz);
					break;
				case 3:
					Wrog.Skill_4(ref Gracz);
					break;
			}
			i++;
		}


		//wykorzystanie umiejętności przez gracza
		private void button1_Click(object sender, EventArgs e)
		{
			//Gra popiera instrukcje z Klasy->Postac, obiektu->gracz 
			Gracz.Skill_1(ref Wrog);

			//wszystkie funkcje opisane tuż nad tą funkcją
			Ruch_wrog();
			Wyswietl();
			WynikWalki();
			Wyswietl();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Gracz.Skill_2(ref Wrog);

			Ruch_wrog();
			Wyswietl();
			WynikWalki();
			Wyswietl();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Gracz.Skill_3(ref Wrog);

			Ruch_wrog();
			Wyswietl();
			WynikWalki();
			Wyswietl();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			Gracz.Skill_4(ref Wrog);

			Ruch_wrog();
			Wyswietl();
			WynikWalki();
			Wyswietl();
		}

	}
}
