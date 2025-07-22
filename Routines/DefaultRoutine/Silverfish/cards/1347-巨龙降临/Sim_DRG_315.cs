using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DRG_315 : SimTemplate //* 森然巨化 Embiggen
	{
		//Give all minions in your deck +2/+2. They cost (1) more <i>(up to 10)</i>.
		//使你牌库中的所有随从牌获得+2/+2，且法力值消耗增加（1）点<i>（最高不超过10点）</i>。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.deckAngrBuff += 2;
			p.deckHpBuff += 2;
			p.evaluatePenality -= 20;
		}
	}
}