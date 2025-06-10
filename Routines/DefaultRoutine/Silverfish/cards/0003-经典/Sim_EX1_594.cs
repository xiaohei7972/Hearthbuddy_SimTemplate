using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_EX1_594 : SimTemplate //* 蒸发 Vaporize
	{
		//<b>Secret:</b> When a minion attacks your hero, destroy it.
		//<b>奥秘：</b>当一个随从攻击你的英雄，将其消灭。
        public override void onSecretPlay(Playfield p, bool ownplay, Minion target, int number)
        {
            p.minionGetDestroyed(target);
        }

	}

}