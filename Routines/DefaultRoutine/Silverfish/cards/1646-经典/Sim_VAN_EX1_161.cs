using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_161 : SimTemplate //* 自然平衡 Naturalize
//Destroy a minion.Your opponent draws 2_cards.
//消灭一个随从，你的对手抽两张牌。 
	{



		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            p.minionGetDestroyed(target);
            p.drawACard(CardDB.cardIDEnum.None, !ownplay);
            p.drawACard(CardDB.cardIDEnum.None, !ownplay);
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