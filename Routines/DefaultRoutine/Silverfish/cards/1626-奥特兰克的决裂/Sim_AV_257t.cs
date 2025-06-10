using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_257t : SimTemplate //* 冰封雄鹿守卫 frozenstagguard
	{
		//<b>冻结</b>任何受到该随从伤害的角色。

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (target != null) p.minionGetFrozen(target);
        }
	}
}
