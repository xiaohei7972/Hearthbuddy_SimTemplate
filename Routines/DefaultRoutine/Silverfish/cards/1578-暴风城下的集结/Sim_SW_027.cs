using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SW_027 : SimTemplate //* 海上威胁 Shiver Their Timbers!
	{
        //Deal $2 damage to a minion. If you control a Pirate, deal $5 instead.
        //对一个随从造成$2点伤害。如果你控制一个海盗，则改为造成$5点伤害。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (ownplay)
            {
                bool haspet = false;
                foreach (Minion m in p.ownMinions)
                {
                    if ((TAG_RACE)m.handcard.card.race == TAG_RACE.PIRATE)
                    {
                        haspet = true;
                        break;
                    }
                }

                int dmg = (ownplay) ? p.getSpellDamageDamage(2) : p.getEnemySpellDamageDamage(2);
                if (haspet) dmg = (ownplay) ? p.getSpellDamageDamage(5) : p.getEnemySpellDamageDamage(5);
                p.minionGetDamageOrHeal(target, dmg);
            }
        }
        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
    }
}
