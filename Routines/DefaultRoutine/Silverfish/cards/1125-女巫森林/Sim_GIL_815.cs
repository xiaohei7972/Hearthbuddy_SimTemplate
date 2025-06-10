using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GIL_815 : SimTemplate //* 恶毒的银行家 Baleful Banker
//<b>Battlecry:</b> Choose a friendly minion. Shuffle a copy into your deck.
//<b>战吼：</b>选择一个友方随从，将一个复制洗入你的牌库。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            if (target != null)
            {
                if (m.own) p.ownDeckSize++;
                else p.enemyDeckSize++;
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
            };
        }
    }
}