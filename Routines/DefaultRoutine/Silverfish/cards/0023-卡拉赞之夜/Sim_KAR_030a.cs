using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_KAR_030a : SimTemplate //* 橱柜蜘蛛 Pantry Spider
//<b>Battlecry:</b> Summon a1/3 Spider.
//<b>战吼：</b>召唤一只1/3的蜘蛛。 
	{
		
		
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.KAR_030);
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.callKid(kid, own.zonepos, own.own);
		}
	}
}