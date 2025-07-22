using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_YOG_519 : SimTemplate // Corrupted Residue
    {
        // 战吼：如果你在上个回合使用过元素牌，则造成7点伤害，随机分配到所有敌人身上。
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            bool playedElementalLastTurn = Hrtprozis.Instance.ownElementalsPlayedLastTurn > 0;

            if (playedElementalLastTurn)
            {
                p.allCharsOfASideGetRandomDamage(false, 7);
            }
        }
    }
}