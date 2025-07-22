using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：3 攻击力：5 生命值：1
	//Wax Rager
	//蜡油暴怒者
	//<b>Deathrattle:</b> Resummon this minion.
	//<b>亡语：</b>再次召唤本随从。
	class Sim_VAC_464t22 : SimTemplate
	{

        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.callKid(m.handcard.card, m.zonepos, m.own); // 亡语效果：再次召唤本随从
        }
    }
}
