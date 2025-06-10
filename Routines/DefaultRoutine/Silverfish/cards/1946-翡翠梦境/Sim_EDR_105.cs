using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：2 攻击力：1 生命值：2
	//Creature of Madness
	//疯狂生物
	//<b>Battlecry:</b> <b>Discover</b> a3-Cost minion with a <b>Dark_Gift.</b>
	//<b>战吼：</b><b>发现</b>一张具有<b>黑暗之赐</b>的法力值消耗为（3）的随从牌。
	class Sim_EDR_105 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.drawACard(CardDB.cardNameEN.unknown, own.own, true);
        }
		
	}
}
