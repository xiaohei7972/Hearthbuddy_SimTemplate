using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_AT_062 : SimTemplate //* 天降蛛群 Ball of Spiders
//Summon three 1/1 Webspinners.
//召唤三个1/1的结网蛛。 
    {
		
		
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.FP1_011);

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int place = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;

            p.callKid(kid, place, ownplay, false);
            p.callKid(kid, place, ownplay);
            p.callKid(kid, place, ownplay);
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
            };
        }
	}
}