using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_961 : SimTemplate //* 适者生存 Adaptation
//<b>Adapt</b> a friendly minion.
//<b>进化</b>一个友方随从。 
	{
		

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null) p.getBestAdapt(target);
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}