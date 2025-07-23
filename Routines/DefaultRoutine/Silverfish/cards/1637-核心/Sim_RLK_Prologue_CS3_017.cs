using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 恶魔猎手 费用：3 攻击力：3 生命值：2
	//Gan'arg Glaivesmith
	//甘尔葛战刃铸造师
	//<b>Outcast:</b> Give your hero +3_Attack this turn.
	//<b>流放：</b>在本回合中，使你的英雄获得+3攻击力。
	class Sim_RLK_Prologue_CS3_017 : SimTemplate
	{
		public override void onCardPlay(Playfield p, Minion own, bool ownplay, Minion target, int choice, bool outcast)
		{
			if (outcast)
			{
				Minion hero = own.own ? p.ownHero : p.enemyHero;
				p.minionGetTempBuff(hero, 3, 0);
				hero.updateReadyness();
				p.evaluatePenality -= 1;
			}
			else p.evaluatePenality += 3;
		}

	}
}
