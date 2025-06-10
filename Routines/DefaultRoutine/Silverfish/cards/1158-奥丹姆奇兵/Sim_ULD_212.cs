using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_ULD_212 : SimTemplate //* 刺血狂蝎 Wild Bloodstinger
//<b>Battlecry:</b> Summon a minion from your opponent's hand. Attack it.
//<b>战吼：</b>从你对手的手牌中召唤一个随从。攻击该随从。 
	{
		

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_066); 

        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            int zonepos = (m.own) ? p.enemyMinions.Count : p.ownMinions.Count;
            p.callKid(kid, zonepos, !m.own);
        }
    }
}