using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 圣骑士 费用：1
	//Feast and Famine
	//馑时锦食
	//Give your hero +3 Attackthis turn. <b>Manathirst (4):</b> And <b>Lifesteal</b>.
	//在本回合中，使你的英雄获得+3攻击力。<b>法力渴求（4）：</b>以及<b>吸血</b>。
	class Sim_RLK_923 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice, Handmanager.Handcard hc)
		{
			Minion hero = ownplay ? p.ownHero : p.enemyHero;
			p.minionGetTempBuff(hero, 3, 0);
			if (p.ownMaxMana >= hc.card.Manathirst)
				hero.lifesteal = true;
			hero.updateReadyness();

		}

	}
}
