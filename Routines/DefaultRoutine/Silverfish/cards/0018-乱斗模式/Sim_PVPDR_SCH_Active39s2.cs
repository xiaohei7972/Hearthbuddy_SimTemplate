using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //* 疯狂的暴徒 Crazed Mob
    //<b>Silence</b> and destroy all enemy minions.
    //<b>沉默</b>并消灭所有敌方随从。
    class Sim_PVPDR_SCH_Active39s2 : SimTemplate
    {
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.allMinionsGetSilenced(!ownplay);
            List<Minion> minions = ownplay ? p.enemyMinions : p.ownMinions;
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
