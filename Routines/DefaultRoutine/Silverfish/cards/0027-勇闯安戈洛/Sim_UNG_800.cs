using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_800 : SimTemplate //* 恐鳞追猎者 Terrorscale Stalker
//<b>Battlecry:</b> Trigger a friendly minion's <b>Deathrattle</b>.
//<b>战吼：</b>触发一个友方随从的<b>亡语</b>。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (target != null) p.doDeathrattles(new List<Minion>() { target });
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_WITH_DEATHRATTLE),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
            };
        }
    }
}