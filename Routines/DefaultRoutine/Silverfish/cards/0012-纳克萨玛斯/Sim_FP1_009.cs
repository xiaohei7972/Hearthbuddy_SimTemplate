using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_FP1_009 : SimTemplate //* 死亡领主 Deathlord
//<b>Taunt. Deathrattle:</b> Your opponent puts a minion from their deck into the battlefield.
//<b>嘲讽，亡语：</b>你的对手将一个随从从其牌库置入战场。 
	{
        
        CardDB.Card c = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_612);

        public override void onDeathrattle(Playfield p, Minion m)
        {
            int place = (m.own) ? p.enemyMinions.Count : p.ownMinions.Count;
            p.callKid(c, place, !m.own, false);
        }
	}
}