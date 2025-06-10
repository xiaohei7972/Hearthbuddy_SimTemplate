using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SCH_701 : SimTemplate //* 灵魂剥离 Soul Shear
	{
        //[x]Deal $3 damage to aminion. Shuffle 2 SoulFragments into your deck.
        //对一个随从造成$3点伤害。将两张灵魂残片洗入你的牌库。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (target != null)
                if (ownplay)
                {
                    int dmg = p.getSpellDamageDamage(3);
                    p.minionGetDamageOrHeal(target, dmg);
                    p.AnzSoulFragments += 2;
                    p.ownDeckSize += 2;
                }
                else
                {
                    int dmg = p.getEnemySpellDamageDamage(3);
                    p.minionGetDamageOrHeal(target, dmg);
                    p.enemyDeckSize += 2;
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
