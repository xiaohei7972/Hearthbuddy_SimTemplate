using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_FP1_016 : SimTemplate //* 哀嚎的灵魂 Wailing Soul
//<b>Battlecry: Silence</b> your other minions.
//<b>战吼：沉默</b>你的其他随从。 
	{
        

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            List<Minion> temp = (own.own) ? p.ownMinions : p.enemyMinions;
            foreach (Minion m in temp)
            {
                if (m.entitiyID != own.entitiyID) p.minionGetSilenced(m);
            }
		}
	}
}