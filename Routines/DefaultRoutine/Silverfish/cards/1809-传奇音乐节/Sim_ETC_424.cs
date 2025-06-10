
using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ETC_424 : SimTemplate //* 死亡嘶吼 Death Growl
                                    //选择一个随从。将其&lt;b&gt;亡语&lt;/b&gt;传播到相邻随从上。
                                    //Choose a minion.Spread its &lt;b&gt;Deathrattle&lt;/b&gt;to adjacent minions.
    {
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
			
		}

		public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
			};
		}
    }


}
        