using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GVG_096 : SimTemplate //* 载人收割机 Piloted Shredder
//<b>Deathrattle:</b> Summon a random 2-Cost minion.
//<b>亡语：</b>随机召唤一个法力值消耗为（2）的随从。 
    {

        

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_172);

        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.callKid(kid, m.zonepos - 1, m.own);
        }
    }
}