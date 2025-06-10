using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GVG_019 : SimTemplate //* 恶魔之心 Demonheart
//Deal $5 damage to a minion.  If it's a friendly Demon, give it +5/+5 instead.
//对一个随从造成$5点伤害，如果该随从是友方恶魔，则改为使其获得+5/+5。 
    {

        

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (target.own == ownplay && (TAG_RACE)target.handcard.card.race == TAG_RACE.DEMON)
            {
                
                p.minionGetBuffed(target, 5, 5);
            }
            else
            {
                int dmg = (ownplay) ? p.getSpellDamageDamage(5) : p.getEnemySpellDamageDamage(5);

                p.minionGetDamageOrHeal(target, dmg);
            }
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