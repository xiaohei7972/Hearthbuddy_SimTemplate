using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 圣骑士 费用：1
	//Holy Maki Roll
	//神圣寿司卷
	//Restore #2 Health. Repeatable this turn.
	//恢复#2点生命值。在本回合可以重复使用。
	class Sim_TSC_952 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				int damage = ownplay ? p.getSpellHeal(-2) : p.getEnemySpellHeal(-2);
				p.minionGetDamageOrHeal(target, damage);
			}
		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
			};
		}

	}
}
