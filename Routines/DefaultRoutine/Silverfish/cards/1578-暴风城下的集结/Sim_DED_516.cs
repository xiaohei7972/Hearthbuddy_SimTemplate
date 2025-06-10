using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_DED_516 : SimTemplate //* 深水唤醒师 Deepwater Evoker
    {
        //战吼：抽一张法术牌，并获得等同于其法力值消耗的护甲值。
        //Battlecry: Draw a spell. Gain Armor equal to its Cost.
         //p.minionGetArmor(p.ownHero, 3);
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {

        }
    }
}
