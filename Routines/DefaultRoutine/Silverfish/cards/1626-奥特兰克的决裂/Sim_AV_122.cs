using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_122 : SimTemplate //* 下士 corporal
	{
		//<b>荣誉消灭：</b>使你的其他随从获得<b>圣盾</b>。
        public override void OnHonorableKill(Playfield p, Minion attacker, Minion target)
        {
            if (target != null && attacker.Angr == target.Hp)
            {
                foreach (Minion m in p.ownMinions)
                {
                    m.divineshild = true;
                }
            }
        }
		
	}
}
