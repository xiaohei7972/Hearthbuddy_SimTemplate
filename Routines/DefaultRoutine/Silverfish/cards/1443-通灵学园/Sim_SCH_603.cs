using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SCH_603 : SimTemplate //* 明星学员斯特里娜 Star Student Stelina
	{
		//[x]<b>Outcast:</b> Look at 3 cardsin your opponent's hand.Shuffle one of theminto their deck.
		//<b>流放：</b>检视你对手的三张手牌。将其中一张洗入对手的牌库。
		public override void onCardPlay(Playfield p, Minion own, bool ownplay, Minion target, int choice, bool outcast)
		{
			if (outcast)
			{
				p.evaluatePenality -= 1;
			}
			else p.evaluatePenality += 13;
		}
	}
}
