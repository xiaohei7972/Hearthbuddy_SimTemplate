using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_049 : SimTemplate //* 剧毒箭矢 Toxic Arrow
//Deal $2 damage to a minion. If it survives, give it <b>Poisonous</b>.
//对一个随从造成$2点伤害，如果它依然存活，则获得<b>剧毒</b>。 
    {
        

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = (ownplay) ? p.getSpellDamageDamage(2) : p.getEnemySpellDamageDamage(2);

            p.minionGetDamageOrHeal(target, dmg);
            if (target.Hp > 0) target.poisonous = true;
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