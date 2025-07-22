using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_FP1_018 : SimTemplate //* 复制 Duplicate
//<b>Secret:</b> When a friendly minion dies, put 2 copies of it into your hand.
//<b>奥秘：</b>当一个友方随从死亡时，将两张该随从的复制置入你的手牌。 
	{
        


        public override void onSecretPlay(Playfield p, bool ownplay, int number)
        {
            if (ownplay)
            {
                p.drawACard(p.revivingOwnMinion, ownplay, true);
                p.drawACard(p.revivingOwnMinion, ownplay, true);
            }
            else
            {
                p.drawACard(p.revivingEnemyMinion, ownplay, true);
                p.drawACard(p.revivingEnemyMinion, ownplay, true);
            }

        }

	}

}