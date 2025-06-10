using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_204 : SimTemplate //* 诈死 Cheat Death
//<b>Secret:</b> When a friendly minion dies, return it to your hand.It costs (2) less.
//<b>奥秘：</b>当一个友方随从死亡时，将其移回你的手牌，它的法力值消耗减少（2）点。 
	{
		
		
		public override void onSecretPlay(Playfield p, bool ownplay, int number)
        {
            if (ownplay)
            {
                p.drawACard(p.revivingOwnMinion, ownplay, true);
            }
            else
            {
                p.drawACard(p.revivingEnemyMinion, ownplay, true);
            }

        }
	}
}