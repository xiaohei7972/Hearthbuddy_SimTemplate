using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_KAR_026 : SimTemplate //* 保卫国王 Protect the King!
//For each enemy minion, summon a 1/1 Pawn with <b>Taunt</b>.
//战场上每有一个敌方随从，便召唤一个1/1并具有<b>嘲讽</b>的禁卫。 
	{
		
		
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.KAR_026t);

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int anz = ownplay ? p.enemyMinions.Count : p.ownMinions.Count;
            int pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
            
            for (int i = 0; i < anz; i++)
            {
                p.callKid(kid, pos, ownplay);
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