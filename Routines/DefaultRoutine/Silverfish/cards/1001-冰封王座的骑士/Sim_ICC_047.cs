using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_047 : SimTemplate //* 命运织网蛛 Fatespinner
//<b>Choose a Deathrattle (Secretly) -</b> Deal 3 damage to all minions; or Give them +2/+2.
//<b>秘密亡语：</b><b>抉择：</b>对所有随从造成3点伤害；或者使所有随从获得+2/+2。 
    {
        
        
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            int pen = 0;
            switch (choice)
            {
                case 1:
                    if (p.ownMinions.Count + 2 > p.enemyMinions.Count) pen = -5;
                    else pen = 5;
                    break;
                case 2:
                    if (p.enemyMinions.Count >= p.ownMinions.Count) pen = -8;
                    break;
            }
            p.evaluatePenality += pen;
        }
    }
}