using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_OG_096 : SimTemplate //* 暮光暗愈者 Twilight Darkmender
//<b>Battlecry:</b> If your C'Thun  has at least 10 Attack, restore #10 Health to your hero.
//<b>战吼：</b>如果你的克苏恩至少具有10点攻击力，便为你的英雄恢复#10点生命值。 
	{
		
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (own.own)
            {
                if (p.anzOgOwnCThunAngrBonus + 6 > 9) p.minionGetDamageOrHeal(p.ownHero, -p.getMinionHeal(10));
                else p.evaluatePenality += 6;
            }
		}
	}
}