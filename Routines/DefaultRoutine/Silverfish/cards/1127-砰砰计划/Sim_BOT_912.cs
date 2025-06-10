using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BOT_912 : SimTemplate //* 坎格尔的无尽大军 Kangor's Endless Army
//Resurrect 3 friendly Mechs. They keep any <b>Magnetic</b> upgrades.
//复活三个友方机械，它们会保留所有<b>磁力</b>升级。 
	{
		
		
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            if (p.ownMaxMana >= 8)
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
            };
        }
	}
}