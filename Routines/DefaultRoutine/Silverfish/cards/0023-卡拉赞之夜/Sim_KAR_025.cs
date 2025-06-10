using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_KAR_025 : SimTemplate //* 附灵术 Kara Kazham!
//Summon a 1/1 Candle, 2/2 Broom, and 3/3 Teapot.
//召唤一个1/1的蜡烛，2/2的扫帚和3/3的茶壶。 
	{
		
		
        CardDB.Card c1 = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.KAR_025a);
        CardDB.Card c2 = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.KAR_025b);
        CardDB.Card c3 = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.KAR_025c);
        
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int pos = (ownplay)?  p.ownMinions.Count : p.enemyMinions.Count;
            p.callKid(c1, pos, ownplay, false);
            p.callKid(c2, pos, ownplay);
            p.callKid(c3, pos, ownplay);
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
            };
        }
	}
}