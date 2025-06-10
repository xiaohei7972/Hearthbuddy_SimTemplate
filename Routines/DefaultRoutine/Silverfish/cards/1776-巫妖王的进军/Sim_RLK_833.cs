using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_RLK_833 : SimTemplate //* 骨鸡蛋 Foul Egg
                                    //&lt;b&gt;亡语：&lt;/b&gt;召唤一只3/3的亡灵小鸡。
                                    //&lt;b&gt;Deathrattle:&lt;/b&gt; Summon a 3/3 Undead Chicken.
    {
        // 当该随从死亡时，会触发这个方法
        public override void onDeathrattle(Playfield p, Minion m)
        {
            // 召唤一只3/3的亡灵小鸡
            p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_161), m.zonepos - 1, m.own);
        }
    }
}
