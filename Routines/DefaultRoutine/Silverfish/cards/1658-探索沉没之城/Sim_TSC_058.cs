using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 恶魔猎手 费用：2
	//Predation
	//捕掠
	//Deal $2 damage.Costs (0) if you played a Naga while holding this.
	//造成$2点伤害。如果你在此牌在你手中时使用过纳迦牌，则法力值消耗为（0）点。
	class Sim_TSC_058 : SimTemplate
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
