using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_059 : SimTemplate //* 疯狂的炼金师 Crazed Alchemist
	{
		//<b>Battlecry:</b> Swap the Attack and Health of a minion.
		//<b>战吼：</b>使一个随从的攻击力和生命值互换。

		public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
		{
            if (target != null) p.minionSwapAngrAndHP(target);
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}