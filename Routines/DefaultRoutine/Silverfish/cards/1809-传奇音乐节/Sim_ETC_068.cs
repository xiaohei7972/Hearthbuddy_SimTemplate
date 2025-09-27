using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 术士 费用：2 攻击力：2 生命值：2
	//Baritone Imp
	//次中音号小鬼
	//[x]<b>Battlecry:</b> Take Fatiguedamage. Gain that muchAttack and Health.@[x]<b>Battlecry:</b> Take {0} Fatiguedamage. Gain that muchAttack and Health.
	//<b>战吼：</b>受到疲劳伤害。获得等量的攻击力和生命值。@<b>战吼：</b>受到{0}点疲劳伤害。获得等量的攻击力和生命值。
	class Sim_ETC_068 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			if (own.own)
			{
				p.ownHeroFatigue++;
				p.ownHero.getDamageOrHeal(p.ownHeroFatigue, p, false, true);
				p.minionGetBuffed(own, p.ownHeroFatigue, p.ownHeroFatigue);
			}
			else
			{
				p.enemyHeroFatigue++;
				p.enemyHero.getDamageOrHeal(p.enemyHeroFatigue, p, false, true);
				p.minionGetBuffed(own, p.enemyHeroFatigue, p.enemyHeroFatigue);

			}


		}

	}
}
