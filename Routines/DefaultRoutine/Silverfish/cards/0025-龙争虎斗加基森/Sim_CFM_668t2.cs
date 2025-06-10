using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_668t2 : SimTemplate //* 魅影歹徒 Doppelgangster
//<b>Battlecry:</b> Summon 2 copies of this minion.
//<b>战吼：</b>召唤该随从的两个复制。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            p.callKid(m.handcard.card, m.zonepos, m.own);
            p.callKid(m.handcard.card, m.zonepos, m.own);
            List<Minion> temp = (m.own) ? p.ownMinions : p.enemyMinions;
            int count = 0;
            foreach (Minion mnn in temp)
            {
                if (mnn.name == CardDB.cardNameEN.doppelgangster && m.entitiyID != mnn.entitiyID && mnn.playedThisTurn)
                {
                    mnn.setMinionToMinion(m);
                    count++;
                    if (count >= 2) break;
                }
            }
        }
    }
}