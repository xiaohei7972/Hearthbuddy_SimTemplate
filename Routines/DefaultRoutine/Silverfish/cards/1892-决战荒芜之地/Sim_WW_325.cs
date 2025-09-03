using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 萨满祭司 费用：3
	//Dehydrate
	//脱水
	//<b>Lifesteal</b>. Deal $4 damage to a minion.<b>Quickdraw:</b> Costs (1).
	//<b>吸血</b>。对一个随从造成$4点伤害。<b>快枪：</b>法力值消耗为（1）点。
	class Sim_WW_325 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				int damage = ownplay ? p.getSpellDamageDamage(4) : p.getEnemySpellDamageDamage(4);
				// 对目标造成3点伤害
				p.minionGetDamageOrHeal(target, damage);
				p.minionGetDamageOrHeal(ownplay ? p.ownHero : p.enemyHero, -damage);
			}
		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[] {
				new PlayReq(CardDB.ErrorType2. REQ_TARGET_TO_PLAY),
				new PlayReq(CardDB.ErrorType2. REQ_MINION_TARGET),
			};
		}
	}

}
