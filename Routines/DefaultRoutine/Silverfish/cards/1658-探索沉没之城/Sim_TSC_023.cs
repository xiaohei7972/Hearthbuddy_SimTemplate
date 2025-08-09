using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 猎人 费用：1
	//Barbed Nets
	//倒刺捕网
	//[x]Deal $2 damage to anenemy. If you played aNaga while holding this,choose a second target.
	//对一个敌人造成$2点伤害。如果你在此牌在你手中时使用过纳迦牌，则再选择一个目标。
	class Sim_TSC_023 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				int damage = ownplay ? p.getSpellDamageDamage(2) : p.getEnemySpellDamageDamage(2);
				p.minionGetDamageOrHeal(target, damage);

			}
		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要一个目标
				new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET), // 只能是敌方
			};
		}
		
	}
}
