using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GVG_042 : SimTemplate //* 耐普图隆 Neptulon
//<b>Battlecry:</b> Add 4 random Murlocs to your hand. <b>Overload:</b> (3)
//<b>战吼：</b>随机将四张鱼人牌置入你的手牌，<b>过载：</b>（3） 
    {
        

        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            for (int i = 0; i < 4; i++)
            {
                p.drawACard(CardDB.cardNameEN.murlocraider, m.own, true);
            }
            if (m.own) p.ueberladung += 3;
        }
    }
}