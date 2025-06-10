using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_393 : SimTemplate //* 阿曼尼狂战士 Amani Berserker
	{
		//Has +3 Attack while damaged.
		//受伤时具有+3攻击力。

        public override void onEnrageStart(Playfield p, Minion m)
        {
            m.Angr += 3;
        }

        public override void onEnrageStop(Playfield p, Minion m)
        {
            m.Angr -= 3;
        }

	}
}