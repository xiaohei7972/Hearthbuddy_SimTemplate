
using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //随从 萨满祭司 费用：2 攻击力：0 生命值：2
    //Needlerock Totem
    //针岩图腾
    //At the end of your turn, gain 2 Armor anddraw a card.
    //在你的回合结束时，获得2点护甲值并抽一张牌。
    class Sim_DEEP_008 : SimTemplate
    {
        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            if (turnEndOfOwner == triggerEffectMinion.own)
            {
                // 获得2点护甲值
                p.minionGetArmor(p.ownHero, 2);

                // 抽一张牌
                p.drawACard(CardDB.cardIDEnum.None, turnEndOfOwner);
            }
        }
    }
}
