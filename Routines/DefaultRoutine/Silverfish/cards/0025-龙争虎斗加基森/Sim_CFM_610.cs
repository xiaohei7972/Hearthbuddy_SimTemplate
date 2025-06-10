using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_610 : SimTemplate //* 魔瘾结晶者 Crystalweaver
//<b>Battlecry:</b> Give your Demons +1/+1.
//<b>战吼：</b>使你的所有恶魔获得+1/+1。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            List<Minion> temp = (m.own) ? p.ownMinions : p.enemyMinions;
            foreach (Minion mnn in temp)
            {
                if ((TAG_RACE)mnn.handcard.card.race == TAG_RACE.DEMON && mnn.entitiyID != m.entitiyID) p.minionGetBuffed(mnn, 1, 1);
            }
        }
    }
}