using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_TSC_909 : SimTemplate //* 拖网海象人 Tuskarrrr Trawler
                                    //&lt;b&gt;战吼：&lt;/b&gt;&lt;b&gt;探底&lt;/b&gt;。
                                    //&lt;b&gt;Battlecry:&lt;/b&gt; &lt;b&gt;Dredge&lt;/b&gt;.
    {
        // 使用者使用该卡牌时，会触发这个方法
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            // 探底：从你的牌库中抽一张牌，然后将其置于牌库底部
            p.drawACard(CardDB.cardNameEN.unknown, own.own, true);
        }
    }
}
