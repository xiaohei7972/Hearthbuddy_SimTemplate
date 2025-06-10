using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_835 : SimTemplate //* 聒噪的挖掘者 Chittering Tunneler
//<b>Battlecry:</b> <b>Discover</b> a spell. Deal damage to your hero equal to its Cost.
//<b>战吼：</b><b>发现</b>一张法术牌。对你的英雄造成等同于其法力值消耗的伤害。 
	{
		

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.drawACard(CardDB.cardNameEN.thecoin, own.own, true);
            p.minionGetDamageOrHeal(own.own ? p.ownHero : p.enemyHero, 3);
		}
	}
}