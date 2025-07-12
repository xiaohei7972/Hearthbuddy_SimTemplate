using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 圣骑士 费用：4
	//Keeper's Strength
	//守护者的力量
	//Give a friendly minion +2/+2. Dealits Attack damage toall other minions.
	//使一个友方随从获得+2/+2。对所有其他随从造成等同于其攻击力的伤害。
	class Sim_YOG_509 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			// 如果目标是友方野兽
			if (target != null && (CardDB.Race)target.handcard.card.race == CardDB.Race.BEAST)
			{
				// 增加2点攻击力和2点生命值
				p.minionGetBuffed(target, 2, 2);
				int damage = ownplay ? p.getSpellDamageDamage(target.Angr) : p.getEnemySpellDamageDamage(target.Angr);
				p.allMinionsGetDamage(damage, target.entitiyID);
			}
		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要一个目标
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 目标只能是随从
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET), // 目标只能是友方
            };
		}

	}
}
