using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_554 : SimTemplate //* 大厨诺米 Chef Nomi
//<b>Battlecry:</b> If your deck is empty, summon six 6/6 Greasefire_Elementals.
//<b>战吼：</b>如果你的牌库里没有牌，则召唤六个6/6的猛火元素。 
	{
		
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.DAL_554t);
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if(p.ownDeckSize == 0)
            {
                p.callKid(kid, own.zonepos -1, own.own);
				p.callKid(kid, own.zonepos -1, own.own);
				p.callKid(kid, own.zonepos -1, own.own);
				p.callKid(kid, own.zonepos, own.own);
				p.callKid(kid, own.zonepos, own.own);
				p.callKid(kid, own.zonepos, own.own);
            }
		}
	}
}