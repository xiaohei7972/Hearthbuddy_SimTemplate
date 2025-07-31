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
	class Sim_ONY_005tb4 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 沉默所有敌方随从
            p.allMinionsGetSilenced(!ownplay);
            List<Minion> minions = ownplay ? p.enemyMinions : p.ownMinions;
            // 消灭所有敌方随从
            foreach (Minion minion in minions)
            {
                p.minionGetDestroyed(minion);
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINIMUM_ENEMY_MINIONS,1),
            };
        }
		
	}
}
