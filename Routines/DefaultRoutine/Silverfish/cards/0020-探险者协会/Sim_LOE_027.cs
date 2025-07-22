using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOE_027 : SimTemplate //* 审判 Sacred Trial
//<b>Secret:</b> After your opponent has at least 3 minions and plays another, destroy it.
//<b>奥秘：</b>在你的对手使用一张随从牌后，如果他控制至少三个随从，则将其消灭。 
	{
		

		public override void onSecretPlay(Playfield p, bool ownplay, Minion target, int number)
        {
            List<Minion> temp = (ownplay) ? p.enemyMinions : p.ownMinions;
            if (temp.Count > 3) p.minionGetDestroyed(target);
        }
    }
}