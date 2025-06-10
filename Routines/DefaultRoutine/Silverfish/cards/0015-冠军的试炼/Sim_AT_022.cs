using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_022 : SimTemplate //* 加拉克苏斯之拳 Fist of Jaraxxus
//When you play or discard this, deal $4 damage to a random enemy.
//当你使用或弃掉这张牌时，随机对一个敌人造成$4点伤害。 
	{
		

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = (ownplay) ? p.getSpellDamageDamage(4) : p.getEnemySpellDamageDamage(4);

            if (ownplay)
            {
                target = p.getEnemyCharTargetForRandomSingleDamage(dmg);
            }
            else
            {
                target = p.searchRandomMinion(p.ownMinions, searchmode.searchLowestHP); 
                if (target == null) target = p.ownHero;
            }
            p.minionGetDamageOrHeal(target, dmg);
        }

        public override bool onCardDicscard(Playfield p, Handmanager.Handcard hc, Minion own, int num, bool checkBonus)
        {
            if (checkBonus) return true;

            bool ownplay = true;
            if (own != null) ownplay = own.own;
            Minion target = null;
            int dmg = (ownplay) ? p.getSpellDamageDamage(4) : p.getEnemySpellDamageDamage(4);

            if (ownplay)
            {
                target = p.getEnemyCharTargetForRandomSingleDamage(dmg);
            }
            else
            {
                target = p.searchRandomMinion(p.ownMinions, searchmode.searchLowestHP); 
                if (target == null) target = p.ownHero;
            }
            p.minionGetDamageOrHeal(target, dmg);
            return true;
        }
    }
}