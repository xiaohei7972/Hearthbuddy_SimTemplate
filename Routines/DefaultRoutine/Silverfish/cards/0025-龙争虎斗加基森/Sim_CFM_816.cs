using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_816 : SimTemplate //* 兔妖教头 Virmen Sensei
//<b>Battlecry:</b> Give a friendly Beast +2/+2.
//<b>战吼：</b>使一个友方野兽获得+2/+2。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            if (target != null) p.minionGetBuffed(target, 2, 2);
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_WITH_RACE, 20),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
            };
        }
    }
}