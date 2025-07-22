using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CS2_147 : SimTemplate //* 侏儒发明家 Gnomish Inventor
	{
		//<b>Battlecry:</b> Draw a card.
		//<b>战吼：</b>抽一张牌。
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.drawACard(CardDB.cardIDEnum.None, own.own);
		}


	}
}