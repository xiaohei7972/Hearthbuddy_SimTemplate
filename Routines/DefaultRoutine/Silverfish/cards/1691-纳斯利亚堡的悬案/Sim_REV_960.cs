using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_REV_960 : SimTemplate //* 灰烬元素 Ashen Elemental
                                    //&lt;b&gt;战吼：&lt;/b&gt;下个回合，每当你的对手抽牌时，对手会受到2点伤害。
                                    //&lt;b&gt;Battlecry:&lt;/b&gt; Whenever your opponent draws a card next turn, they take 2 damage.
    {
        // 使用者使用该卡牌时，会触发这个方法
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            // 设置"下个回合对手抽牌时会受到2点伤害"的标志位

        }
    }
}
