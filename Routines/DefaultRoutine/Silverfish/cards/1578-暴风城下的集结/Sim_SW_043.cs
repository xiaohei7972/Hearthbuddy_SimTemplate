using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SW_043 : SimTemplate //* 邪能吞食者 Felgorger
	{
		//<b>Battlecry:</b> Draw a Fel spell. Reduce its Cost by (2).
		//<b>战吼：</b>抽一张邪能法术牌，使其法力值消耗减少（2）点。
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            foreach (KeyValuePair<CardDB.cardIDEnum, int> kvp in p.prozis.turnDeck)
            {
                // ID 转卡
                CardDB.cardIDEnum deckCard = kvp.Key;
                CardDB.Card card = CardDB.Instance.getCardDataFromID(deckCard);
                if (card.SpellSchool == CardDB.SpellSchool.FEL && card.type == CardDB.cardtype.SPELL)
                {
                    p.drawACard(deckCard, true, false);
                    p.owncards[p.owncards.Count - 1].manacost -= 2;
                    p.evaluatePenality -= 10;
                    return;
                }
            }
        }

    }
}
