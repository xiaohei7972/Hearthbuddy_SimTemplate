
using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_TOY_510 : SimTemplate // 挖掘宝藏
    {
        // 抽一张随从牌。如果是海盗牌，获取一张幸运币

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 抽一张卡牌，获取手牌中最后抽到的卡牌
            p.drawACard(CardDB.cardIDEnum.None, ownplay);

            // 获取最后抽到的手牌
            Handmanager.Handcard lastDrawnCard = p.owncards[p.owncards.Count - 1];

            // 如果抽到的是随从牌且是海盗
            if (lastDrawnCard.card.type == CardDB.cardtype.MOB && (TAG_RACE)lastDrawnCard.card.race == TAG_RACE.PIRATE)
            {
                // 获取一张幸运币
                p.drawACard(CardDB.cardIDEnum.GAME_005, ownplay);
            }
        }
    }
}
