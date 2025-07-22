using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 圣骑士 费用：1
	//Emerald Portal
	//翡翠传送门
	//<b>Casts When Drawn</b>Summon a random@-Cost Dragon.
	//<b>抽到时施放</b>随机召唤一条法力值消耗为（@）的龙。
	class Sim_EDR_445pt3 : SimTemplate
	{
		// 默认召唤大表哥
		// 正常写的话要写字典
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.VAN_NEW1_030);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
			p.callKid(kid, pos, ownplay);
		}
		
	}
}
