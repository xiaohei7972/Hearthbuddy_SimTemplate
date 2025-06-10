using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_EX1_009 : SimTemplate //* 愤怒的小鸡 Angry Chicken
	{
		//Has +5 Attack while damaged.
		//受伤时具有+5攻击力。
        public override void onEnrageStart(Playfield p, Minion m)
        {
            p.minionGetBuffed(m, 5, 0);
        }

        public override void  onEnrageStop(Playfield p, Minion m)
        {
            p.minionGetBuffed(m, -5, 0);
        }

	}
}