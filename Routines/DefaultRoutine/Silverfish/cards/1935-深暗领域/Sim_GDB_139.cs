using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 圣骑士 费用：6
	//Libram of Faith
	//信仰圣契
	//Summon three3/3 Draenei with <b>Divine Shield</b>. If this costs (0), give them <b>Rush</b>.
	//召唤三个3/3并具有<b>圣盾</b>的德莱尼。如果本牌的法力值消耗为（0）点，使其获得<b>突袭</b>。
	class Sim_GDB_139 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.GDB_139t);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice, Handmanager.Handcard hc)
		{
			int pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
			p.callKid(kid, pos, ownplay);
			p.callKid(kid, pos, ownplay);
			p.callKid(kid, pos, ownplay);
			//有空再写突袭
			// if (hc.card.cost == 0)
			
        }

        public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_MINION_CAP,1), // 需要一个空位
			};
		}
		
	}
}
