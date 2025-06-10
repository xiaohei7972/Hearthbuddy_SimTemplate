using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_DED_511 : SimTemplate //* 吸盘钩手 Suckerhook
    {
        //在你的回合结束时，将你的武器变形成为法力值消耗增加（1）点的武器。
        //At the end of your turn, transform your weapon into one that costs (1) more.
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {

        }
    }
}
