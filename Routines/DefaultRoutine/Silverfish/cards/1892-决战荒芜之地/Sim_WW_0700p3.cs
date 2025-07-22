using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//英雄技能 中立 费用：2
	//Fire Bullet
	//火焰枪弹
	//Deal $2 damage,then deal $1 damage toall enemy minions.Swaps each turn.
	//造成$2点伤害，再对所有敌方随从造成$1点伤害。每回合切换。
	class Sim_WW_0700p3 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				int damage = ownplay ? p.getHeroPowerDamage(2) : p.getEnemyHeroPowerDamage(2);
				p.minionGetDamageOrHeal(target, damage);
				p.allMinionOfASideGetDamage(!ownplay, 1);
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
