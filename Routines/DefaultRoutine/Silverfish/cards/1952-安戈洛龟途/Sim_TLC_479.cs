using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 术士 费用：6 攻击力：2 生命值：8
	//Deathrot Maw
	//死烂巨口
	//<b>Taunt</b><b>Deathrattle:</b> Summon a random Fel Beast.
	//<b>嘲讽</b>。<b>亡语：</b>随机召唤一只邪能野兽。
	class Sim_TLC_479 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TLC_446t2);
		CardDB.Card kid1 = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TLC_446t3);
		CardDB.Card kid2 = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TLC_446t4);

        public override void onDeathrattle(Playfield p, Minion m)
        {
			p.callKid(kid, m.zonepos - 1, m.own);
        }
		
	}
}
