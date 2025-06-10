using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_OG_188 : SimTemplate //* 卡拉克西织珀者 Klaxxi Amber-Weaver
//<b>Battlecry:</b> If your C'Thun has at least 10 Attack, gain +5 Health.
//<b>战吼：</b>如果你的克苏恩至少具有10点攻击力，便获得+5生命值。 
	{
		
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if (own.own)
            {
                if (p.anzOgOwnCThunAngrBonus + 6 > 9) p.minionGetBuffed(own, 0, 5);
                else p.evaluatePenality += 5;
            }
		}
	}
}