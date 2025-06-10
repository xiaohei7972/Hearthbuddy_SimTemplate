using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_200p2 : SimTemplate //* 奥术爆裂 arcaneburst
	{
		//<b>英雄技能</b> 造成$1点伤害。 <b>荣誉消灭：</b>获得+2伤害。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (target == null) return;
            var dmg = ownplay ? p.getHeroPowerDamage(1 + p.ownHeroAblility.SCRIPT_DATA_NUM_1) : p.getEnemyHeroPowerDamage(1 + p.ownHeroAblility.SCRIPT_DATA_NUM_1);
            p.minionGetDamageOrHeal(target, dmg);
            if (target.Hp == 0)
            {
                p.evaluatePenality -= 10;
            }
        }
		
	}
}
