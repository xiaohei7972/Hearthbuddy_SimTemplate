using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_DED_500 : SimTemplate //* 分赃专员 Wealth Redistributor
    {
        //嘲讽，战吼：交换攻击力最高和最低的随从的攻击力。
        //Battlecry: Repeat the last spell you've cast on a friendly minion on this.
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {

        }
    }
}
