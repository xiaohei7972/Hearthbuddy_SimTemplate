using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 术士 费用：1
	//Smokestack
	//列车烟囱
	//Deal $1 damage toa minion. If it dies, <b>Excavate</b> a treasure.
	//对一个随从造成$1点伤害。如果该随从死亡，<b>发掘</b>一个宝藏。
	class Sim_WW_378 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				int damage = ownplay ? p.getSpellDamageDamage(1) : p.getEnemySpellDamageDamage(1);
				p.minionGetDamageOrHeal(target, damage);
				if (target.Hp <= damage && !target.divineshild)
				{
					p.drawACard(p.handleExcavation().cardIDenum, ownplay, true);
				}
			}
		}
		
		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要选择一个目标
				// new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET), //只能是敌方
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET) // 目标只能是随从
			};
		}
		
	}
}
