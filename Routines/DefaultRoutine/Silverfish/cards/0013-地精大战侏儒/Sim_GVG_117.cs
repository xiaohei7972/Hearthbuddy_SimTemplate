using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GVG_117 : SimTemplate //* 加兹鲁维 Gazlowe
//Whenever you cast a 1-Cost spell, add a random Mech to your hand.
//每当你施放一个法力值消耗为（1）的法术，随机将一张机械牌置入你的手牌。 
    {

        
        

        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Minion triggerEffectMinion)
        {
            if (triggerEffectMinion.own == wasOwnCard)
            {
                if (hc.card.type == CardDB.cardtype.SPELL && hc.manacost == 1)
                {
                    p.drawACard(CardDB.cardNameEN.shieldedminibot, wasOwnCard, true);
                }
            }
        }
    }
}