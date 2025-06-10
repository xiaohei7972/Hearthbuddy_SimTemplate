using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BAR_844 : SimTemplate //* 前锋战斧 Outrider's Axe
    {
        //After your hero attacks and kills a minion, draw a card.
        //在你的英雄攻击并消灭一个随从后，抽一张牌。
        CardDB.Card wcard = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.BAR_844);

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.equipWeapon(wcard, ownplay);
        }

        public override void onHeroattack(Playfield p, Minion triggerMinion, Minion target, Minion hero)
        {
            if (target.Hp <= 0)
            {
                p.drawACard(CardDB.cardIDEnum.None, hero.own);
            }
        }

    }
}
