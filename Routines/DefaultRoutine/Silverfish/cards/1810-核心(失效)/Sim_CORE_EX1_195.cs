using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CORE_EX1_195 : SimTemplate //* 库尔提拉斯教士 Kul Tiran Chaplain
	{
		//<b>Battlecry:</b> Give a friendly minion +2 Health.
		//<b>战吼：</b>使一个友方随从获得+2生命值。
		public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
		{
			if (target != null) p.minionGetBuffed(target, 0, 2);
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
