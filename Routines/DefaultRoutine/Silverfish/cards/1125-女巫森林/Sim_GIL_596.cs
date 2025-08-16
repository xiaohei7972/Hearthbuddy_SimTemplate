using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //* 银剑 Silver Sword
    //After your hero attacks, give your minions +1/+1.
    //在你的英雄攻击后，你的所有随从获得+1/+1。
    class Sim_GIL_596 : SimTemplate
    {
        CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.GIL_596);

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.equipWeapon(weapon, ownplay);
        }

        public override void afterHeroattack(Playfield p, Minion own, Minion target)
        {
            // 检查己方英雄是否装备了“银剑”
            if (own.own && p.ownWeapon.card.cardIDenum == CardDB.cardIDEnum.GIL_596)
                p.allMinionOfASideGetBuffed(own.own, 1, 1);

        }

    }
}