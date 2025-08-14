using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 潜行者 费用：4
	//Gravedawn Voidbulb
	//墓晨虚空芽
	//Summon a random 4-Cost minion andgive it <b>Taunt</b>.<b>Kindred:</b> Do it again.
	//随机召唤一个法力值消耗为（4）的随从并使其获得<b>嘲讽</b>。<b>延系：</b>重复一次。
	class Sim_TLC_815 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.REV_510); //477你招不招
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
			p.callKid(kid, pos, ownplay);
		}
		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS,1), //最少需要一个空位
			};
		}
		
	}
}
