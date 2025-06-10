using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOEA16_5 : SimTemplate //* 末日镜像 Mirror of Doom
//Fill your board with 3/3 Mummy Zombies.
//召唤数个3/3的木乃伊僵尸，直到你的随从数量达到上限。 
	{
		
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.LOEA16_5t);

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int MinionsCount = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;

            p.callKid(kid, MinionsCount, ownplay, false);
            int kids = 6 - MinionsCount;
            for (int i = 0; i < kids; i++)
            {
                p.callKid(kid, MinionsCount, ownplay);
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