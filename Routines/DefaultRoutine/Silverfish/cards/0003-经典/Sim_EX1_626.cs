using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_EX1_626 : SimTemplate //* 群体驱散 Mass Dispel
	{
		//<b>Silence</b> all enemy minions. Draw a card.
		//<b>沉默</b>所有敌方随从，抽一张牌。

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            p.allMinionsGetSilenced(!ownplay);
            p.drawACard(CardDB.cardIDEnum.None, ownplay);
		}

	}
}