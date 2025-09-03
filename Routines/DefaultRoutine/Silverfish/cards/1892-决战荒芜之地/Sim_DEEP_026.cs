using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace HREngine.Bots
{
	//法术 潜行者 费用：3
	//Pendant of Earth
	//大地坠饰
	//[x]<b>Discover</b> a minion from your deck. RestoreHealth to your heroequal to its Cost.
	//从你的牌库中<b>发现</b>一张随从牌，为你的英雄恢复等同于其法力值消耗的生命值。
	class Sim_DEEP_026 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (ownplay)
			{
				CardDB.Card selectedCard = CardDB.Instance.getCardDataFromID(Hrtprozis.Instance.enchs.LastOrDefault());
				p.drawACard(selectedCard.cardIDenum, ownplay, true); // 发现一张随从牌
				int heal = (ownplay) ? p.getMinionHeal(-selectedCard.cost) : p.getEnemyMinionHeal(-selectedCard.cost);
				p.minionGetDamageOrHeal(ownplay ? p.ownHero : p.enemyHero, heal); // 为英雄恢复等同于其法力值消耗的生命值
			}
		}
	}
}
