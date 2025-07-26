using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 德鲁伊 费用：5
	//Cosmic Phenomenon
	//宇宙浑象
	//[x]Summon three 2/3Elementals with <b>Taunt</b>.If your board is full, giveyour minions +1/+1.
	//召唤三个2/3并具有<b>嘲讽</b>的元素。如果你的面板已满，使你的随从获得+1/+1。
	class Sim_GDB_882 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.GDB_882t);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
			p.callKid(kid, pos, ownplay);
			p.callKid(kid, pos, ownplay);
			p.callKid(kid, pos, ownplay);
			if (p.ownMinions.Count == 7)
			{
				p.allMinionOfASideGetBuffed(ownplay, 1, 1);
			}
		}

        // public override PlayReq[] GetPlayReqs()
        // {
		// 	return new PlayReq[]{
		// 		new PlayReq(CardDB.ErrorType2.REQ_MINION_CAP,1), // 需要一个空位
		// 	};
        // }
		
	}
}
