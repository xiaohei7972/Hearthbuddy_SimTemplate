using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 潜行者 费用：8
	//Power Word: Fortitude
	//真言术：韧
	//Give a minion +3/+5. Costs (1) less for each spell in your hand.
	//使一个随从获得+3/+5。你手牌中每有一张法术牌，本牌的法力值消耗便减少（1）点。
	class Sim_BAR_308 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (target != null)
            {
                p.minionGetBuffed(target, 3, 5);
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
