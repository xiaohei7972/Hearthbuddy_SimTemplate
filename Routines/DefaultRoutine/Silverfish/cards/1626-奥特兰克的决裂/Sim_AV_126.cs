using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_126 : SimTemplate //* 碉堡中士 bunkersergeant
	{
		//<b>战吼：</b>如果你的对手拥有2个或者更多随从，对所有敌方随从造成1点伤害。
        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            int num = (m.own) ? p.enemyMinions.Count : p.ownMinions.Count;
            if (num > 1)
            {
                p.allMinionOfASideGetDamage(!m.own, 1);
            }
        }

    }
}
