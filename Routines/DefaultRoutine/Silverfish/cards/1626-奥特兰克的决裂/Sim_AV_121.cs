using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_121 : SimTemplate //* 侏儒列兵 gnomeprivate
	{
		//<b>荣誉消灭：</b>获得+2攻击力。
        public override void OnHonorableKill(Playfield p, Minion attacker, Minion target)
        {
            if (target != null && attacker.Angr == target.Hp)
            {
                p.minionGetTempBuff(attacker, 2, 0);
            }
        }
		
	}
}
