using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 牧师 费用：3
	//Ambush Predators
	//潜踪掠食
	//Summon a 1/1 Spitter with <b>Stealth</b>and <b>Poisonous</b>.<b>Kindred:</b> Do it again.
	//召唤一只1/1并具有<b>潜行</b>和<b>剧毒</b>的喷毒龙。<b>延系：</b>重复一次。
	class Sim_TLC_519 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TLC_519t);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
			p.callKid(kid, pos, ownplay);
			//TODO:延系等做好再写
		}

        public override PlayReq[] GetPlayReqs()
        {
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_MINION_CAP,1), // 需要一个空位
			};
        }
		
	}
}
