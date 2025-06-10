using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CS2_181 : SimTemplate //* 负伤剑圣 Injured Blademaster
	{
		//<b>Battlecry:</b> Deal 4 damage to HIMSELF.
		//<b>战吼：</b>对自身造成4点伤害。
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {

            p.minionGetDamageOrHeal(own, 4);
        }

    }
}
