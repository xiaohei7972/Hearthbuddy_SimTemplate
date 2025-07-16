using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 猎人 费用：3
	//Stag Charge
	//雄鹿冲锋
	//Deal $3 damage. Summon a random <b>Dormant</b> Wildseed.
	//造成$3点伤害。随机召唤一个<b>休眠</b>的灵种。
	class Sim_REV_364 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.REV_360t);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				int dmg = (ownplay) ? p.getSpellDamageDamage(3) : p.getEnemySpellDamageDamage(3);
				p.minionGetDamageOrHeal(target, dmg);
				int pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
				p.callKid(kid, pos, ownplay);
			}

			//TODO：随即召唤灵种
		}


		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[] {
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要一个目标
				new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1) // 最少需要一个空位
			};
		}

	}
}
