using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_BAR_534 : SimTemplate //* 狮群之怒 Pride's Fury
    {
        //Give your minions +1/+3.
        //使你的所有随从获得+1/+3。

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.allMinionOfASideGetBuffed(ownplay, 1, 3);
        }
    }
}
