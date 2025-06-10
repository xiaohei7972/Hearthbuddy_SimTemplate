using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_VAN_EX1_624 : SimTemplate //* 神圣之火 Holy Fire
//Deal $5 damage. Restore #5 Health to your hero.
//造成$5点伤害。为你的英雄恢复#5点生命值。 
    {

        
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = (ownplay) ? p.getSpellDamageDamage(5) : p.getEnemySpellDamageDamage(5);
            p.minionGetDamageOrHeal(target, dmg);
            int heal = (ownplay) ? p.getSpellHeal(5) : p.getEnemySpellHeal(5);

            p.minionGetDamageOrHeal(ownplay ? p.ownHero : p.enemyHero, -heal);
        }


        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
    }
}