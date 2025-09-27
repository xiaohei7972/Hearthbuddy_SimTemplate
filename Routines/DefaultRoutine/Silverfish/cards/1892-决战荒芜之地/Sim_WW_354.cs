using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 巫妖王 费用：1
	//Fistful of Corpses
	//残骸遍野
	//Deal damage toa minion equal toyour <b>Corpses</b>.
	//对一个随从造成等同于你的<b>残骸</b>数量的伤害。
	class Sim_WW_354 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				int dmg = ownplay ? p.getSpellDamageDamage(p.getCorpseCount()) : p.getEnemySpellDamageDamage(p.getCorpseCount());
				// 对目标造成3点伤害
				p.minionGetDamageOrHeal(target, dmg);

			}
		}
		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[] {
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
   			};
		}
		
	}
}
