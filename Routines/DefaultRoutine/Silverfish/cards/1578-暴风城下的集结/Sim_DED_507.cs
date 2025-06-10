using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_DED_507 : SimTemplate //* 鸦巢观察员 Crow's Nest Lookout
    {
        //战吼：对最左边和最右边的敌方随从造成2点伤害。
        //Battlecry: Deal 2 damage to the left and right-most enemy minions.
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {        
            if (p.enemyMinions.Count > 1)
            {
                p.minionGetDamageOrHeal(p.enemyMinions[0], 2);
                //p.minionAttacksMinion(m, p.enemyMinions[0]);
                //p.minionAttacksMinion(m, p.enemyMinions[p.enemyMinions.Count - 1]);
                p.minionGetDamageOrHeal(p.enemyMinions[p.enemyMinions.Count - 1], 2);
            }
            else if (p.enemyMinions.Count == 1)
            {
                //p.minionAttacksMinion(m, p.enemyMinions[0]);
                p.minionGetDamageOrHeal(p.enemyMinions[0], 2);
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
            };
        }
    }
}
