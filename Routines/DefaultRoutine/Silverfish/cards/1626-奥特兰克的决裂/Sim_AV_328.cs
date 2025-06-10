using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_328 : SimTemplate //* 灵魂向导 spiritguide
	{
		//<b>嘲讽</b>，<b>亡语：</b>抽一张神圣法术牌和一张暗影法术牌。
        public override void onDeathrattle(Playfield p, Minion m)
        {
            bool foundFEL = false;
            bool foundHOLY = false;
            // 遍历卡组
            foreach (KeyValuePair<CardDB.cardIDEnum, int> kvp in p.prozis.turnDeck)
            {
                // ID 转卡
                CardDB.cardIDEnum deckCard = kvp.Key;
                CardDB.Card deckSpell = CardDB.Instance.getCardDataFromID(deckCard);
                if (!foundFEL && deckSpell.SpellSchool == CardDB.SpellSchool.FEL)
                {
                    p.drawACard(deckCard, true);
                    foundFEL = true;
                }
                if (!foundHOLY && deckSpell.SpellSchool == CardDB.SpellSchool.HOLY)
                {
                    p.drawACard(deckCard, true);
                    foundHOLY = true;
                }
                if (foundFEL && foundHOLY)
                {
                    break;
                }
            }
        }
		
	}
}
