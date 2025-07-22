using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BOT_536 : SimTemplate //* 欧米茄探员 Omega Agent
//[x]<b>Battlecry:</b> If you have 10Mana Crystals, summon_2 copies of this minion.
//<b>战吼：</b>如果你有十个法力水晶，召唤该随从的两个复制。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            if (p.ownMaxMana ==10)
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
}