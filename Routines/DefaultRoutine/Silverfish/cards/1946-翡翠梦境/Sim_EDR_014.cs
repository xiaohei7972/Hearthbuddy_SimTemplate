using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 猎人 费用：5 攻击力：4 生命值：7
	//Verdant Dreamsaber
	//茏葱梦刃豹
	//<b>Battlecry:</b> If this costs (3)or less, attack two random enemy minions.
	//<b>战吼：</b>如果本牌的法力值消耗小于或等于（3）点，随机攻击两个敌方随从。
	class Sim_EDR_014 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			if (own.handcard.card.cost <= 3)
			{
				if (p.enemyMinions.Count == 1)
				{
					p.minionAttacksMinion(own, p.enemyMinions[0]);
					return;
				}
				if (p.enemyMinions.Count == 2)
				{
					p.minionAttacksMinion(own, p.enemyMinions[0]);
					p.minionAttacksMinion(own, p.enemyMinions[1]);
					return;
				}
				if (p.enemyMinions.Count > 2)
				{
					p.minionAttacksMinion(own, p.enemyMinions[p.getRandomNumber(0, p.enemyMinions.Count)]);
					p.minionAttacksMinion(own, p.enemyMinions[p.getRandomNumber(0, p.enemyMinions.Count - 1)]);
				}


			}
		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_MINIMUM_ENEMY_MINIONS,1) // 对面场上的全部随从最少需要1个
			};

		}

	}
}
