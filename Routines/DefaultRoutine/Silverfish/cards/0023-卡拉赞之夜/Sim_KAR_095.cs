using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_KAR_095 : SimTemplate //* 机械动物管理员 Zoobot
//<b>Battlecry:</b> Give a random friendly Beast, Dragon, and Murloc +1/+1.
//<b>战吼：</b>随机使一个友方野兽，龙和鱼人获得+1/+1。 
	{
		
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			List<Minion> temp = (own.own) ? p.ownMinions : p.enemyMinions;
            if (temp.Count >= 1)
            {
                Minion Beast = null;
                Minion Dragon = null;
                Minion Murloc = null;
				
                foreach (Minion m in temp)
                {
                    switch ((TAG_RACE)m.handcard.card.race)
					{
						case TAG_RACE.PET:
							if (Beast == null) Beast = m;
							continue;
						case TAG_RACE.DRAGON:
							if (Dragon == null) Dragon = m;
							continue;
						case TAG_RACE.MURLOC:
							if (Murloc == null) Murloc = m;
							continue;
					}
                }
				
				if (Beast != null) p.minionGetBuffed(Beast, 1, 1);
				if (Dragon != null) p.minionGetBuffed(Dragon, 1, 1);
				if (Murloc != null) p.minionGetBuffed(Murloc, 1, 1);
            }
		}
	}
}