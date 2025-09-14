using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 巫妖王 费用：4
	//Death Strike
	//灵界打击
	//<b>Lifesteal</b>Deal $6 damageto a minion.
	//<b>吸血</b>对一个随从造成$6点伤害。
	class Sim_RLK_Prologue_RLK_024 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				int dmg = (ownplay) ? p.getSpellDamageDamage(6) : p.getEnemySpellDamageDamage(6);
				p.minionGetDamageOrHeal(target, dmg);
                p.applySpellLifesteal(dmg, ownplay);
				

			}
		}
		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[] {
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), //需要一个目标
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), //目标只能是随从
            };
		}
		
	}
}
