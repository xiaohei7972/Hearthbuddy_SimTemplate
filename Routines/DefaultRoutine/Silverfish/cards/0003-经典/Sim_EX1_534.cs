using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //* 长鬃草原狮 Savannah Highmane
    //<b>Deathrattle:</b> Summon two 2/2 Hyenas.
    //<b>亡语：</b>召唤两只2/2的土狼。
    class Sim_EX1_534 : SimTemplate
    {
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_534t);//hyena

        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.callKid(kid, m.zonepos - 1, m.own);
            p.callKid(kid, m.zonepos - 1, m.own);
        }
        
    }
}