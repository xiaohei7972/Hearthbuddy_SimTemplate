using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HREngine.Bots
{
	//法术 术士 费用：0
	//Cursed Catacombs
	//咒怨之墓
	//<b>Discover</b> anothercard from your deck. Make it <b>Temporary</b>.
	//从你的牌库中<b>发现</b>另一张牌，将其变为<b>临时</b>卡牌。
	class Sim_TLC_451 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			// 1.选择的牌
			p.drawTemporaryCard(Hrtprozis.Instance.enchs.LastOrDefault(), ownplay);
		}

	}
}
