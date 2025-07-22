using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BAR_551 : SimTemplate //* 巴拉克·科多班恩 Barak Kodobane
	{
        //[x]<b>Battlecry:</b> Draw a 1, 2,__and 3-Cost spell.
        //<b>战吼：</b>抽取法力值消耗为（1），（2）和（3）点的法术牌各一张。
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
			bool found1 = false;
			bool found2 = false;
			bool found3 = false;

			// 遍历卡组
			foreach (KeyValuePair<CardDB.cardIDEnum, int> kvp in p.prozis.turnDeck)
			{
				// ID 转卡
				CardDB.cardIDEnum deckCard = kvp.Key;
				CardDB.Card deckSpell = CardDB.Instance.getCardDataFromID(deckCard);
				if (deckSpell.type == CardDB.cardtype.SPELL)
				{
					if(!found1 && deckSpell.cost == 1)
                    {
						found1 = true;
						p.drawACard(deckCard, true);
					}
					if (!found2 && deckSpell.cost == 2)
					{
						found2 = true;
						p.drawACard(deckCard, true);
					}
					if (!found3 && deckSpell.cost == 3)
					{
						found3 = true;
						p.drawACard(deckCard, true);
						if(p.setMankrik)
                        {
							p.enemyHero.Hp -= 3;
							p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.BAR_721t2), p.ownMinions.Count, true);
                        }
					}
				}
			}
		}

    }
}
