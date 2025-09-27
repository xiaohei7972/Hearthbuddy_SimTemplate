using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 术士 费用：3
	//Encroaching Insanity
	//狂乱侵蚀
	//Both players takeFatigue damage, twice.
	//双方英雄受到疲劳伤害，受到两次。
	class Sim_YOG_301 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.ownHeroFatigue++;
			p.ownHero.getDamageOrHeal(p.ownHeroFatigue, p, false, true);
			p.ownHeroFatigue++;
			p.ownHero.getDamageOrHeal(p.ownHeroFatigue, p, false, true);

			p.enemyHeroFatigue++;
			p.enemyHero.getDamageOrHeal(p.enemyHeroFatigue, p, false, true);
			p.enemyHeroFatigue++;
			p.enemyHero.getDamageOrHeal(p.enemyHeroFatigue, p, false, true);
		}

	}
}
