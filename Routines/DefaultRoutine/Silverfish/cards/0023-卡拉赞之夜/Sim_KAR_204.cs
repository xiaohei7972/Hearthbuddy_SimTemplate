using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_KAR_204 : SimTemplate //* 玛瑙主教 Onyx Bishop
//<b>Battlecry:</b> Summon a friendly minion that died this game.
//<b>战吼：</b>召唤一个在本局对战中死亡的友方随从。 
	{
		
				
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if (own.own)
            {
                if (p.OwnLastDiedMinion != CardDB.cardIDEnum.None)
                {
                    p.callKid(CardDB.Instance.getCardDataFromID(p.OwnLastDiedMinion), own.zonepos, own.own);
                }
            }
		}
	}
}