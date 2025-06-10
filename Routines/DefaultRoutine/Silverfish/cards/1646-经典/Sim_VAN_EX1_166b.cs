using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_166b : SimTemplate //* 禁魔 Dispel
	{
		//<b>Silence</b> a minion.
		//<b>沉默</b>一个随从。

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
                p.minionGetSilenced(target);
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