using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_HERO_07dbp2 : SimTemplate //* 灵魂分流 Soul Tap
    {
        //<b>Hero Power</b>Draw a card.
        //<b>英雄技能</b>抽一张牌。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.drawACard(CardDB.cardIDEnum.None, ownplay);
        }

    }
}
