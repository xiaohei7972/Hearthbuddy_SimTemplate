using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //* 侏儒列兵 gnomeprivate
    //<b>荣誉消灭：</b>获得+2攻击力。
    class Sim_AV_121 : SimTemplate
    {
        public override void OnHonorableKill(Playfield p, Minion attacker, Minion target)
        {
            p.minionGetTempBuff(attacker, 2, 0);
        }

    }
}
