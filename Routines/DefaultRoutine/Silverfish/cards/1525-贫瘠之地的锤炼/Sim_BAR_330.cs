using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BAR_330 : SimTemplate //* 獠牙锥刃 Tuskpiercer
	{
        //[x]<b>Deathrattle:</b> Draw a<b>Deathrattle</b> minion.
        //<b>亡语：</b>抽一张<b>亡语</b>随从牌。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.equipWeapon(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.BAR_330), true);
        }

        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.drawACard(CardDB.cardIDEnum.EX1_096, true);
            // 遍历卡组
            //foreach (KeyValuePair<CardDB.cardIDEnum, int> kvp in p.prozis.turnDeck)
            //{
            //    // ID 转卡
            //    CardDB.cardIDEnum deckCard = kvp.Key;
            //    CardDB.Card minion = CardDB.Instance.getCardDataFromID(deckCard);
            //    if ( minion.type == CardDB.cardtype.MOB && minion.deathrattle)
            //    {
            //        p.drawACard(deckCard, true);
            //        break;
            //    }
            //}
        }

        public override void onHeroattack(Playfield p, Minion own, Minion target)
        {
            p.evaluatePenality -= 3;
        }
    }
}
