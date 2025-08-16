using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //武器 猎人 费用：3 攻击力：1 耐久度：2
    //Trusty Fishing Rod
    //可靠的鱼竿
    //[x]After your hero attacks, summona 1-Cost minionfrom your deck.
    //在你的英雄攻击后，从你的牌库中召唤一个法力值消耗为（1）的随从。
    class Sim_VAC_960 : SimTemplate
    {
        CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.VAC_960);

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.equipWeapon(weapon, ownplay);
        }

        public override void afterHeroattack(Playfield p, Minion own, Minion target)
        {
            // 检查己方英雄是否装备了“可靠的鱼竿”
            if (own.own && p.ownWeapon.card.cardIDenum == CardDB.cardIDEnum.VAC_960)
            {
                int pos = own.own ? p.ownMinions.Count : p.enemyMinions.Count;
                foreach (var item in p.prozis.turnDeck)
                {
                    CardDB.Card card = CardDB.Instance.getCardDataFromID(item.Key);

                    if (card.type == CardDB.cardtype.MOB && card.cost == 1)
                    {
                        // 从牌库中召唤一个法力值消耗为1的随从
                        p.callKid(card, pos, own.own);
                        break;
                    }

                }

            }

        }
        

    }
}
