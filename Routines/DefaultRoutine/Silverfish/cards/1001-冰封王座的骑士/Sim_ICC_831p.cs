using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_831p: SimTemplate //* 生命虹吸 Siphon Life
//<b>Hero Power</b><b>Lifesteal</b>Deal $3 damage.
//<b>英雄技能</b><b>吸血</b>，造成$3点伤害。 
    {
        

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = (ownplay) ? p.getHeroPowerDamage(3) : p.getEnemyHeroPowerDamage(3);

            int oldHp = target.Hp;
            p.minionGetDamageOrHeal(target, dmg);
            if (oldHp > target.Hp) p.applySpellLifesteal(oldHp - target.Hp, ownplay);
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
    }
}