using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_KAR_114 : SimTemplate //* 巴内斯 Barnes
//<b>Battlecry:</b> Summon a 1/1 copy of a random minion in your deck.
//<b>战吼：</b>随机挑选你牌库里的一个随从，召唤一个1/1的复制。 
	{
		
		
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.OG_156a); 
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.callKid(kid, own.zonepos, own.own);
		}
	}
}