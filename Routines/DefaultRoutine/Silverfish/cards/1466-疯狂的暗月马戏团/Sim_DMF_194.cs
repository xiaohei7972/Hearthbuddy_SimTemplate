using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DMF_194 : SimTemplate //* 赤鳞驯龙者 Redscale Dragontamer
	{
		//<b>Deathrattle:</b> Draw a Dragon.
		//<b>亡语：</b>抽一张龙牌。
		public override void onDeathrattle(Playfield p, Minion m)
        {
            //p.drawACard(CardDB.cardIDEnum.None, m.own);
            foreach (KeyValuePair<CardDB.cardIDEnum, int> kvp in p.prozis.turnDeck)
            {
                // ID 转卡
                CardDB.cardIDEnum deckCard = kvp.Key;
                CardDB.Card minion = CardDB.Instance.getCardDataFromID(deckCard);
                if (minion.type == CardDB.cardtype.MOB && (minion.race == CardDB.Race.DRAGON || minion.race == CardDB.Race.ALL))
                {
                    p.drawACard(deckCard, true);
                    break;
                }
            }
        }

    }
}
