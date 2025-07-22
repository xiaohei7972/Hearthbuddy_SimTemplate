using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_LOOT_333 : SimTemplate //* 等级提升 Level Up!
//Give your Silver Hand Recruits +2/+2 and_<b>Taunt</b>.
//使你的白银之手新兵获得+2/+2和<b>嘲讽</b>。 
    {
		
		
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            List<Minion> temp = (ownplay) ? p.ownMinions : p.enemyMinions;
            foreach (Minion m in temp)
            {
                if (m.name == CardDB.cardNameEN.silverhandrecruit)
                {
                    p.minionGetBuffed(m, 2, 2);
					if (!m.taunt)
                    {
                        m.taunt = true;
                        if (m.own) p.anzOwnTaunt++;
                        else p.anzEnemyTaunt++;                         
                    }     
                     
				}	
            }
        } 
    }
}
