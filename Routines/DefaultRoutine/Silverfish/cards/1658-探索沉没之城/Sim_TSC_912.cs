using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 牧师 费用：5
	//Azsharan Vessel
	//艾萨拉的舰船
	//Summon two 3/3 Pirates with <b>Stealth</b>. Put a 'Sunken Vessel' on the bottom of your deck.
	//召唤两个3/3并具有<b>潜行</b>的海盗。将一张沉没的舰船置于你的牌库底。
	class Sim_TSC_912 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TSC_912t3);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
			p.callKid(kid, pos, ownplay);
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
