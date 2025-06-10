using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_529 : SimTemplate //* 虚空撕裂者 Void Ripper
//<b>Battlecry:</b> Swap theAttack and Health of all_other_minions.
//<b>战吼：</b>使所有其他随从的攻击力和生命值互换。 
	{
		

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            foreach (Minion m in p.ownMinions)
            {
                p.minionSwapAngrAndHP(m);
            }
            foreach (Minion m in p.enemyMinions)
            {
                p.minionSwapAngrAndHP(m);
            }				
		}
	}
}