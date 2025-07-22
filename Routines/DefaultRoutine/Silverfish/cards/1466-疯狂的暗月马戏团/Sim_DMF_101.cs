using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DMF_101 : SimTemplate //* 焰火元素 Firework Elemental
	{
		//[x]<b>Battlecry:</b> Deal 3 damageto a minion. <b>Corrupt:</b>Deal 12 instead.
		//<b>战吼：</b>对一个随从造成3点伤害。<b>腐蚀：</b>改为12点。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int dmg = p.getSpellDamageDamage(3);
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
