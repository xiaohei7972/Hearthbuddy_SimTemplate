using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 战士 费用：6 攻击力：3 生命值：3
	//Hamm, the Hungry
	//饥饿食客哈姆
	//[x]<b>Druid Tourist</b><b>Taunt</b>. At the end of your turn,eat a minion in the enemy'sdeck to gain +2/+2.
	//<b>德鲁伊游客</b><b>嘲讽</b>。在你的回合结束时，吃掉敌方牌库中的一个随从以获得+2/+2。
	class Sim_VAC_340 : SimTemplate
	{
        public override void onTurnEndsTrigger(Playfield p, Minion m, bool turnEndOfOwner)
        {
            // 只在随从所有者的回合结束时触发
            if (turnEndOfOwner == m.own)
            {
                // 给予当前随从 +2/+2 的增益
                p.minionGetBuffed(m, 2, 2);
                
            }
        }

    }
}
