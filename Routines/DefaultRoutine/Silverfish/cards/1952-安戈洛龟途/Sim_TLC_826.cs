using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 猎人 费用：2
	//Story of Carnassa
	//卡纳莎的故事
	//Shuffle ten 1-Cost 3/2 Raptors into your deck with "<b>Battlecry:</b> Draw a card."
	//将十张法力值消耗为（1）的3/2的迅猛龙洗入你的牌库，这些迅猛龙具有“<b>战吼：</b>抽一张牌。”
	class Sim_TLC_826 : SimTemplate
	{
		CardDB.Card card = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.UNG_920t2);
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			for (int i = 0; i < 10; i++)
			{
				p.AddToDeck(card);
			}
		}
		
	}
}
