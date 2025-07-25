using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 战士 费用：1
	//Verse Riff
	//主歌乐句
	//[x]Give your hero +2 Attackthis turn. Gain 2 Armor.<b>Finale:</b> Play your last Riff.
	//在本回合中，使你的英雄获得+2攻击力。获得2点护甲值。<b>压轴：</b>演奏你的上一个乐句。
	class Sim_ETC_363 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			Minion hero = ownplay ? p.ownHero : p.enemyHero;
			p.minionGetTempBuff(hero, 2, 0);
			p.minionGetArmor(hero, 2);
            hero.updateReadyness();
			//TODO:riff效果需要加属性
		}
		
	}
}
