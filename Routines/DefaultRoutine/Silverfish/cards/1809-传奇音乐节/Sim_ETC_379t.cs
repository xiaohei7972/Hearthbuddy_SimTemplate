using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 德鲁伊 费用：2
	//Dissonant Mood
	//刺耳轻音乐
	//Give your hero +4 Attack this turn. Gain 2 Armor.<i>(Swaps each turn.)</i>
	//在本回合中，使你的英雄获得+4攻击力。获得2点护甲值。<i>（每回合切换。）</i>
	class Sim_ETC_379t : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			Minion hero = ownplay ? p.ownHero : p.enemyHero;
			p.minionGetTempBuff(hero, 4, 0);
			p.minionGetArmor(hero, 2);
            hero.updateReadyness();

		}
		
	}
}
