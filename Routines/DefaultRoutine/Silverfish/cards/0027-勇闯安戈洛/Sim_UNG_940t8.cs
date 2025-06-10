using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_940t8 : SimTemplate //* 希望守护者阿玛拉 Amara, Warden of Hope
//[x]<b>Taunt</b><b>Battlecry:</b> Set yourhero's Health to 40.
//<b>嘲讽，战吼：</b>将你英雄的生命值变为40。 
	{
		

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			if (own.own) p.ownHero.Hp = 40;
			else p.enemyHero.Hp = 40;
		}
	}
}