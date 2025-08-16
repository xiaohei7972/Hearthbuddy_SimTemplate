
using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //* 旗标骷髅 Jolly Roger
    //在你的英雄攻击后，召唤一个1/1的亡灵海盗。
    //After your heroattacks, summon a1/1 Undead Pirate.
    class Sim_NX2_006 : SimTemplate
    {
        // 定义要召唤的亡灵海盗随从
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.NX2_006t);
        // 当英雄攻击时触发
        public override void afterHeroattack(Playfield p, Minion triggerMinion, Minion target, Minion hero)
        {
            if (triggerMinion.own == hero.own)
                // 调用随从召唤方法，生成1/1的亡灵海盗
                p.callKid(kid, triggerMinion.zonepos, triggerMinion.own);

        }
    }

}
