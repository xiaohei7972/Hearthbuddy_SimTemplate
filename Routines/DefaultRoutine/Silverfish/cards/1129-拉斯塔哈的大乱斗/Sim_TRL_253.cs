using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TRL_253 : SimTemplate //* 希里克，蝙蝠之神 Hir'eek, the Bat
//<b>Battlecry:</b> Fill your board with copies of this minion.
//<b>战吼：</b>召唤此随从的复制，直到你的随从数量达到上限。 
	
	{

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TRL_253);


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