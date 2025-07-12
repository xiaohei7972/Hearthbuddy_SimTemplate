using System;
using System.Collections.Generic;
using System.Text;
using Triton.Game.Mapping;

namespace HREngine.Bots
{
    //武器 牧师 费用：3 攻击力：2 耐久度：2
    //Metal Detector
    //金属探测器
    //After your hero attacks and kills a minion,get a Coin.
    //在你的英雄攻击并消灭一个随从后，获取一张幸运币。
    class Sim_VAC_330 : SimTemplate
    {
        CardDB.Card wcard = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.VAC_330);

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 装备武器
            p.equipWeapon(wcard, ownplay);
        }

        public override void onHeroattack(Playfield p, Minion own, Minion target)
        {
            // 检查己方英雄是否装备了“金属探测器”
            if (own.own && p.ownWeapon.card.cardIDenum == CardDB.cardIDEnum.VAC_330)
            {
                // 检查是否为目标随从并且是否被消灭
                if (!target.isHero && target.Hp <= 0)
                {
                    // 获取一张幸运币
                    p.drawACard(CardDB.cardIDEnum.VAC_COIN1, own.own);
                }

            }
        }

    }
}
