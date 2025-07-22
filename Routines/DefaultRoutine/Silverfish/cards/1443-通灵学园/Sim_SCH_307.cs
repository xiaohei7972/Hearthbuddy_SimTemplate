using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SCH_307 : SimTemplate //* 校园精魂 School Spirits
	{
        //[x]Deal $2 damage to allminions. Shuffle 2 SoulFragments into your deck.
        //对所有随从造成$2点伤害。将两张灵魂残片洗入你的牌库。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (ownplay)
            {
                int dmg = p.getSpellDamageDamage(2);
                p.allMinionsGetDamage(dmg);
                p.AnzSoulFragments += 2;
                p.ownDeckSize += 2;
            }
            else
            {
                int dmg = p.getEnemySpellDamageDamage(2);
                p.allMinionsGetDamage(dmg);
                p.enemyDeckSize += 2;
            }
        }
    }
}
