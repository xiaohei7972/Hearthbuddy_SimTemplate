using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 战士 费用：3 攻击力：2 生命值：3
	//Warsong Commander
	//战歌指挥官
	//Whenever you summon a minion with 3 or less Attack, give it <b>Charge</b>.
	//每当你召唤一个攻击力小于或等于3的随从，使其获得<b>冲锋</b>。
	class Sim_TOY_409t : SimTemplate
	{

        public override void onMinionWasSummoned(Playfield p, Minion own, Minion summoned)
        {
            // 检查是否为己方随从并且攻击力小于或等于3
            if (own.own && summoned.Angr <= 3)
            {
                // 给予召唤的随从冲锋
                summoned.charge = 1;
            }
        }
    }
}
