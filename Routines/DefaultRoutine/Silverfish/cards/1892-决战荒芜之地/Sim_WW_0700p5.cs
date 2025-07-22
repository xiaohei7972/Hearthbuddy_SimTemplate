using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//英雄技能 中立 费用：2
	//Nature Bullet
	//自然枪弹
	//Deal $2 damage.<b>Discover</b> a spell.Swaps each turn.
	//造成$2点伤害。<b>发现</b>一张法术牌。每回合切换。
	class Sim_WW_0700p5 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				int damage = ownplay ? p.getHeroPowerDamage(2) : p.getEnemyHeroPowerDamage(2);
				p.minionGetDamageOrHeal(target, damage);
				p.drawACard(CardDB.cardNameEN.unknown, ownplay, true);
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
