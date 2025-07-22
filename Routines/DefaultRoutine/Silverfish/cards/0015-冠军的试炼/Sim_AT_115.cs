using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_115 : SimTemplate //* 击剑教头 Fencing Coach
//<b>Battlecry:</b> The next time you use your Hero Power, it costs (2) less.
//<b>战吼：</b>你的下一个英雄技能的法力值消耗减少（2）点。 
	{
		

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			if (own.own) p.ownHeroPowerCostLessOnce -= 2;
			else p.enemyHeroPowerCostLessOnce -= 2;
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}