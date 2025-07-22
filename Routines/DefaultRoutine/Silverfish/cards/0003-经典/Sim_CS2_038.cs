using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CS2_038 : SimTemplate //* 先祖之魂 Ancestral Spirit
	{
		//Give a minion "<b>Deathrattle:</b> Resummon this minion."
		//使一个随从获得“<b>亡语</b>：再次召唤该随从。”
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            target.ancestralspirit++;
		}


        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}