using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BOT_291 : SimTemplate //* 风暴追逐者 Storm Chaser
//<b>Battlecry:</b> Draw a spell from your deck that costs_(5) or more.
//<b>战吼：</b>从你的牌库中抽一张法力值消耗大于或等于（5）点的法术牌。 
	{
		

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.drawACard(CardDB.cardNameEN.unknown, own.own);
		}
	}
}