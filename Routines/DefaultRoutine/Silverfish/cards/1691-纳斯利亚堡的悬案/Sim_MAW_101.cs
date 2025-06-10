using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_MAW_101 : SimTemplate //* 契约咒术师 Contract Conjurer
 //你每控制一个奥秘，本牌的法力值消耗便减少（3）点。
//Costs (3) less for each Secret you control.
    {
        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool ownplay, Handmanager.Handcard triggerhc)
        {
            if (ownplay && hc.card.Secret)
            {
                triggerhc.manacost = triggerhc.getManaCost(p);
            }
        }
    }
}
