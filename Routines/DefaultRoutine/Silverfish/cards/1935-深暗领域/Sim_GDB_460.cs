using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 潜行者 费用：2
	//Divine Star
	//神圣之星
	//Deal $3 damageto a minion. Give a random minion in your hand +3_Health.
	//对一个随从造成$3点伤害。随机使你手牌中的一张随从牌获得+3生命值。
	class Sim_GDB_460 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				int damage = ownplay ? p.getSpellDamageDamage(3) : p.getEnemySpellDamageDamage(3);
				p.minionGetDamageOrHeal(target, damage);
				foreach (Handmanager.Handcard handcard in p.owncards)
				{
					if (handcard.card.type == CardDB.cardtype.MOB)
					{
						handcard.addHp += 3;
						return;
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
