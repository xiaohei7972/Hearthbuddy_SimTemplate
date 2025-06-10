using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GVG_114 : SimTemplate //* 斯尼德的伐木机 Sneed's Old Shredder
//<b>Deathrattle:</b> Summon a random <b>Legendary</b> minion.
//<b>亡语：</b>随机召唤一个<b>传说</b>随从。 
    {

        
		
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_014);

        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.callKid(kid, m.zonepos - 1, m.own); 
        }
    }
}