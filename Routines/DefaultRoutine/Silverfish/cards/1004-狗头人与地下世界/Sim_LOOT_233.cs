using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_233 : SimTemplate //* 被诅咒的门徒 Cursed Disciple
//<b>Deathrattle:</b> Summon a 5/1 Revenant.
//<b>亡语：</b>召唤一个5/1的亡魂。 
	{
		
		
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.LOOT_233t);
		
		public override void onDeathrattle(Playfield p, Minion m)
		{
            p.callKid(kid, m.zonepos-1, m.own);
		}
	}
}