using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_083 : SimTemplate //* 龙鹰骑士 Dragonhawk Rider
//<b>Inspire:</b> Gain <b>Windfury</b>this turn.
//<b>激励：</b>在本回合中，获得<b>风怒</b>。 
	{
		

		public override void onInspire(Playfield p, Minion m, bool own)
        {
			if (m.own == own)
			{
				m.gotInspire = true;
				p.minionGetWindfurry(m);
			}
        }
		
		public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            if (triggerEffectMinion.own == turnEndOfOwner)
            {
                if (triggerEffectMinion.gotInspire)
                {
                    triggerEffectMinion.windfury = false;
                    triggerEffectMinion.gotInspire = false;
                }
            }
        }
	}
}