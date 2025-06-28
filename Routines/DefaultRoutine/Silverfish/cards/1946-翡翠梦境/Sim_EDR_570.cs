using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 战士 费用：1
	//Ominous Nightmares
	//凶险梦魇
	//[x]<b>Choose One - </b>Deal $1damage to all minions;or Give a damagedminion +2/+2.
	//<b>抉择：</b>对所有随从造成$1点伤害；或者使一个受伤的随从获得+2/+2。
	class Sim_EDR_570 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice, Handmanager.Handcard hc)
		{
			if (choice == 1 || (p.ownFandralStaghelm > 0 && ownplay))
			{
				int damage = ownplay ? p.getSpellDamageDamage(1) : p.getEnemySpellDamageDamage(1);
				p.allMinionsGetDamage(damage);
			}
			if (choice == 2 || (p.ownFandralStaghelm > 0 && ownplay))
			{
				if (target != null)
				{
					p.minionGetBuffed(target, 2, 2);
				}
			}

		}


		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要选择一个目标
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 目标只能是随从
				new PlayReq(CardDB.ErrorType2.REQ_DAMAGED_TARGET),// 只能是受伤的随从
			};
		}

	}
}
