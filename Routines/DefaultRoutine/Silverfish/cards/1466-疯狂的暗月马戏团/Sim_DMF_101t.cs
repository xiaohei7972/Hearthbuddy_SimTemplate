using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DMF_101t : SimTemplate //* 焰火元素 Firework Elemental
	{
		//<b>Corrupted</b><b>Battlecry:</b> Deal 12 damage to a minion.
		//<b>已腐蚀</b><b>战吼：</b>对一个随从造成12点伤害。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int dmg = p.getSpellDamageDamage(12);
			p.minionGetDamageOrHeal(target, dmg);
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
