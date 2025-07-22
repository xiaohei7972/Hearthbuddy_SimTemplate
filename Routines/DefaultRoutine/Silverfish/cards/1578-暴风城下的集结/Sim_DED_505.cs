using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_DED_505 : SimTemplate //* 碎舰恶魔 Hullbreaker
    {
        //战吼，亡语：抽一张法术牌。你的英雄受到等同于法术牌法力值消耗的伤害。
        //Battlecry and Deathrattle: Draw a spell. Your hero takes damage equal to its Cost.
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {

        }
    }
}
