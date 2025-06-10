using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_WC_007 : SimTemplate //* 毒蛇花 Serpentbloom
	{
        //Give a friendlyBeast <b>Poisonous</b>.
        //使一只友方野兽获得<b>剧毒</b>。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            target.poisonous = true;
        }


        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
    }
}
