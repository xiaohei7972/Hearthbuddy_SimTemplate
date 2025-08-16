using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //武器 圣骑士 费用：3 攻击力：3 耐久度：2
    //Volley Maul
    //沙滩排槌
    //[x]After your hero attacks,get a 1-Cost Sunscreenthat gives +1/+2.
    //在你的英雄攻击后，获取一张法力值消耗为（1）的防晒霜。防晒霜可以使随从获得+1/+2。
    class Sim_VAC_921 : SimTemplate
    {
        CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.VAC_921); // 假设沙滩排槌的卡牌ID为 VAC_921

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.equipWeapon(weapon, ownplay); // 装备沙滩排槌
        }
        
        public override void afterHeroattack(Playfield p, Minion own, Minion target)
        {
            // 检查己方英雄是否装备了“沙滩排槌”
            if (own.own && p.ownWeapon.card.cardIDenum == CardDB.cardIDEnum.WW_010t)
            {
                p.drawACard(CardDB.cardIDEnum.VAC_917t, own.own, true); // 英雄攻击后，抽一张防晒霜卡牌
            }
        }

    }
}
