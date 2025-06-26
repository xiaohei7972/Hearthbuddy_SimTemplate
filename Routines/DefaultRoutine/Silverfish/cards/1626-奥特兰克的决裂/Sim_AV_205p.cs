using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//英雄技能 德鲁伊 费用：2
	//Nurture
	//培育
	//<b>Choose One -</b> Draw a card; or Gain an empty Mana Crystal.
	//<b>抉择：</b>抽一张牌；或者获得一个空的法力水晶。
	class Sim_AV_205p : SimTemplate
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
				card = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.AV_205pb);
				card.sim_card.onCardPlay(p, ownplay, target, choice);
			}
		}
	}
}
