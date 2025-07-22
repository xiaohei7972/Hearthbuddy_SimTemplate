using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_ULD_152 : SimTemplate //* 压感陷阱 Pressure Plate
//<b>Secret:</b> After your opponent casts a spell, destroy a random enemy_minion.
//<b>奥秘：</b>在你的对手施放一个法术后，随机消灭一个敌方随从。 
	{
		
        public override void onSecretPlay(Playfield p, bool ownplay, int number)
        {
		    Minion m = p.searchRandomMinion(ownplay ? p.enemyMinions : p.ownMinions, searchmode.searchLowestHP);
            if (m != null) p.minionGetDestroyed(m);				
        }
	}
}