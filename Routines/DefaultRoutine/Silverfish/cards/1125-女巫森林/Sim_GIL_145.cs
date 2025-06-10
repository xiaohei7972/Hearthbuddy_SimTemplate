using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GIL_145 : SimTemplate //* 敲响警钟 Sound the Bells!
//<b>Echo</b>Give a minion +1/+2.
//<b>回响</b>使一个随从获得+1/+2。 
    {
        

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.minionGetBuffed(target, 1, 2);
			p.drawACard(CardDB.cardIDEnum.GIL_145, ownplay, true);
		}
		
		public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
		{
			p.discardCards(1, turnEndOfOwner);
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
