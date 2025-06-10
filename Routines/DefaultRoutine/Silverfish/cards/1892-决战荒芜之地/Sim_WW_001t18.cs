using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 中立 费用：1
	//Pouch of Coins
	//钱袋
	//Get two Coins.
	//获取两张幸运币。
	class Sim_WW_001t18 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			// 如果是玩家的法术，增加玩家幸运币的数量
			p.drawACard(CardDB.cardIDEnum.GAME_005, ownplay);
			p.drawACard(CardDB.cardIDEnum.GAME_005, ownplay);
		}
	}
}
