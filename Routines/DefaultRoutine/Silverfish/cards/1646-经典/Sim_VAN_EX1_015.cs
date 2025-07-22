using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_015 : SimTemplate //* 工程师学徒 Novice Engineer
	{
		//<b>Battlecry:</b> Draw a card.
		//<b>战吼：</b>抽一张牌。
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.drawACard(CardDB.cardIDEnum.None, own.own);
		}


	}
}