using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_DRG_106 : SimTemplate //* 奥术吐息 Arcane Breath
    {
        //Deal $2 damage to a minion. If you're holding a Dragon, <b>Discover</b> a spell.
        //对一个随从造成$2点伤害。如果你的手牌中有龙牌，便<b>发现</b>一张法术牌。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = (ownplay) ? p.getSpellDamageDamage(2) : p.getEnemySpellDamageDamage(2);
            p.minionGetDamageOrHeal(target, dmg);

            if (ownplay)
            {
                bool dragonInHand = false;
                foreach (Handmanager.Handcard hc in p.owncards)
                {
                    if ((TAG_RACE)hc.card.race == TAG_RACE.DRAGON)
                    {
                        dragonInHand = true;
                        break;
                    }
                }
                if (dragonInHand)
                {
                    p.drawACard(CardDB.cardNameEN.thecoin, ownplay, true);
                }
                else
                {
                    if (p.enemyAnzCards >= 2)
                    {
                        p.drawACard(CardDB.cardNameEN.thecoin, ownplay, true);
                    }
                }

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
