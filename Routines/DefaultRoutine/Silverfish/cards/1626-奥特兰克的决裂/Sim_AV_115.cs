using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_115 : SimTemplate //* 风雪增幅体 amplifiedsnowflurry
	{
		//<b>战吼：</b> 你的下一个英雄技能法力值消耗为（0）点，并且会<b>冻结</b>目标。
        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            if (p.ownHeroPowerCostLessOnce <= -99) p.evaluatePenality += 50;
            p.ownHeroPowerCostLessOnce -= 99;
            p.ownAbilityFreezesTarget++;
        }
	}
}
