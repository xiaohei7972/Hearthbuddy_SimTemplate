using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DRG_320 : SimTemplate //* 觉醒巨龙伊瑟拉 Ysera, Unleashed
	{
		//[x]<b>Battlecry:</b> Shuffle 7 DreamPortals into your deck.When drawn, summona random Dragon.
		//<b>战吼：</b>将七张“梦境之门”洗入你的牌库。当抽到梦境之门时，随机召唤一条龙。
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			if (own.own)
			{
				p.ownDeckSize += 7;
			}
			else p.enemyDeckSize += 7;
		}
	}
}