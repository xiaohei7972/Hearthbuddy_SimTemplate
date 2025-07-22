using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_202 : SimTemplate //* 火羽先锋 Fire Plume Harbinger
//<b>Battlecry:</b> Reduce the Cost of Elementals in your hand_by (1).
//<b>战吼：</b>使你手牌中所有元素牌的法力值消耗减少（1）点。 
	{
		
        
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if (own.own)
            {
                foreach (Handmanager.Handcard hc in p.owncards)
                {
                    if ((TAG_RACE)hc.card.race == TAG_RACE.ELEMENTAL) hc.manacost--;
                }
            }
		}
	}
}