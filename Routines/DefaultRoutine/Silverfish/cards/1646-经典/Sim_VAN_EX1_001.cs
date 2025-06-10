using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_001 : SimTemplate //* 圣光护卫者 Lightwarden
	{
		//Whenever a character is healed, gain +2 Attack.
		//每当一个角色获得治疗，便获得+2攻击力。

        public override void onACharGotHealed(Playfield p, Minion triggerEffectMinion, int charsGotHealed)
        {
            p.minionGetBuffed(triggerEffectMinion, 2 * charsGotHealed, 0);
        }
	}
}