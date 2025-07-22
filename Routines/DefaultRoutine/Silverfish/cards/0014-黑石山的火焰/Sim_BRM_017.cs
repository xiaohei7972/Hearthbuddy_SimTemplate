using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BRM_017 : SimTemplate //* 复活术 Resurrect
//Summon a random friendly minion that died this game.
//随机召唤一个在本局对战中死亡的友方随从。 
	{
		
		
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            if (p.ownMaxMana >= 6)
            {
                int posi = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
                CardDB.Card kid = CardDB.Instance.getCardDataFromID((p.OwnLastDiedMinion == CardDB.cardIDEnum.None) ? CardDB.cardIDEnum.EX1_345t : p.OwnLastDiedMinion); 
                p.callKid(kid, posi, ownplay, false);
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