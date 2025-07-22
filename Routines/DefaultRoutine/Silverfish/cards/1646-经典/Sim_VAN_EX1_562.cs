using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_562 : SimTemplate //* 奥妮克希亚 Onyxia
	{
		//<b>Battlecry:</b> Summon 1/1 Whelps until your side of the battlefield is full.
		//<b>战吼：</b>召唤数个1/1的雏龙，直到你的随从数量达到上限。

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_116t);//whelp

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