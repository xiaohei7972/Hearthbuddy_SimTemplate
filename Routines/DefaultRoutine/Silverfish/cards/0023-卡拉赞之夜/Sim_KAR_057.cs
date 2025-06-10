using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_KAR_057 : SimTemplate //* 象牙骑士 Ivory Knight
//[x]<b>Battlecry:</b> <b>Discover</b> a spell.Restore Health to your heroequal to its Cost.
//<b>战吼：</b><b>发现</b>一张法术牌。为你的英雄恢复等同于其法力值消耗的生命值。 
	{
		

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.drawACard(CardDB.cardNameEN.thecoin, own.own, true);
			int heal = (own.own) ? p.getMinionHeal(3) : p.getEnemyMinionHeal(3);
            p.minionGetDamageOrHeal(own.own ? p.ownHero : p.enemyHero, -heal);
		}
	}
}