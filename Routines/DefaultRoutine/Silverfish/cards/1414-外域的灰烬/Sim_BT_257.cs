using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_257 : SimTemplate //* 神圣化身 Apotheosis
	{
		//Give a minion +2/+3 and <b>Lifesteal</b>.
		//使一个随从获得+2/+3和<b>吸血</b>。
		
		

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (target != null)
            {
                p.minionGetBuffed(target, 2, 3);
                target.lifesteal = true;
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
