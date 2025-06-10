using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_058: SimTemplate //* 冷冻鱼人 Brrrloc
//<b>Battlecry:</b> <b>Freeze</b> an_enemy.
//<b>战吼：</b><b>冻结</b>一个敌人。 
    {
        

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (target != null) p.minionGetFrozen(target);
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
            };
        }
    }
}