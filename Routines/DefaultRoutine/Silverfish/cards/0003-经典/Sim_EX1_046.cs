using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_EX1_046 : SimTemplate //* 黑铁矮人 Dark Iron Dwarf
	{
		//<b>Battlecry:</b> Give a minion +2_Attack this turn.
		//<b>战吼：</b>在本回合中，使一个随从获得+2攻击力。
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (target != null) p.minionGetTempBuff(target, 2, 0);
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
            };
        }
    }
}
