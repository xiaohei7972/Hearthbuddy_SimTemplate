using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 圣骑士 费用：1
	//Divine Strength
	//神圣之力
	//Give a minion +1/+2.
	//使一个随从获得+1/+2。
	class Sim_RLK_Prologue_OG_223 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (target != null)
            {
                p.minionGetBuffed(target, 1, 2);
            }
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
