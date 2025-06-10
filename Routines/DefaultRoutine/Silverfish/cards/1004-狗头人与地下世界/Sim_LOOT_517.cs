using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//* 低语元素 Murmuring Elemental
	//<b>Battlecry:</b> Your next <b>Battlecry</b> this turn triggers_twice.
	//<b>战吼：</b>你在本回合使用的下一张<b>战吼</b>牌将触发两次。 
	class Sim_LOOT_517 : SimTemplate
	{


		public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
		{
			if (m.own)
			{
				// 设置玩家下一个战吼效果触发二次的标志
				p.nextBattlecryTriggers = 2;
			}
		}
	}
}