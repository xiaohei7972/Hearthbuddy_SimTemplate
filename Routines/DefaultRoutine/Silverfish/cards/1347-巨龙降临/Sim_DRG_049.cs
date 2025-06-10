using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DRG_049 : SimTemplate //* 美味飞鱼 Tasty Flyfish
	{
		//<b>Deathrattle:</b> Give a Dragon in your hand +2/+2.
		//<b>亡语：</b>使你手牌中的一张龙牌获得+2/+2。

		public override void onDeathrattle(Playfield p, Minion m)
		{
			List<Handmanager.Handcard> handdragoncards = new List<Handmanager.Handcard>();
			bool dragonInHand = false;
			foreach (Handmanager.Handcard hc in p.owncards)
			{
				if ((TAG_RACE)hc.card.race == TAG_RACE.DRAGON)
				{
					dragonInHand = true;
					handdragoncards.Add(hc);
					break;
				}
			}
			if (dragonInHand)
			{
				//此处随机找龙牌，但是Playfield接口函数中没有寻找随机牌的接口函数，如果需要可以自己添加，具体Playfield.cs 7019行接口函数中
				//此处选择最低生命值模式
				Handmanager.Handcard tar = p.searchRandomMinionInHand(handdragoncards, searchmode.searchLowestHP);
				p.owncards[tar.position].addattack += 2;
				p.owncards[tar.position].addHp +=  2;
			}
		}
	}
}