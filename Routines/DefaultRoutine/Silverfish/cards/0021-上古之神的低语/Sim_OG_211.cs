using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_OG_211 : SimTemplate //* 兽群呼唤 Call of the Wild
//Summon all three Animal Companions.
//召唤所有三种动物伙伴。 
	{
		
		
        CardDB.Card c1 = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.NEW1_034);
        CardDB.Card c2 = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.NEW1_033);
        CardDB.Card c3 = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.NEW1_032);
        
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int pos = (ownplay)?  p.ownMinions.Count : p.enemyMinions.Count;
            p.callKid(c1, pos, ownplay, false);
            p.callKid(c2, pos, ownplay);
            p.callKid(c3, pos, ownplay);
		}
	}
}