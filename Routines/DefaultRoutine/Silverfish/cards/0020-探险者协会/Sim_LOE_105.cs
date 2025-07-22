using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOE_105 : SimTemplate //* 探险帽 Explorer's Hat
//Give a minion +1/+1 and "<b>Deathrattle:</b> Add an Explorer's Hat to your hand."
//使一个随从获得+1/+1，以及<b>亡语：</b>将一个探险帽置入你的手牌。 
	{
		

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            p.minionGetBuffed(target, 1, 1);
            target.explorershat++;
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