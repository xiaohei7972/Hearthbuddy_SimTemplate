using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_334 : SimTemplate //* 女伯爵莉亚德琳 Lady Liadrin
	{
		//[x]<b>Battlecry:</b> Add a copy ofeach spell you cast onfriendly characters thisgame to your hand.
		//<b>战吼：</b>将你在本局对战中施放在友方角色上的所有法术的复制置入你的手牌。
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			if (own.own)
			{
				foreach (KeyValuePair<CardDB.cardIDEnum, int> e in Probabilitymaker.Instance.ownGraveyard)
				{
					if (e.Key == CardDB.cardIDEnum.BT_025 || e.Key == CardDB.cardIDEnum.BT_292 || e.Key == CardDB.cardIDEnum.BT_024 || e.Key == CardDB.cardIDEnum.SCH_138 || e.Key == CardDB.cardIDEnum.ULD_143)
					{
						for (int i = 0; i < e.Value; i++)
						{
							p.drawACard(e.Key, own.own, true);
						}
					}
				}
			}
		}

	}
}
