using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_WC_008 : SimTemplate //* 辛多雷气味猎手 Sin'dorei Scentfinder
	{
		//<b>Frenzy:</b> Summon four 1/1 Hyenas with <b>Rush</b>.
		//<b>暴怒：</b>召唤四只1/1并具有<b>突袭</b>的土狼。
		public override void onEnrageStart(Playfield p, Minion m)
		{
			p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.BAR_035t), m.zonepos, m.own);
			p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.BAR_035t), m.zonepos, m.own);
			p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.BAR_035t), m.zonepos, m.own);
			p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.BAR_035t), m.zonepos, m.own);
		}
	}
}
