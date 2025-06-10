using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TRL_059 : SimTemplate //* 沼泽游荡者 Bog Slosher
//<b>Battlecry:</b> Return a friendly minion to your hand and give it +2/+2.
//<b>战吼：</b>将一个友方随从移回你的手牌，并使其获得+2/+2。 
	{


		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if(target != null) p.minionReturnToHand(target, target.own, 0);
			p.owncards[p.owncards.Count - 1].addattack+=2;
            p.owncards[p.owncards.Count - 1].addHp+=2;
		}



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
            };
        }
	}
}