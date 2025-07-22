using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_917t1 : SimTemplate //* 恐龙学 Dinomancy
//<b>Hero Power</b>Give a Beast +2/+2.
//<b>英雄技能</b>使一个野兽获得+2/+2。 
	{
		

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.minionGetBuffed(target, 2, 2);
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_WITH_RACE, 20),
            };
        }
	}
}