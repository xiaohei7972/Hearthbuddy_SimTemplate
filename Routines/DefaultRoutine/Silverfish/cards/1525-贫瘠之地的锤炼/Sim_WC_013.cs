using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_WC_013 : SimTemplate //* 虔诚地下城历险家 Devout Dungeoneer
	{
        //[x]<b>Battlecry:</b> Draw a spell.If it's a Holy spell,reduce its Cost by (2).
        //<b>战吼：</b>抽一张法术牌。如果是神圣法术牌，则使其法力值消耗减少（2）点。
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            // 遍历卡组
            foreach (KeyValuePair<CardDB.cardIDEnum, int> kvp in p.prozis.turnDeck)
            {
                // ID 转卡
                CardDB.cardIDEnum deckCard = kvp.Key;
                CardDB.Card spell = CardDB.Instance.getCardDataFromID(deckCard);
                if (spell.type == CardDB.cardtype.SPELL)
                {
                    p.drawACard(deckCard, true);
                    if(spell.SpellSchool == CardDB.SpellSchool.HOLY)
                    {
                        p.owncards[p.owncards.Count - 1].manacost -= 2;
                    }
                }
            }
        }

    }
}
