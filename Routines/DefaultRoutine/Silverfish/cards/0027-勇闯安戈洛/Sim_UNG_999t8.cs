using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_999t8 : SimTemplate //* 爆裂护盾 Crackling Shield
//<b>Divine Shield</b>
//<b>圣盾</b> 
	{
		

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