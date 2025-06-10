using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BOT_537 : SimTemplate //* 机械蛋 Mechano-Egg
//<b>Deathrattle:</b> Summon an 8/8 Robosaur.
//<b>亡语：</b>召唤一个8/8的机械暴龙。 
	{
		
		
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.BOT_537t);

        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.callKid(kid, m.zonepos-1, m.own);
        }
	}
}