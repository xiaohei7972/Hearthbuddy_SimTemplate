using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_EX1_178 : SimTemplate //* 战争古树 Ancient of War
	{
		//<b>Choose One -</b>+5 Attack; or +5 Health and <b>Taunt</b>.
		//<b>抉择：</b>+5攻击力；或者+5生命值并具有<b>嘲讽</b>。

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (p.ownFandralStaghelm > 0 && own.own)
            {
                for (int iChoice = 1; iChoice < 3; iChoice++)
                {
                    PenalityManager.Instance.getChooseCard(own.handcard.card, choice).sim_card.onCardPlay(p, own.own, own, iChoice);
                }
            }
            else PenalityManager.Instance.getChooseCard(own.handcard.card, choice).sim_card.onCardPlay(p, own.own, own, choice);
        }
    }
}