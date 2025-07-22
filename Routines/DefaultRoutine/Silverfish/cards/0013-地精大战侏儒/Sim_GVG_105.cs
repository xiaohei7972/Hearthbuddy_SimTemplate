using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GVG_105 : SimTemplate //* 载人飞天魔像 Piloted Sky Golem
//<b>Deathrattle:</b> Summon a random 4-Cost minion.
//<b>亡语：</b>随机召唤一个法力值消耗为（4）的随从。 
    {

        

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_182);

        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.callKid(kid, m.zonepos - 1, m.own);
        }
    }
}