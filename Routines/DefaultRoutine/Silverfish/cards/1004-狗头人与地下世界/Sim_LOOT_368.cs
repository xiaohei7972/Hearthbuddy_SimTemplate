using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_LOOT_368 : SimTemplate //* 虚空领主 Voidlord
//[x]<b>Taunt</b> <b>Deathrattle:</b> Summon three1/3 Demons with <b>Taunt</b>.
//<b>嘲讽，亡语：</b>召唤三个1/3并具有<b>嘲讽</b>的恶魔。 
    {
        
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_065);
		
        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.callKid(kid, m.zonepos-1, m.own);
            p.callKid(kid, m.zonepos-1, m.own);
			p.callKid(kid, m.zonepos-1, m.own);
        }
    }
}