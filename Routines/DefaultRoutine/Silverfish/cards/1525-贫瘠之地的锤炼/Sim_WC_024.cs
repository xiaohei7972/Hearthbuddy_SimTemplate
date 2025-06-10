using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_WC_024 : SimTemplate //* 武装战士 Man-at-Arms
	{
        //<b>Battlecry:</b> If you have a weapon equipped, gain +1/+1.
        //<b>战吼：</b>如果你装备着武器，便获得+1/+1。
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if(p.ownWeapon.Durability > 0)
            {
                p.minionGetBuffed(own, 1, 1);
            }
        }

    }
}
