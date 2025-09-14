using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：3 攻击力：2 生命值：1
	//Twin-fin Fin Twin
	//并鳍奇兵
	//<b>Rush</b>. <b>Battlecry:</b> Summon a copy of this.
	//<b>突袭</b>。<b>战吼：</b>召唤一个本随从的复制。
	class Sim_TSC_960 : SimTemplate
	{
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
			p.callKid(own.handcard.card, own.zonepos, own.own);
        }
		
	}
}
