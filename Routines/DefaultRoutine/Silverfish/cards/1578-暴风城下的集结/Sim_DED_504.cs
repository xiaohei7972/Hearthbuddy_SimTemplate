using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_DED_504 : SimTemplate //* 邪恶船运 Wicked Shipment
    {
        //可交易召唤2个1/1的小鬼。（被交易时会升级，增加2个！）
        //Tradeable Summon 2 1/1 |4(Imp, Imps). (Upgrades by 2 when Traded!)
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.GIL_191t);
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;

            p.callKid(kid, pos, ownplay, false);
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
