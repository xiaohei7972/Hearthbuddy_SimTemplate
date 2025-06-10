using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOE_050 : SimTemplate //* 骑乘迅猛龙 Mounted Raptor
//<b>Deathrattle:</b> Summon a random 1-Cost minion.
//<b>亡语：</b>随机召唤一个法力值消耗为（1）的随从。 
	{
        

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.BRM_004); 

        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.callKid(kid, m.zonepos - 1, m.own);
        }
    }
}