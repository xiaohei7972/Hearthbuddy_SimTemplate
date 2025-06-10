using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_340 : SimTemplate //* 亮铜之翼 brasswing
	{
		//在你的回合结束时，对所有敌人造成2点伤害。<b>荣誉消灭：</b>为你的英雄恢复4点生命值。
        public override void onAuraEnds(Playfield p, Minion m)
        {           
            foreach (Minion mm in p.enemyMinions)
            {
                if (!mm.divineshild && mm.Hp == 2)
                {
                    p.minionGetDamageOrHeal(p.ownHero, -4);
                }
            }
            p.allMinionOfASideGetDamage(!m.own, 2);
        }
		
	}
}
