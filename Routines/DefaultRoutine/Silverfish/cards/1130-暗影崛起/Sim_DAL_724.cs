using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_724 : SimTemplate //* 群体复活 Mass Resurrection
//Summon 3 friendly minions that diedthis game.
//召唤三个在本局对战中死亡的友方随从。 
	{
		
		
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            if (p.ownMaxMana == 10)
            {
                int posi = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
                CardDB.Card kid = CardDB.Instance.getCardDataFromID((p.OwnLastDiedMinion == CardDB.cardIDEnum.None) ? CardDB.cardIDEnum.EX1_345t : p.OwnLastDiedMinion); 
                p.callKid(kid, posi, ownplay, false);
				p.callKid(kid, posi, ownplay);
				p.callKid(kid, posi, ownplay);
            }
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_MINION_DIED_THIS_GAME),
            };
        }
	}
}