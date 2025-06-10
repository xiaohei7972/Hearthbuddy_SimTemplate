using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_DED_501 : SimTemplate //* 金翼鹦鹉 Sunwing Squawker
    {
        //战吼：重复你上一个对友方随从施放的法术，施放在本随从身上。
        //Battlecry: Repeat the last spell you've cast on a friendly minion on this.
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {

        }

        public override void onAuraEnds(Playfield p, Minion m)
        {
            m.lifesteal = false;
        }
    }
}
