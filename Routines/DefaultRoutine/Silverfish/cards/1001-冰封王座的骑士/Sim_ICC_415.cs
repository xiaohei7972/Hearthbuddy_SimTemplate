using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_415: SimTemplate //* 缝合追踪者 Stitched Tracker
//<b>Battlecry:</b> <b>Discover</b> a copy of a minion in your deck.
//<b>战吼：</b>从你的牌库中<b>发现</b>一张随从牌的复制。 
    {
        

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.drawACard(CardDB.cardIDEnum.None, own.own, true);
        }
    }
}