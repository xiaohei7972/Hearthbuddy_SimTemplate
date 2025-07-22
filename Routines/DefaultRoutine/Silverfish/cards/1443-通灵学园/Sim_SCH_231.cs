using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SCH_231 : SimTemplate //* 新生刺头 Intrepid Initiate
	{
		//<b>Spellburst:</b> Gain +2_Attack.
		//<b>法术迸发：</b>获得+2攻击力。
        public override void OnSpellburst(Playfield p, Minion m, Handmanager.Handcard hc)
        {
			p.minionGetBuffed(m, 2, 0);
			p.evaluatePenality -= 8;
        }

    }
}
