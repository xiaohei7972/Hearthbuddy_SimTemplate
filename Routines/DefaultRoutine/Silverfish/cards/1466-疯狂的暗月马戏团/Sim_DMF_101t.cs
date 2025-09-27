using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//* 焰火元素 Firework Elemental
	//<b>Corrupted</b><b>Battlecry:</b> Deal 12 damage to a minion.
	//<b>已腐蚀</b><b>战吼：</b>对一个随从造成12点伤害。
	class Sim_DMF_101t : SimTemplate
	{

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			if (target != null)
			{
				p.minionGetDamageOrHeal(target, 12);
			}
		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[] {
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE)
			};
		}

	}
}
