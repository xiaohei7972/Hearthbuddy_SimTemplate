using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//英雄技能 中立 费用：2
	//Holy Bullet
	//神圣枪弹
	//Deal $2 damage.Give a random friendly minion +2/+2.Swaps each turn.
	//造成$2点伤害。随机使一个友方随从获得+2/+2。每回合切换。
	class Sim_WW_0700p4 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				int damage = ownplay ? p.getHeroPowerDamage(2) : p.getEnemyHeroPowerDamage(2);
				p.minionGetDamageOrHeal(target, damage);
				if (p.ownMinions.Count > 0)
				{
					Minion RandomMinion = p.ownMinions[p.getRandomNumber(0, p.ownMinions.Count - 1)];
					p.minionGetBuffed(RandomMinion, 2, 2);
				}
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
