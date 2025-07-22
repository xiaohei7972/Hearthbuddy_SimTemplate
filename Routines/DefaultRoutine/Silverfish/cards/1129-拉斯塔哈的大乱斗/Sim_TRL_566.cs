using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_TRL_566: SimTemplate //* 荒野的复仇 Revenge of the Wild
//Summon your Beasts that died this turn.
//召唤在本回合中死亡的友方野兽。 
    {
        

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)		
        {			
            foreach (GraveYardItem gyi in p.diedMinions.ToArray()) 
        		
			{							
				if (gyi.own == ownplay)
				{
					CardDB.Card card = CardDB.Instance.getCardDataFromID(gyi.cardid);
					int pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
					p.callKid(card, p.ownMinions.Count, gyi.own);
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