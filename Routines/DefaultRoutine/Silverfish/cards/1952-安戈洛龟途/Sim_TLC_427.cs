using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：2 攻击力：1 生命值：3
	//Rockskipper
	//抛石鱼人
	//<b>Battlecry:</b> Get a 1-CostRock that deals $3 damage.
	//<b>战吼：</b>获取一张法力值消耗为（1）的石头。石头可以造成$3点伤害。
	class Sim_TLC_427 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			p.drawACard(CardDB.cardIDEnum.WW_001t, own.own, false);
		}

	}
}
