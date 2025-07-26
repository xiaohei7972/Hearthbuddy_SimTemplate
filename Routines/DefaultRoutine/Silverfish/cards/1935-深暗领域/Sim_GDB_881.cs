using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 牧师 费用：3
	//Pressure Points
	//正中要害
	//Deal $3 damage to a minion. Reduce the Cost of <b>Combo</b> cards in your hand by (1).
	//对一个随从造成$3点伤害。使你手牌中的<b>连击</b>牌法力值消耗减少（1）点。
	class Sim_GDB_881 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				int damage = ownplay ? p.getSpellDamageDamage(3) : p.getEnemySpellDamageDamage(3);
				p.minionGetDamageOrHeal(target, damage);
				if (ownplay)
				{
					foreach (Handmanager.Handcard handcard in p.owncards)
					{
						if (handcard.extraParam3)
						{
							handcard.card.cost -= 1;
						}

					}
				}
			}

		}

        public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要选择一个目标
				new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET), //只能是敌方
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET) // 目标只能是随从
			};

		}
		
	}
}
