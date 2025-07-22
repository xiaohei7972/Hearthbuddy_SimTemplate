using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_ULD_716 : SimTemplate //* 鱼人为王 Tip the Scales
//Summon 7 Murlocs from your deck.
//从你的牌库中召唤七个鱼人。 
	{
        

		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_507);

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            List<Minion> temp = (ownplay) ? p.ownMinions : p.enemyMinions;
			int num = 7 - temp.Count;
			
			if (num > p.ownDeckSize) num = p.ownDeckSize;
			p.ownDeckSize -= num;
			for (int i = 7 - num; i < 7; i++)
			{	
		        p.callKid(kid, i, ownplay);
			}
			if (p.ownDeckSize == 0)
			{	
		        p.evaluatePenality += 500;		
		    }
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}