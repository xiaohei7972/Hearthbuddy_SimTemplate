using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_043t2 : SimTemplate //* 法术紫水晶 Amethyst Spellstone
	{
        //<b>Lifesteal.</b> Deal $5 damage to a minion. <i>(Take damage from your cards to upgrade.)</i>
        //<b>吸血</b>对一个随从造成$5点伤害。<i>（受到来自你的卡牌的伤害后升级。）</i>
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (ownplay)
            {
                int dmg = (ownplay) ? p.getSpellDamageDamage(5) : p.getEnemySpellDamageDamage(5);
                p.minionGetDamageOrHeal(target, dmg);
                p.minionGetDamageOrHeal(p.ownHero, -dmg);
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
