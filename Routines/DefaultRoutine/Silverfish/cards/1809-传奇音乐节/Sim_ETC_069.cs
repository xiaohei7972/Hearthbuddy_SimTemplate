using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 术士 费用：2
	//Crescendo
	//渐强声浪
	//[x]Take Fatigue damage.Deal that much damageto all enemies.@[x]Take {0} Fatigue damage.Deal that much damageto all enemies.
	//受到疲劳伤害。对所有敌人造成等量的伤害。@受到{0}点疲劳伤害。对所有敌人造成等量的伤害。
	class Sim_ETC_069 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
			if (ownplay)
			{
				p.ownHeroFatigue++;
				p.ownHero.getDamageOrHeal(p.ownHeroFatigue, p, false, true);
				p.allCharsOfASideGetDamage(!ownplay, p.getSpellDamageDamage(p.ownHeroFatigue));
			}
			else
			{
				p.enemyHeroFatigue++;
				p.enemyHero.getDamageOrHeal(p.enemyHeroFatigue, p, false, true);
				p.allCharsOfASideGetDamage(!ownplay, p.getSpellDamageDamage(p.ownHeroFatigue));

			}
        }
		
	}
}
