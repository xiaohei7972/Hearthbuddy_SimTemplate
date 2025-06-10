using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_DED_002 : SimTemplate //* 月光指引 MoonlitGuidance
    {
        //发现你牌库中一张牌的复制。如果你在本回合中使用这张复制，则抽取本体。
        //Discover a copy of a card in your deck. If you play it this turn, draw the original.
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.drawACard(CardDB.cardIDEnum.None, ownplay);
        }

    }
}
