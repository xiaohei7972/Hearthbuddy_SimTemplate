using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_CORE_GIL_191 : SimTemplate //* 恶魔法阵
    {
        //

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.GIL_191t);//

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;

            p.callKid(kid, pos, ownplay, false);
            p.callKid(kid, pos, ownplay);
            p.callKid(kid, pos, ownplay);
            p.callKid(kid, pos, ownplay);
        }
        
        public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_MINION_CAP,1), // 需要选择一个空位
			};
		}
	}
}