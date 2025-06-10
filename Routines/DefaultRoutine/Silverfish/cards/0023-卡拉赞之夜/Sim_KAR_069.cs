using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_KAR_069 : SimTemplate //* 吹嘘海盗 Swashburglar
	{
		//<b>Battlecry:</b> Add a random card from another class to_your hand.
		//<b>战吼：</b>随机将一张另一职业的卡牌置入你的手牌。

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.drawACard(CardDB.cardIDEnum.None, own.own, true);
		}
	}
}
