using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GVG_073 : SimTemplate //* 眼镜蛇射击 Cobra Shot
//Deal $3 damage to a minion and the enemy hero.
//对一个随从和敌方英雄造成$3点伤害。 
    {

        

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = (ownplay) ? p.getSpellDamageDamage(3) : p.getEnemySpellDamageDamage(3);

            p.minionGetDamageOrHeal(target, dmg);

            if (ownplay) p.minionGetDamageOrHeal(p.enemyHero, dmg);
            else p.minionGetDamageOrHeal(p.ownHero, dmg);
        }



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
    }

}