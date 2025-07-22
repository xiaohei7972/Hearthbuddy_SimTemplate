using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_OG_083 : SimTemplate //* 暮光烈焰召唤者 Twilight Flamecaller
//<b>Battlecry:</b> Deal 1 damage to all enemy minions.
//<b>战吼：</b>对所有敌方随从造成1点伤害。 
	{
		
		
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
			p.allMinionOfASideGetDamage(!own.own, 1);
        }
    }
}