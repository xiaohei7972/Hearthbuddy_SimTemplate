using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//英雄技能 中立 费用：2
	//Arcane Bullet
	//奥术枪弹
	//Deal $2 damage.Refresh 2 Mana Crystals.Swaps each turn.
	//造成$2点伤害。复原2个法力水晶。每回合切换。
	class Sim_WW_0700p1 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				int damage = ownplay ? p.getHeroPowerDamage(2) : p.getEnemyHeroPowerDamage(2);
				p.minionGetDamageOrHeal(target, damage);
				p.mana = Math.Max(p.ownMaxMana, p.mana += 2);
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
