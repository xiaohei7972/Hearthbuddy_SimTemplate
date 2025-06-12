using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：5 攻击力：3 生命值：6
	//Warsong Grunt
	//战歌步兵
	//<b>Rush</b>. After this attacks and kills a minion, it may attack again.
	//<b>突袭</b>在本随从攻击并消灭一个随从后，可再次攻击。
	class Sim_CORE_TOY_103 : SimTemplate
	{
		// fixMe 消灭一个随从后，bot意识不到该随从还可继续攻击
		public override void onMinionDiedTrigger(Playfield p, Minion triggerEffectMinion, Minion diedMinion)
        {
            triggerEffectMinion.allreadyAttacked = false;
        }
	}
}
