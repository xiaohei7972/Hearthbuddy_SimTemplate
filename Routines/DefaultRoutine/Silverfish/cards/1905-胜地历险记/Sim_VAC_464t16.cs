using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 中立 费用：5
	//Wand of Disintegration
	//裂解魔杖
	//<b>Silence</b> and destroy all enemy minions.
	//<b>沉默</b>并消灭所有敌方随从。
	class Sim_VAC_464t16 : SimTemplate
	{

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 获取所有敌方随从
            List<Minion> enemyMinions = ownplay ? p.enemyMinions : p.ownMinions;

            foreach (Minion m in enemyMinions)
            {
                p.minionGetSilenced(m);  // 沉默所有敌方随从
                p.minionGetDestroyed(m); // 消灭所有敌方随从
            }
        }
    }
}
