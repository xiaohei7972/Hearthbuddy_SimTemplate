using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_081: SimTemplate //* 达卡莱防御者 Drakkari Defender
//<b>Taunt</b><b>Overload:</b> (3)
//<b>嘲讽</b>，<b>过载：</b>（3） 
    {
        

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (own.own) p.ueberladung += 3;
        }
    }
}