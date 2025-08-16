using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //* 携刃信使 Cutlass Courier
    //在你的英雄攻击后，抽一张海盗牌。
    //After your hero attacks, draw a Pirate.
    class Sim_TSC_085 : SimTemplate
    {
        public override void afterHeroattack(Playfield p, Minion triggerMinion, Minion target, Minion hero)
        {
            if (triggerMinion.own == hero.own)
            {
                if (triggerMinion.own)
                {
                    p.evaluatePenality -= p.mana * 2;
                    foreach (var item in p.prozis.turnDeck)
                    {
                        CardDB.Card card = CardDB.Instance.getCardDataFromID(item.Key);
                        if (card.type == CardDB.cardtype.MOB && card.race == CardDB.Race.PIRATE)
                        {
                            p.drawACard(item.Key, triggerMinion.own);
                            break;
                        }

                    }

                }
            }

        }
    }
}