using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TRL_533 : SimTemplate //* 冰淇淋小贩 Ice Cream Peddler
//<b>Battlecry:</b> If you control a_<b>Frozen</b> minion, gain 8_Armor.
//<b>战吼：</b>如果你控制一个被<b>冻结</b>的随从，便获得8点护甲值。 
	{
		

		public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
		{
            bool frozen = false;

            if (!frozen)
            {
                List<Minion> temp = (m.own) ? p.ownMinions : p.enemyMinions;
                foreach (Minion mnn in temp)
                {
                    if (mnn.frozen)
                    {
                        frozen = true;
                        break;
                    }
                }
            }

            if (frozen) p.minionGetArmor(m.own ? p.ownHero : p.enemyHero, 8);
		}
	}
}