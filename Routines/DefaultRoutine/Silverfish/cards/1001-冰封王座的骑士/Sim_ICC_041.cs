using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_041: SimTemplate //* 亵渎 Defile
//Deal $1 damage to all minions. If any die, cast this again.
//对所有随从造成$1点伤害，如果有随从死亡，则再次施放该法术。 
    {
        

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = (ownplay) ? p.getSpellDamageDamage(1) : p.getEnemySpellDamageDamage(1);
            int max = 14, cnt = 0;
            bool repeat;
            do
            {
                p.tempTrigger.ownMinionsDied = p.tempTrigger.enemyMinionsDied = 0;
                repeat = false;
                p.allMinionsGetDamage(dmg);
                cnt += p.tempTrigger.enemyMinionsDied;
                p.evaluatePenality -= p.enemyMinions.Count * 2;
                if (p.tempTrigger.ownMinionsDied + p.tempTrigger.enemyMinionsDied > 0)
                {
                    p.tempTrigger.ownMinionsChanged = true;
                    p.tempTrigger.enemyMininsChanged = true;
                    // 插入死亡结算
                    p.updateBoards();
                    repeat = true;
                }
                max--;
                if (max <= 0) break;
            }
            while (repeat);
            if (cnt >= 5) p.evaluatePenality -= 10 * cnt;
        }
    }
}