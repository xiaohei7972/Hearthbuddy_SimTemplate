using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 术士 费用：3
	//Furnace Fuel
	//锅炉燃料
	//When this is played,discarded, or destroyed,draw 2 cards.
	//当本牌被使用，弃掉或摧毁时，抽两张牌。
	class Sim_WW_441 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.drawACard(CardDB.cardIDEnum.None, ownplay);
			p.drawACard(CardDB.cardIDEnum.None, ownplay);
		}	
		
	}
}
