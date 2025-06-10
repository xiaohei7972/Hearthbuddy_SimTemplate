using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CORE_EX1_246 : SimTemplate //hex
	{
        CardDB.Card card = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.hexfrog);
//    verwandelt einen diener in einen frosch (0/1) mit spott/.

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            p.minionTransform(target, card);
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