using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //* 顽石元素 Rumbling Elemental
    //After you play a <b>Battlecry</b> minion, deal 2 damage to a random enemy.
    //在你使用一张具有<b>战吼</b>的随从牌后，随机对一个敌人造成2点伤害。 
    class Sim_LOE_016 : SimTemplate
    {
        public override void onCardIsAfterToBePlayed(Playfield p, Minion playedMinion, bool wasOwnCard, Minion triggerEffectMinion)
        {
            if (triggerEffectMinion.own == wasOwnCard)
            {

                Minion target = p.getEnemyCharTargetForRandomSingleDamage(2);
                if (target != null)
                {
                    p.minionGetDamageOrHeal(target, 2, true);
                }

            }
        }

        // public override void onMinionWasSummoned(Playfield p, Minion m, Minion summonedMinion)
        // {
        //     if (summonedMinion.handcard.card.battlecry && summonedMinion.playedFromHand && summonedMinion.own == m.own && summonedMinion.entitiyID != m.entitiyID)
        //     {
        //         Minion target = null;

        //         if (m.own)
        //         {
        //             target = p.getEnemyCharTargetForRandomSingleDamage(2);
        //         }
        //         else
        //         {
        //             target = p.searchRandomMinion(p.ownMinions, searchmode.searchHighestAttack);
        //             if (target == null) target = p.ownHero;
        //         }
        //         p.minionGetDamageOrHeal(target, 2, true);
        //     }
        // }
    }
}