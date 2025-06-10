using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_LOOT_167 : SimTemplate //* 菌菇术士 Fungalmancer
    {
        //战吼：使相邻的随从获得+2/+2。 
		
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			int num = p.ownMinions.Count;
			if (own.own)
			{
				switch (num)
				{
					case 1:
					    break;
					case 2:
				    	if (own.zonepos == 1 ) p.minionGetBuffed(p.ownMinions[1], 2, 2);
				    	else  p.minionGetBuffed(p.ownMinions[0], 2, 2);
					    break;
			        default:
					    if (own.zonepos == 1 ) p.minionGetBuffed(p.ownMinions[1], 2, 2);
				        else if (own.zonepos == num ) p.minionGetBuffed(p.ownMinions[num-2], 2, 2);
				        else 
				        {
				        	p.minionGetBuffed(p.ownMinions[own.zonepos-2], 2, 2);
			    	    	p.minionGetBuffed(p.ownMinions[own.zonepos], 2, 2);
			        	}
					    break;
				}
			}
		}	
    }
}