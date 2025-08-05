using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 德鲁伊 费用：3
	//Seaweed Strike
	//海草卷击
	//[x]Deal $4 damage to a minion.If you played a Naga whileholding this, also give yourhero +4 Attack this turn.
	//对一个随从造成$4点伤害。如果你在此牌在你手中时使用过纳迦牌，使你的英雄在本回合中获得+4攻击力。
	class Sim_TSC_651 : SimTemplate
	{

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				int damage = ownplay ? p.getSpellDamageDamage(4) : p.getEnemySpellDamageDamage(4);
				p.minionGetDamageOrHeal(target, damage);
			}
		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要选择一个目标
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 目标只能是随从
			};

		}


	}
}
