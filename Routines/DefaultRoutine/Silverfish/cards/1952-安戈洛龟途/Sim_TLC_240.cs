using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 圣骑士 费用：6 攻击力：6 生命值：3
	//Tyrannogill
	//填鳃暴龙
	//[x]<b>Rush</b><b>Deathrattle:</b> Summon three2/1 Murlocs. Give them eacha random <b>Bonus Effect</b>.
	//<b>突袭</b>。<b>亡语：</b>召唤三个2/1的鱼人，使其各获得一项随机<b>额外效果</b>。
	class Sim_TLC_240 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TLC_240t);
		CardDB.Card kid1 = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TLC_240t2);
		CardDB.Card kid2 = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TLC_240t3);
		public override void onDeathrattle(Playfield p, Minion m)
		{
			p.callKid(kid, m.zonepos - 1, m.own);
			p.callKid(kid1, m.zonepos - 1, m.own);
			p.callKid(kid2, m.zonepos - 1, m.own);
		}

	}
}
