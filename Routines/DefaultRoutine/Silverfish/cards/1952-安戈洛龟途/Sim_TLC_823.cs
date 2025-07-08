using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 猎人 费用：2
	//Cower in Fear
	//恐惧畏缩
	//Deal $3 damageto a minion. The nextBeast you play thisturn costs (2) less.
	//对一个随从造成$3点伤害。在本回合中，你使用的下一张野兽牌法力值消耗减少（2）点。
	class Sim_TLC_823 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				int damage = ownplay ? p.getSpellDamageDamage(3) : p.getEnemySpellDamageDamage(3);
				p.minionGetDamageOrHeal(target, damage);
			}
		}


		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[] {
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要一个目标
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 只能是随从
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET), // 只能是敌方
            };
		}
	}
}
