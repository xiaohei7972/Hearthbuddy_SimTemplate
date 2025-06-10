using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_EX1_131 : SimTemplate //* 迪菲亚头目 Defias Ringleader
	{
		//<b>Combo:</b> Summon a 2/1 Defias Bandit.
		//<b>连击：</b>召唤一个2/1的迪菲亚强盗。
        CardDB.Card card = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_131t);
//    combo:/ ruft einen banditen der defias (2/1) herbei.
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if (p.cardsPlayedThisTurn >= 1)
            {
                p.callKid(card, own.zonepos, own.own);
            }
		}


	}
}