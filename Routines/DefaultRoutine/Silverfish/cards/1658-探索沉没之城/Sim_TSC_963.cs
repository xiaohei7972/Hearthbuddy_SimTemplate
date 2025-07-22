using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_TSC_963 : SimTemplate //* 鱼排斗士 Filletfighter
//战吼：造成1点伤害。
//Battlecry: Deal 1 damage.
    {
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            // 确保目标存在且有效
            if (target != null)
            {
                int dmg = 1;
                // 对目标造成1点伤害
                p.minionGetDamageOrHeal(target, dmg);
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
            new PlayReq(CardDB.ErrorType2.REQ_NONSELF_TARGET),   // 目标必须是非自身
            new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE), // 需要一个目标
            new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),    // 目标必须是敌方目标
        };
        }
    }
}