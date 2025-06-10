using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CS2_102_H3 : SimTemplate //* 全副武装！ Armor Up!
	{
		//<b>Hero Power</b>Gain 2 Armor.
		//<b>英雄技能</b>获得2点护甲值。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            if (ownplay)
            {
                p.minionGetArmor(p.ownHero, 2);
            }
            else
            {
                p.minionGetArmor(p.enemyHero, 2);
            }
		}
		
	}
}
