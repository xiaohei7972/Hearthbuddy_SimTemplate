using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BRMA01_2H : SimTemplate //* 干杯！ Pile On!
//<b>Hero Power</b>Put two minions from your deck and one from your opponent's into the battlefield.
//<b>英雄技能</b>从你的牌库中将两个随从置入战场；对手将一个随从置入战场。 
	{
		
		
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.FP1_007t);

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (p.ownDeckSize > 0)
            {
                p.callKid(kid, p.ownMinions.Count, true, false);
                p.ownDeckSize--;
            }
			
            if (p.enemyDeckSize > 0)
            {
                p.callKid(kid, p.enemyMinions.Count, false, false);
                p.enemyDeckSize--;
            }
			
			if (ownplay)
			{
				if (p.ownDeckSize > 0)
				{
                    p.callKid(kid, p.ownMinions.Count, true, false);
					p.ownDeckSize--;
				}
			}
			else
			{
				if (p.enemyDeckSize > 0)
				{
                    p.callKid(kid, p.enemyMinions.Count, false, false);
					p.enemyDeckSize--;
				}
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