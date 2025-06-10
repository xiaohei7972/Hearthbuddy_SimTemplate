
using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_REV_921 : SimTemplate //* 锻石师 The Stonewright
                                    //&lt;b&gt;战吼：&lt;/b&gt;在本局对战的剩余时间内，你的图腾获得+2攻击力。
                                    //&lt;b&gt;Battlecry:&lt;/b&gt; For the rest of the game, your Totems have +2 Attack.
    {
      public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
    {
        foreach (Minion m in p.ownMinions)
        {
            if (m.handcard.card.race == CardDB.Race.TOTEM) 
            {
                p.minionGetBuffed(m, 2, 0);
            }
        }
    }

    }


}
        