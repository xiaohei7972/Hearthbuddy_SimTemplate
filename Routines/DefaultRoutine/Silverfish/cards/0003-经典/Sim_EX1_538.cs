using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_EX1_538 : SimTemplate //* 关门放狗 Unleash the Hounds
	{
		//For each enemy minion, summon a 1/1 Hound with <b>Charge</b>.
		//战场上每有一个敌方随从，便召唤一个1/1并具有<b>冲锋</b>的猎犬。
		
        
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_538t); //hound

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
            int anz = (ownplay) ? p.enemyMinions.Count : p.ownMinions.Count;
            if (anz > 0)
            {
                p.callKid(kid, pos, ownplay, false);
                anz--;
                for (int i = 0; i < anz; i++)
                {
                    p.callKid(kid, pos, ownplay);
                }
            }
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
                new PlayReq(CardDB.ErrorType2.REQ_MINIMUM_ENEMY_MINIONS, 1),
            };
        }
	}
}