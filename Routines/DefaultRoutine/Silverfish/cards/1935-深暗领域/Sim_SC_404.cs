using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 圣骑士 费用：3
	//Salvage the Bunker
	//回收地堡
	//Summon two 2/2 Marines with <b>Taunt</b>.Your next <b>Starship</b>launch costs (2) less.
	//召唤两个2/2并具有<b>嘲讽</b>的陆战队员。你的下一次<b>星舰</b>发射的法力值消耗减少（2）点。
	class Sim_SC_404 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.SC_403t);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
			p.callKid(kid, pos, ownplay, false);
			p.callKid(kid, pos, ownplay);
			//TODO:星舰发射的法力值消耗减少需要更新其他代码
		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1), // 最少需要一个位置

			};

		}
		
	}
}
