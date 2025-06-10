using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_751 : SimTemplate //* 疯狂召唤师 Mad Summoner
//[x]<b>Battlecry:</b> Fill each player'sboard with 1/1 Imps.
//<b>战吼：</b>为双方玩家召唤数个1/1的小鬼，直到随从数量达到上限。 
	{

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.DAL_751t);
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            int kids = 7 - p.ownMinions.Count;
           
            for (int i = 0; i < kids; i++)
            {
                p.callKid(kid, own.zonepos, own.own);
            }

		}


	}
}