using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_904: SimTemplate //* 邪骨骷髅 Wicked Skeleton
//<b>Battlecry:</b> Gain +1/+1 for_each minion that died_this turn.
//<b>战吼：</b>在本回合中每有一个随从死亡，便获得+1/+1。 
    {
        

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            int buff = (own.own) ? p.ownMinionsDiedTurn : p.enemyMinionsDiedTurn;
            p.minionGetBuffed(own, buff, buff);
        }
    }
}