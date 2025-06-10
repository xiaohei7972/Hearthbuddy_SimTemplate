using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_BOT_238p6: SimTemplate //* 微型战队 Micro-Squad
//<b>Hero Power</b>Summon three 1/1 Microbots.Swaps_each_turn.
//<b>英雄技能</b>召唤三个1/1的微型机器人。每回合切换。 
	{
        

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.BOT_312t);

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int pos =(ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;

            p.callKid(kid, pos, ownplay, false);
            p.callKid(kid, pos, ownplay);
            p.callKid(kid, pos, ownplay);
		}
		public override void onMinionWasSummoned(Playfield p, Minion m, Minion summonedMinion)
		{
			if ((TAG_RACE)summonedMinion.handcard.card.race == TAG_RACE.MECHANICAL)
			{
				p.minionGetRush(summonedMinion);
			}	
		}	

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
            };
        }
	}
}