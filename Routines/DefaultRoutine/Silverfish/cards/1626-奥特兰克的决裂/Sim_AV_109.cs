using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 战士 费用：2
	//Frozen Buckler
	//凝冰护盾
	//Gain 10 Armor. At the start of your next turn, lose 5 Armor.
	//获得10点护甲值。在你的下个回合开始时，失去5点护甲值。
	class Sim_AV_109 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			Minion hero = ownplay ? p.ownHero : p.enemyHero;
			p.minionGetArmor(hero, 10);
			//给英雄添加附魔,下回合开始时会减少5点护甲
			hero.enchs += "AV_109e";
		}

	}
}
