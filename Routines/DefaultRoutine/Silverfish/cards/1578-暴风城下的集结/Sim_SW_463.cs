using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SW_463 : SimTemplate //* 进口狼蛛 Imported Tarantula
	{
		//[x]<b>Tradeable</b> <b>Deathrattle:</b> Summon two1/1 Spiders with<b>Poisonous</b> and <b>Rush</b>.
		//<b>可交易</b><b>亡语：</b>召唤两只1/1并具有<b>剧毒</b>和<b>突袭</b>的蜘蛛。
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.SW_463t);

		public override void onDeathrattle(Playfield p, Minion m)
		{
			p.callKid(kid, m.zonepos - 1, m.own);
			p.callKid(kid, m.zonepos - 1, m.own);
		}


	}
}
