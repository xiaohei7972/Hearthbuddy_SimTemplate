using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_WC_005 : SimTemplate //* 原初地下城历险家 Primal Dungeoneer
	{
        //[x]<b>Battlecry:</b> Draw a spell.If it's a Nature spell, alsodraw an Elemental.
        //<b>战吼：</b>抽一张法术牌。如果是自然法术牌，则再抽一张元素牌。
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            bool foundNatural = false;
            bool foundSpell = false;
            CardDB.cardIDEnum deckMinion = CardDB.cardIDEnum.None;
            // 遍历卡组
            foreach (KeyValuePair<CardDB.cardIDEnum, int> kvp in p.prozis.turnDeck)
            {
                // ID 转卡
                CardDB.cardIDEnum deckCard = kvp.Key;
                CardDB.Card deckSpell = CardDB.Instance.getCardDataFromID(deckCard);
                if(!foundSpell && deckSpell.type == CardDB.cardtype.SPELL)
                {
                    p.drawACard(deckCard, true);
                    foundSpell = true;
                    if(deckSpell.SpellSchool == CardDB.SpellSchool.NATURE)
                    {
                        foundNatural = true;
                    }
                }
                if(deckSpell.race == CardDB.Race.ELEMENTAL || deckSpell.race == CardDB.Race.ALL)
                {
                    deckMinion = deckCard;
                }
            }
            if (foundNatural)
            {
                p.drawACard(deckMinion, true, true);
                p.evaluatePenality -= 5;
            }
        }

    }
}
