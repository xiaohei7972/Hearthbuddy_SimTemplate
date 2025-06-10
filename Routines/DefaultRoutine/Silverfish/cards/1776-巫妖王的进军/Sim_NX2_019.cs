
using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_NX2_019 : SimTemplate //* 精神灼烧 Mind Sear
                                    //对一个随从造成2点伤害。如果该随从死亡，则对敌方英雄造成3点伤害。
                                    //Deal 2 damage to a minion. If it dies,deal 3 damage to the enemy hero.
    {
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 根据当前是己方回合还是敌方回合来获取法术伤害
            int dmg = (ownplay) ? p.getSpellDamageDamage(2) : p.getEnemySpellDamageDamage(2);

            // 对目标随从造成伤害
            p.minionGetDamageOrHeal(target, dmg);

            // 如果随从在受到伤害后死亡，对敌方英雄造成3点伤害
            if (target.Hp <= 0 && !target.divineshild && !target.immune)
            {
                p.minionGetDamageOrHeal(p.enemyHero, 3);
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),  // 需要选择一个目标
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),   // 目标必须是随从
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),    // 目标必须是敌方
            };
        }
    }


}
        
        
        