using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_405 : SimTemplate //* 珍藏私货 contrabandstash
	{
		//重新使用五张在本局对战中你所使用过的另一职业的卡牌。
        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool ownplay, Handmanager.Handcard triggerhc)
        {
            //CardDB.cardIDEnum note = CardDB.cardIDEnum.None;
            //int i = 0;
            //foreach (KeyValuePair<CardDB.cardIDEnum, int> e in Probabilitymaker.Instance.ownGraveyard)
            //{
            //    if (e.Key == CardDB.cardIDEnum.AV_338)
            //    {
            //        note = e.Key;
            //        i++;
            //    }
            //    if (i == 5) break;
            //}
        }
		
	}
}
