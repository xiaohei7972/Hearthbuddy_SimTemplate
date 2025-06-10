using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_DED_004 : SimTemplate //* 黑水弯刀 Blackwater Cutlass
    {
        //可交易在你交易此牌后，使你手牌中的一张法术牌的法力值消耗减少（1）点。
        //Tradeable After you Trade this, reduce the cost of a spell in your hand by (1).
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {

        }
    }
}
