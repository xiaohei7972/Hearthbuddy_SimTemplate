using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //* 冰霜新星 Frost Nova
    //<b>Freeze</b> all enemy minions.
    //<b>冻结</b>所有敌方随从。
    class Sim_CS2_026 : SimTemplate
    {
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            List<Minion> minions = (ownplay) ? p.enemyMinions : p.ownMinions;
            foreach (Minion minion in minions)
            {
                p.minionGetFrozen(minion);
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