using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GVG_016 : SimTemplate //* 魔能机甲 Fel Reaver
//Whenever your opponent plays a card, remove the top 3 cards of your deck.
//每当你的对手使用一张卡牌时，便移除你的牌库顶的三张牌。 
    {

        

        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Minion triggerEffectMinion)
        {
            if (wasOwnCard == triggerEffectMinion.own) return; 

            if (triggerEffectMinion.own)
            {
                p.ownDeckSize = Math.Max(0, p.ownDeckSize - 3);
            }
            else
            {
                p.enemyDeckSize = Math.Max(0, p.enemyDeckSize - 3);
            }
        }


    }

}