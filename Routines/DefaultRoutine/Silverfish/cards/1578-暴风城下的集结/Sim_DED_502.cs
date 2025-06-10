using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_DED_502 : SimTemplate //* 正义防御 Righteous Defense
    {
        //将一个随从的攻击力和生命值变为1，并使你手牌中的一张随从牌获得其失去的属性值。
        //Set a minion's Attack and Health to 1. Give the stats it lost to a minion in your hand.
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {

        }
    }
}
