using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 萨满祭司 费用：4
	//Totally Totems
	//图腾团聚
	//Summon all FIVE<i>?!</i> basic Totems.<b>Overload:</b> (1)
	//召唤全部五种<i>（？！）</i>基础图腾。<b>过载：</b>（1）
	class Sim_WON_091 : SimTemplate
	{
		CardDB.Card SearingTotem = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_050);
		CardDB.Card WrathofAirTotem = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_052);
		CardDB.Card HealingTotem = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.NEW1_009);
		CardDB.Card StoneclawTotem = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_051);
		CardDB.Card StrengthTotem = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_058);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
			p.callKid(SearingTotem, pos, ownplay);
			p.callKid(WrathofAirTotem, pos, ownplay);
			p.callKid(HealingTotem, pos, ownplay);
			p.callKid(StoneclawTotem, pos, ownplay);
			p.callKid(StrengthTotem, pos, ownplay);
		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS,1), // 需要一个空位
			};
		}

	}
}
