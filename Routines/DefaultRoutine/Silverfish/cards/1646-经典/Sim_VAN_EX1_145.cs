using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_145 : SimTemplate //* 伺机待发 Preparation
	{
		//The next spell you cast this turn costs (2) less.
		//在本回合中，你所施放的下一个法术的法力值消耗减少（2）点。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            if (ownplay)
            {
                p.playedPreparation = true;
            }
		}

	}
}