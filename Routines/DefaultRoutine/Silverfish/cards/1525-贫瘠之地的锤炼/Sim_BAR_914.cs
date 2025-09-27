using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 术士 费用：2
	//Imp Swarm (Rank 1)
	//小鬼集群（等级1）
	//Summon a 3/2 Imp. <i>(Upgrades when you have 5 Mana.)</i>
	//召唤一个3/2的小鬼。<i>（当你有5点法力值时升级。）</i>
	class Sim_BAR_914 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.BAR_914t3);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
			p.callKid(kid, pos, ownplay);
		}

        public override PlayReq[] GetPlayReqs()
        {
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS,1), // 需要一个空位
			};
        }
		
	}
}
