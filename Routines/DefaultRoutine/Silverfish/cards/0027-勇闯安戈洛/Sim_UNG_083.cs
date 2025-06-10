using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_083 : SimTemplate //* 魔暴龙蛋 Devilsaur Egg
//<b>Deathrattle:</b> Summon a 5/5 Devilsaur.
//<b>亡语：</b>召唤一个5/5的魔暴龙。 
	{
		

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.UNG_083t1); 
        
        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.callKid(kid, m.zonepos-1, m.own);
        }
	}
}