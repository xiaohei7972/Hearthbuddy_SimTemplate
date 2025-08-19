using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //* 守护者斯塔拉蒂斯 Keeper Stalladris
    //After you cast a <b>Choose One</b> spell, add copies of both choices_to_your_hand.
    //在你施放了一个<b>抉择</b>法术后，将每个选项的复制置入你的手牌。 
    class Sim_DAL_732 : SimTemplate
    {

        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Minion triggerEffectMinion)
        {
            if (wasOwnCard == triggerEffectMinion.own)
                if (hc.card.type == CardDB.cardtype.SPELL)
                    if (hc.card.choice == true)
                    {
                        p.drawACard(CardDB.Instance.cardIdstringToEnum(hc.card.cardIDenum + "a"), wasOwnCard, true);
                        p.drawACard(CardDB.Instance.cardIdstringToEnum(hc.card.cardIDenum + "b"), wasOwnCard, true);
                    }


        }
    }
}