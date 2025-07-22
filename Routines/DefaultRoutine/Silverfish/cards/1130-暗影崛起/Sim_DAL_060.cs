using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_060 : SimTemplate //发条地精
	{
		//   战吼：将一张“炸弹” 牌洗入你的对手的牌库。当玩家抽到炸弹时，便会受到5点伤害

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			if (own.own)
			{
				if (p.enemyDeckSize == 0)
				{
					p.minionGetDamageOrHeal(p.enemyHero, 5, true);
				}
			}
		}
	}
}