using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 圣骑士 费用：4 攻击力：4 生命值：4
	//Grimestreet Enforcer
	//污手街惩罚者
	//At the end of your turn, give all minions in your hand +1/+1.
	//在你的回合结束时，使你手牌中的所有随从牌获得+1/+1。
	class Sim_WON_046 : SimTemplate
	{
		public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
		{
			if (turnEndOfOwner == triggerEffectMinion.own)
			{
				if (triggerEffectMinion.own)
				{
					foreach (Handmanager.Handcard hc in p.owncards)
					{
						if (hc.card.type == CardDB.cardtype.MOB)
						{
							hc.addattack++;
							hc.addHp++;
							p.anzOwnExtraAngrHp += 2;
						}
					}
				}
				else
				{
					if (p.enemyAnzCards > 0) p.anzEnemyExtraAngrHp += 2 * p.enemyAnzCards - 1;
				}
			}
		}

	}
}
