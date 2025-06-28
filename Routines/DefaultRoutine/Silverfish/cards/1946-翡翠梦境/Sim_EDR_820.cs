using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 恶魔猎手 费用：3
	//Wyvern's Slumber
	//飞龙之眠
	//<b>Choose One -</b> Summon two <b>Dormant</b> Dreadseeds; or Deal $2 damage to all minions.
	//<b>抉择：</b>召唤两个<b>休眠</b>的魔种；或者对所有随从造成$2点伤害。
	class Sim_EDR_820 : SimTemplate
	{
		CardDB.Card kid1 = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EDR_840t1);
		CardDB.Card kid2 = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EDR_840t2);

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (choice == 1 || (p.ownFandralStaghelm > 0 && ownplay))
			{
				int pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
				p.callKid(kid1, pos, ownplay);
				p.callKid(kid2, pos, ownplay);
			}

			if (choice == 2 || (p.ownFandralStaghelm > 0 && ownplay))
			{
				int damage = ownplay ? p.getSpellDamageDamage(2) : p.getEnemySpellDamageDamage(2);
				p.allMinionsGetDamage(damage);
			}

		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1) // 最少需要一个空位
			};
		}

	}
}
