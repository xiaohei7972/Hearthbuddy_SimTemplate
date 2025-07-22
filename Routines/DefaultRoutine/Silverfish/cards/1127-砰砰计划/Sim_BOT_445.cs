using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BOT_445 : SimTemplate //* 机械袋鼠 Mecharoo
//<b>Deathrattle:</b> Summon a 1/1 Jo-E Bot.
//<b>亡语：</b>召唤一个1/1的机械袋鼠宝宝。 
	{
        
		
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.BOT_445t);
		
        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.callKid(kid, m.zonepos-1, m.own);
        }
	}
}