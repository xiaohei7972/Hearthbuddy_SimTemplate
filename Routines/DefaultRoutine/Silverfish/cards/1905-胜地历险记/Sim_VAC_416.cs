using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //法术 猎人 费用：5
    //Death Roll
    //死亡翻滚
    //[x]Destroy an enemy minion. Deal damage equal to itsAttack randomly splitamong all enemies.
    //消灭一个敌方随从。造成等同于其攻击力的伤害，随机分配到所有敌人身上。
    class Sim_VAC_416 : SimTemplate
    {

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (target != null)
            {
                int attackValue = target.Angr; // 获取目标随从的攻击力

                // 消灭目标随从
                p.minionGetDestroyed(target);

                // 将等同于攻击力的伤害随机分配到所有敌人身上
                p.allCharsOfASideGetRandomDamage(!ownplay, attackValue);
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[]{
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要选择一个目标
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 目标只能是随从
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET) // 目标只能是敌方
            };
        }
    }
}
