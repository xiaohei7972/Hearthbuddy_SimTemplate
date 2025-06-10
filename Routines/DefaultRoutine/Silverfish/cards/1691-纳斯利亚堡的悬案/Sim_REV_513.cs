using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_REV_513 : SimTemplate //* 健谈的调酒师 Chatty Bartender
    { 
        //If you control a <b>Secret</b> at_the end of your turn, deal 2 damage to all enemies.
        //如果在你的回合结束时，你控制一个<b>奥秘</b>，对所有敌人造成2点伤害。
        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            if (triggerEffectMinion.own == turnEndOfOwner)
            {
                int b = (turnEndOfOwner) ? p.ownSecretsIDList.Count : p.enemySecretCount;
                if (b >= 1) p.allCharsOfASideGetDamage(!triggerEffectMinion.own, 2);

             }
        }

    }
}