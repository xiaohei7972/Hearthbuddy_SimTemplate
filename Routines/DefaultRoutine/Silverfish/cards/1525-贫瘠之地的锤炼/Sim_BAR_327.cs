using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 恶魔猎手 费用：3
	//Vile Call
	//邪恶召唤
	//Summon two 2/2 Demons with <b>Lifesteal</b>.
	//召唤两个2/2并具有<b>吸血</b>的恶魔。
	class Sim_BAR_327 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.BAR_327t);
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
