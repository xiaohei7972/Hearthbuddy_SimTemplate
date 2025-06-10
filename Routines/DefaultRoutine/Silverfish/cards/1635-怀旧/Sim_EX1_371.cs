using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_EX1_371 : SimTemplate //* 保护之手 Hand of Protection
	{
		//Give a minion <b>Divine Shield</b>.
		//使一个随从获得<b>圣盾</b>。

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            target.divineshild = true;
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