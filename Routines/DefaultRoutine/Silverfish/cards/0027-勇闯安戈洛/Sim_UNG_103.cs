using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_103 : SimTemplate //* 生长孢子 Evolving Spores
//<b>Adapt</b> your minions.
//<b>进化</b>你所有的随从。 
	{
		

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            List<Minion> temp = (ownplay) ? p.ownMinions : p.enemyMinions;
			bool first = true;
			int bestAdapt = 0;
            foreach (Minion m in temp)
            {
				if (first )
				{
					bestAdapt = p.getBestAdapt(m);
					first = false;
				}
				else
				{
					switch (bestAdapt )
                    {
                        case 1: p.minionGetBuffed(m, 1, 1); break;
                        case 2: p.minionGetBuffed(m, 3, 0); break;
                        case 3: p.minionGetBuffed(m, 0, 3); break;
                        case 4: m.taunt = true; break;
                        case 5: m.divineshild = true; break;
                        case 6: m.poisonous = true; break;
					}
				}				
            }
        }
    }
}