using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_TTN_095 : SimTemplate // Flow Archive Keeper
    {
        // <b>战吼：</b> 你的下一张元素牌的法力值消耗减少（2）点。
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            // 增加下一张元素牌的法力值消耗减少量
            if (own.own)
            {
                p.nextElementalReduction += 2;
            }
        }
    }
}