using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_ULDA_307ts : SimTemplate //* 甲虫金饰 Bauble of Beetles
	{
		//[x]Resurrect the first4 friendly minionsthat died this game.Give them <b>Reborn</b>.
		//复活在本局对战中最先死亡的四个友方随从。使其获得<b>复生</b>。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_MINION_DIED_THIS_GAME),
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
            };
        }
	}
}
