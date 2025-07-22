
using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_NX2_006 : SimTemplate //* 旗标骷髅 Jolly Roger
                                    //在你的英雄攻击后，召唤一个1/1的亡灵海盗。
                                    //After your heroattacks, summon a1/1 Undead Pirate.
    {
        // 定义要召唤的亡灵海盗随从
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.NX2_006t);

        // 当英雄攻击时触发
        public override void onHeroattack(Playfield p, Minion own, Minion target)
        {
            // 调用随从召唤方法，生成1/1的亡灵海盗
            p.callKid(kid, own.zonepos, own.own);
        }
    }


}
        