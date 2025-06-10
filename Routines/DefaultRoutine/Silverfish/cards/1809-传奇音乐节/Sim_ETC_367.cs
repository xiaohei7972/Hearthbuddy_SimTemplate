using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 萨满祭司 费用：0
	//Melomania
	//音乐狂欢
	//Each time you play a minion this turn,add a random Shaman spell to your hand.
	//在本回合中，每当你使用一张随从牌，随机将一张萨满祭司法术牌置入你的手牌。
	class Sim_ETC_367 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.drawACard(CardDB.cardIDEnum.None, ownplay);
		}
		
	}
}
