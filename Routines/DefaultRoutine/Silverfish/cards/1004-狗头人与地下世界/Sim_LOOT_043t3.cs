using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_043t3 : SimTemplate //* 大型法术紫水晶 Greater Amethyst Spellstone
	{
        //<b>Lifesteal.</b> Deal $7 damage to a minion.
        //<b>吸血</b>对一个随从造成$7点伤害。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = p.getSpellDamageDamage(7) ;
            p.minionGetDamageOrHeal(target, dmg);
            p.minionGetDamageOrHeal(p.ownHero, -dmg);
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
