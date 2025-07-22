using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ULD_195 : SimTemplate //* 惊恐的仆从
    {
        //嘲讽，战吼： 发现一张具有嘲讽的随从牌。
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.drawACard(CardDB.cardNameEN.unknown, own.own, true);
        }

    }
}