using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_039 : SimTemplate //* 狂野争斗者 Savage Combatant
//<b>Inspire:</b> Give your hero+2 Attack this turn.
//<b>激励：</b>在本回合中，使你的英雄获得+2攻击力。 
	{
		

		public override void onInspire(Playfield p, Minion m, bool own)
        {
			if (m.own == own)
			{
				p.minionGetTempBuff(own ? p.ownHero : p.enemyHero, 2, 0);
			}
        }
	}
}