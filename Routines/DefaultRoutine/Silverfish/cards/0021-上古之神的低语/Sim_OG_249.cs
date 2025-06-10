using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_OG_249 : SimTemplate //* 被感染的牛头人 Infested Tauren
//<b>Taunt</b><b>Deathrattle:</b> Summon a 2/2 Slime.
//<b>嘲讽</b><b>亡语：</b>召唤一个2/2的泥浆怪。 
	{
		
		
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.NAX11_03);
		
        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.callKid(kid, m.zonepos - 1, m.own);
        }
	}
}