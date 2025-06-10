using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BAR_074 : SimTemplate //* 前沿哨所 Far Watch Post
	{
		//[x]Can't attack. After youropponent draws a card, it___costs (1) more <i>(up to 10)</i>.__
		//无法攻击。在你的对手抽一张牌后，使其法力值消耗增加（1）点<i>（最高不超过10点）</i>。
		// FIX 回合开始阶段 - 1 法力水晶
		public override void onTurnStartTrigger(Playfield p, Minion triggerEffectMinion, bool turnStartOfOwner)
        {
			// 敌方回合，我方哨所
			if (!turnStartOfOwner && triggerEffectMinion.own != turnStartOfOwner)
            {
				p.enemyMaxMana --;
            }
			// 我方回合，敌方哨所
			else if(turnStartOfOwner && triggerEffectMinion.own != turnStartOfOwner)
            {
				p.ownMaxMana --;
            }
        }
		
	}
}
