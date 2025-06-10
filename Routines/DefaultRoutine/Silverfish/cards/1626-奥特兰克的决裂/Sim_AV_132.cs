using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_132 : SimTemplate //* 巨魔百夫长 trollcenturion
	{
		//<b>突袭</b>， <b>荣誉消灭：</b>对敌方英雄造成8点伤害。
        public override void OnHonorableKill(Playfield p, Minion attacker, Minion target)
        {
            if (target != null && attacker.Angr == target.Hp)
            {
                p.minionGetDamageOrHeal(p.enemyHero, 3);
            }
        }
		
	}
}
