using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_058 : SimTemplate //* 机械拷问者 Hecklebot
//<b>Taunt</b><b>Battlecry:</b> Your opponent summons a minion from their deck.
//<b>嘲讽，战吼：</b>使你的对手从牌库中召唤一个随从。 
	{
		

        CardDB.Card c = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_612);

        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            int place = (m.own) ? p.enemyMinions.Count : p.ownMinions.Count;
            p.callKid(c, place, !m.own, false);
        }
    }
}