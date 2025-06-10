using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TRL_531 : SimTemplate //* 暴牙震颤者 Rumbletusk Shaker
//<b>Deathrattle:</b> Summon a 3/2 Rumbletusk Breaker.
//<b>亡语：</b>召唤一个3/2的暴牙破坏者。 
	{
        

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TRL_531t); 

        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.callKid(kid, m.zonepos - 1, m.own);
        }
    }
}