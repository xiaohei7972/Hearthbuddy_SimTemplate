using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_258t4 : SimTemplate //* 闪电祈咒 lightninginvocation
	{
		//对所有敌方随从造成2点伤害。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int dmg = (ownplay) ? p.getHeroPowerDamage(2) : p.getEnemyHeroPowerDamage(2);
			p.allMinionOfASideGetDamage(!ownplay, dmg);
		}

	}
}
