using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_088 : SimTemplate //* 始祖龟预言者 Tortollan Primalist
//<b>Battlecry:</b> <b>Discover</b> a spell_and cast it with random targets.
//<b>战吼：</b><b>发现</b>一张法术牌，并向随机目标施放。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
			p.evaluatePenality -= 10;
        }
    }
}