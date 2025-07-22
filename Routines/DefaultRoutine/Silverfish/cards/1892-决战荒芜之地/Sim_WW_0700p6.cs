using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//英雄技能 中立 费用：2
	//Shadow Bullet
	//暗影枪弹
	//Deal $2 damage.Summon a random3-Cost minion.Swaps each turn.
	//造成$2点伤害。随机召唤一个法力值消耗为（3）的随从。每回合切换。
	class Sim_WW_0700p6 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				int damage = ownplay ? p.getHeroPowerDamage(2) : p.getEnemyHeroPowerDamage(2);
				p.minionGetDamageOrHeal(target, damage);
				int pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
				CardDB.Card kid = p.getRandomCardForManaMinion(3);
				p.callKid(kid, pos, ownplay);
			}
		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要一个目标
			};
		}

	}
}
