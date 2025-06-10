using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_015 : SimTemplate //* 守日者塔林姆 Sunkeeper Tarim
//<b>Taunt</b><b>Battlecry:</b> Set all other minions' Attack and Health to 3.
//<b>嘲讽，战吼：</b>将所有其他随从的攻击力和生命值变为3。 
	{
		

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            foreach (Minion m in p.ownMinions)
            {
                if (m.entitiyID == own.entitiyID) continue;
				p.minionSetAngrToX(m, 3);
				p.minionSetLifetoX(m, 3);
            }
            foreach (Minion m in p.enemyMinions)
            {
                if (m.entitiyID == own.entitiyID) continue;
				p.minionSetAngrToX(m, 3);
				p.minionSetLifetoX(m, 3);
            }				
		}
	}
}