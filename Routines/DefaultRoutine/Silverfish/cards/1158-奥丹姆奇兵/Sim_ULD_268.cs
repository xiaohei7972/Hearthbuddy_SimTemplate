using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_ULD_268 : SimTemplate //* 接引冥神 Psychopomp
//[x]<b>Battlecry:</b> Summon arandom friendly minionthat died this game.Give it <b>Reborn</b>.
//<b>战吼：</b>随机召唤一个在本局对战中死亡的友方随从。使其获得<b>复生</b>。 
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