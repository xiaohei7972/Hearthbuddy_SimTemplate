using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_825: SimTemplate //* 憎恶弓箭手 Abominable Bowman
//[x]<b>Deathrattle:</b> Summona random friendly Beastthat died this game.
//<b>亡语：</b>随机召唤一个在本局对战中死亡的友方野兽。 
    {
        

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_172); 

        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.callKid(kid, m.zonepos - 1, m.own);
        }
    }
}