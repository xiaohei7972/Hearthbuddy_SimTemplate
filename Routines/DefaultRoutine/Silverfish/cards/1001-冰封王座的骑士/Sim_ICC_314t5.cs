using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_314t5 : SimTemplate //* 凋零缠绕 Death Coil
//Deal $5 damage to an enemy, or restore #5 Health to a friendly character.
//对一个敌人造成$5点伤害，或为一个友方角色恢复#5点生命值。 
    {
        

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = 0;
            if (target.own == ownplay) dmg = -1 * ((ownplay) ? p.getSpellHeal(5) : p.getEnemySpellHeal(5));
            else dmg = (ownplay) ? p.getSpellDamageDamage(5) : p.getEnemySpellDamageDamage(5);
            p.minionGetDamageOrHeal(target, dmg);
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
    }
}