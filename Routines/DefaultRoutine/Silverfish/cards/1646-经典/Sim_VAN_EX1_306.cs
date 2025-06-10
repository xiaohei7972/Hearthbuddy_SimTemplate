using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_306 : SimTemplate //* 魔犬 Felstalker
	{
		//<b>Battlecry:</b> Discard a random card.
		//<b>战吼：</b>随机弃一张牌。
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.discardCards(1, own.own);
		}
	}
}