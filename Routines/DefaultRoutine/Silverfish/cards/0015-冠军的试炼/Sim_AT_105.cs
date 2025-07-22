using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_105 : SimTemplate //* 受伤的克瓦迪尔 Injured Kvaldir
//<b>Battlecry:</b> Deal 3 damage to this minion.
//<b>战吼：</b>对自身造成3点伤害。 
	{
		
		
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.minionGetDamageOrHeal(own, 3);
        }
    }
}