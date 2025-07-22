using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_EX1_050 : SimTemplate //* 寒光智者 Coldlight Oracle
//<b>Battlecry:</b> Each player draws 2 cards.
//<b>战吼：</b>每个玩家抽两张牌。 
	{


		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.drawACard(CardDB.cardIDEnum.None, true);
            p.drawACard(CardDB.cardIDEnum.None, true);
            p.drawACard(CardDB.cardIDEnum.None, false);
            p.drawACard(CardDB.cardIDEnum.None, false);

		}


	}
}