using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_123 : SimTemplate //* 潜匿斥候 sneakyscout
	{
		//<b>潜行</b>，<b>荣誉消灭：</b> 你的下一个英雄技能的法力值消耗为（0）点。
        public override void OnHonorableKill(Playfield p, Minion attacker, Minion target)
        {
            if (target != null && attacker.Angr == target.Hp && !target.divineshild)
            {
                if (p.ownHeroPowerCostLessOnce <= -99) p.evaluatePenality += 50;
                p.ownHeroPowerCostLessOnce -= 99;
            }
        }
		
	}
}
