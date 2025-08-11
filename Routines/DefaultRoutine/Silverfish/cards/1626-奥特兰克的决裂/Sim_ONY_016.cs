using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 恶魔猎手 费用：1
	//Wings of Hate (Rank 1)
	//憎恨之翼（等级1）
	//Summon two 1/1Felwings. <i>(Upgradeswhen you have 5 Mana.)</i>
	//召唤两只1/1的邪翼蝠。<i>（当你有5点法力值时升级。）</i>
	class Sim_ONY_016 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.BT_922t);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int pos = ownplay ? p.enemyMinions.Count : p.ownMinions.Count;
			p.callKid(kid, pos, ownplay);
			p.callKid(kid, pos, ownplay);

		}
		
		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS,1), //需要一个空位
			};
		}

	}
}
