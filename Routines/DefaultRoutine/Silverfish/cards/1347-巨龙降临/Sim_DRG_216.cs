using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DRG_216 : SimTemplate //* 电涌风暴 Surging Tempest
	{
		//Has +1 Attack while you have <b>Overloaded</b> Mana Crystals.
		//当你有<b>过载</b>的法力水晶时，获得+1攻击力。
		public override void onAuraStarts(Playfield p, Minion own)
		{
			if (own.own)
			{
				if (p.ueberladung > 0) p.minionGetBuffed(own, 1, 0);
			}
			else
			{
				if (p.ueberladung > 0) p.minionGetBuffed(own, 1, 0);
			}
		}
		public override void onAuraEnds(Playfield p, Minion own)
		{
			if (own.own)
			{
				p.minionGetBuffed(own, -1, 0);
			}
			else
			{
				p.minionGetBuffed(own, -1, 0);
			}
		}
	}
}