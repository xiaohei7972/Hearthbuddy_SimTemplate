using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 战士 费用：5 攻击力：5 生命值：5
	//Lady Ashvane
	//艾什凡女勋爵
	//<b>Battlecry:</b> Give all weaponsin your hand, deck, and battlefield +1/+1.
	//<b>战吼：</b>使你手牌，牌库和战场上的所有武器获得+1/+1。
	class Sim_TSC_943 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			if (own.own)
			{
				// 增强战场上的武器
				if (p.ownWeapon.Durability > 1)
				{
					p.ownWeapon.Angr++;
					p.ownWeapon.Durability++;
					p.minionGetBuffed(p.ownHero, 1, 0);
				}

				// 增强手牌中的所有随从
				foreach (Handmanager.Handcard hc in p.owncards)
				{
					if (hc.card.type == CardDB.cardtype.WEAPON) // 检查是否为的武器
					{
						hc.addattack++;
						hc.addHp++;
						p.anzOwnExtraAngrHp += 2;
					}
				}

				// 增强牌库中的所有随从
				foreach (CardDB.Card card in p.ownDeck)
				{
					if (card.type == CardDB.cardtype.WEAPON) // 检查是否为的武器
					{
						card.Attack++; // 增加攻击力
						card.Health++; // 增加生命值
					}
				}
			}
		}

	}
}
