using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 德鲁伊 费用：2
	//Invigorate
	//鼓舞
	//<b>Choose One -</b> Gain an empty Mana Crystal; or Draw a card.
	//<b>抉择：</b>获得一个空的法力水晶；或者抽一张牌。
	class Sim_WON_014 : SimTemplate
	{

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{

			if (choice == 1 || (p.ownFandralStaghelm > 0 && ownplay))
			{
				p.ownMaxMana++;
			}
			if (choice == 2 || (p.ownFandralStaghelm > 0 && ownplay))
			{
				p.drawACard(CardDB.cardNameEN.unknown, ownplay);
			}

		}
	}
}
