using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_059 : SimTemplate //* 空间撕裂器 Dimensional Ripper
//Summon 2 copies of a minion in your deck.
//召唤你的牌库中一个随从的两个复制。 
	{
		

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.LOE_011);

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int pos =(ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;

            p.callKid(kid, pos, ownplay, false);
            p.callKid(kid, pos, ownplay);
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
            };
        }
	}
}