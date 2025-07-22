using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_073 : SimTemplate //* 争强好胜 Competitive Spirit
//<b>Secret:</b> When your turn starts, give your minions +1/+1.
//<b>奥秘：</b>在你的回合开始时，使你的所有随从获得+1/+1。 
	{
		

        public override void onSecretPlay(Playfield p, bool ownplay, int number)
        {
            p.allMinionOfASideGetBuffed(ownplay, 1, 1);
        }
    }
}