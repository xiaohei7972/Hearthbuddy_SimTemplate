using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：8 攻击力：6 生命值：6
	//Thunderbringer
	//奔雷骏马
	//[x]<b>Taunt</b><b>Deathrattle:</b> Summon anElemental and Beast fromyour deck.
	//<b>嘲讽</b>。<b>亡语：</b>从你的牌库中召唤一个元素和一只野兽。
	class Sim_WW_440 : SimTemplate
	{
		CardDB.Card kid1 = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_179);
		CardDB.Card kid2 = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.UNG_928);
        public override void onDeathrattle(Playfield p, Minion m)
        {
			p.callKid(kid1, m.zonepos, m.own);
			p.callKid(kid2, m.zonepos, m.own);
		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[] {
				new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 2), // 空位大于等于2
			};
		}
		
	}
}
