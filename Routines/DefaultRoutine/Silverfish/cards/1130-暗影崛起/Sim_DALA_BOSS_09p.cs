using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DALA_BOSS_09p : SimTemplate //* 历史重演 Repeat History
	{
		//<b>Hero Power</b>Summon a random friendly minion that died this turn.
		//<b>英雄技能</b>随机召唤一个在本回合中死亡的友方随从。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_MINION_DIED_THIS_TURN),
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
            };
        }
	}
}
