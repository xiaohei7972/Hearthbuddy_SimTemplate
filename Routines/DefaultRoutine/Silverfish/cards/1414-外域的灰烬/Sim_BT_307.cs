using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_307 : SimTemplate //* 黑眼 Darkglare
	{
        //After your hero takes damage, refresh 2 Mana_Crystals.
        //在你的英雄受到伤害后，复原两个法力水晶。
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.anzDark++;
        }
    }
}
