using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TRL_310 : SimTemplate //* 元素唤醒 Elemental Evocation
//The next Elemental you_play this turn costs (2) less.
//在本回合中，你使用的下一张元素牌的法力值消耗减少（2）点。 
	{
		

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            if (ownplay) p.thisTurnNextElementalReduction += 2;
		}
	}
}