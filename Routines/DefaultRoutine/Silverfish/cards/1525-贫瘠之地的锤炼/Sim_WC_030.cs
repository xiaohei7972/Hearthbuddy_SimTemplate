using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_WC_030 : SimTemplate //* 吞噬者穆坦努斯 Mutanus the Devourer
	{
        //[x]<b>Battlecry:</b> Eat a minion inyour opponent's hand.Gain its stats.
        //<b>战吼：</b>吃掉你对手手牌中的一张随从牌，获得其属性值。
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if(p.enemyAnzCards > 1)
            {
                p.minionGetBuffed(own, 6, 6);
            }
        }

    }
}
