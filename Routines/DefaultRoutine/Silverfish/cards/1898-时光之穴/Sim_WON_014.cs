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
			CardDB.Card card = null;

			if (choice == 0)
			{
				card = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.WON_014s);
				card.sim_card.onCardPlay(p, ownplay, target, choice);
			}
			if (choice == 1)
			{
				card = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.WON_014s2);
				card.sim_card.onCardPlay(p, ownplay, target, choice);
			}
		}

	}
}
