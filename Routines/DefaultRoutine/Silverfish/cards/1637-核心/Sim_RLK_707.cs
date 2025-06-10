
using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_RLK_707 : SimTemplate //* 墓地之力 Grave Strength
                                    //使你的所有随从获得+1攻击力。消耗5具&lt;b&gt;尸体&lt;/b&gt;，改为获得+3攻击力。
                                    //Give your minions +1Attack. Spend 5 &lt;b&gt;Corpses&lt;/b&gt;to give them +3 instead.
    {
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if(p.getCorpseCount() >= 5)
			{
				p.corpseConsumption(5);
				p.allMinionOfASideGetBuffed(ownplay, 3, 0);
			}else{
				p.allMinionOfASideGetBuffed(ownplay, 1, 0);
			}
			
        }
    }


}
        