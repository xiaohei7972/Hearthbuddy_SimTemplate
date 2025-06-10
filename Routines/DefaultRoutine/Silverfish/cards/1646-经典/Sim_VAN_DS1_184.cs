using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_DS1_184 : SimTemplate //* 追踪术 Tracking
	{
		//Look at the top 3 cards of your deck. Draw one and discard the_others.
		//检视你的牌库顶的三张牌，将其中一张置入手牌，弃掉其余牌。

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            //TODO NOT SUPPORTED YET
            p.drawACard(CardDB.cardIDEnum.None, ownplay);
            //p.evaluatePenality += 100;
		}

	}
}