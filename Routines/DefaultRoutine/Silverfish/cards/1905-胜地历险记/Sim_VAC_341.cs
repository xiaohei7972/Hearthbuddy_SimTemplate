using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //随从 战士 费用：4 攻击力：3 生命值：4
    //Undercooked Calamari
    //断生鱿鱼
    //[x]<b>Battlecry:</b> Destroy an enemyminion with Attack less thanor equal to this minion's.
    //<b>战吼：</b>消灭一个攻击力小于或等于本随从的敌方随从。
    class Sim_VAC_341 : SimTemplate
    {
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (target != null && target.Angr <= own.Angr)
            {
                // 消灭目标敌方随从
                p.minionGetDestroyed(target);
            }

        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要目标
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 目标必须是随从
            };
        }
    }
}
