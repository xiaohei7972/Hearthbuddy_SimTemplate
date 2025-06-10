using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_153 : SimTemplate //* 紫色岩虫 Violet Wurm
//<b>Deathrattle:</b> Summon seven 1/1 Grubs.
//<b>亡语：</b>召唤七只1/1的肉虫。 
	{
        

        CardDB.Card c = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.LOOT_153t1);
		
        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.callKid(c, m.zonepos-1, m.own);
            p.callKid(c, m.zonepos-1, m.own);
			p.callKid(c, m.zonepos-1, m.own);
            p.callKid(c, m.zonepos-1, m.own);
			p.callKid(c, m.zonepos-1, m.own);
            p.callKid(c, m.zonepos-1, m.own);
			p.callKid(c, m.zonepos-1, m.own);
        }
	}
}