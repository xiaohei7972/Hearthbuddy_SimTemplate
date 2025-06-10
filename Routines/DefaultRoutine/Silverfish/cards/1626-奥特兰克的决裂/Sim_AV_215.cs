using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_215 : SimTemplate //* 狂乱角鹰兽 frantichippogryph
	{
		//<b>突袭</b>，<b>荣誉消灭：</b>获得<b>风怒</b>。
        public override void OnHonorableKill(Playfield p, Minion attacker, Minion target)
        {
            if (target != null && attacker.Angr == target.Hp)
            {
                attacker.windfury = true;
            }
        }
		
	}
}
