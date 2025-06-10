using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_109 : SimTemplate //* 银色警卫 Argent Watchman
//Can't attack.<b>Inspire:</b> Can attack as normal this turn.
//无法攻击。<b>激励：</b>在本回合中可正常进行攻击。 
	{
		

		public override void onInspire(Playfield p, Minion m, bool own)
        {
			if (m.own == own)
			{
                m.cantAttack = false;
				m.updateReadyness();
			}
        }
		
		public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            if (triggerEffectMinion.own == turnEndOfOwner)
            {
                if (!triggerEffectMinion.silenced) triggerEffectMinion.cantAttack = true;
            }
        }
	}
}