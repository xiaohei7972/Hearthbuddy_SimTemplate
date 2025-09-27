using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 巫妖王 费用：3
	//Reap What You Sow
	//自埋自收
	//Deal $3 damage. <b>Excavate</b> a treasure.
	//造成$3点伤害。<b>发掘</b>一个宝藏。
	class Sim_WW_352 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				int dmg = ownplay ? p.getSpellDamageDamage(3) : p.getEnemySpellDamageDamage(3);
				// 对目标造成3点伤害
				p.minionGetDamageOrHeal(target, dmg);
				// 调用发掘方法
				p.drawACard(p.handleExcavation().cardIDenum, ownplay, true);

			}
		}
		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[] {
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
   			};
		}
	}
}
