using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_VAN_EX1_571 : SimTemplate //* Force of Nature
	{
        //召唤三个2/2并具有 冲锋 的树人，在回合结束时，消灭这些树人。

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_158t);//Treant

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int pos =(ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;

            p.callKid(kid, pos, ownplay, false);
            p.callKid(kid, pos, ownplay);
            p.callKid(kid, pos, ownplay);

            foreach(Minion m in p.ownMinions)
            {
                if(m.handcard.card.cardIDenum == CardDB.cardIDEnum.EX1_158t)
                {
                    p.minionGetCharge(m);
                    m.destroyOnOwnTurnEnd = true;
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