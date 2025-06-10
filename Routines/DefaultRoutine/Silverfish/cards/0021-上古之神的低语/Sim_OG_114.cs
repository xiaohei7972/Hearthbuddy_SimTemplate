using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_OG_114 : SimTemplate //* 禁忌仪式 Forbidden Ritual
//Spend all your Mana. Summon that many 1/1 Tentacles.
//消耗你所有的法力值，每消耗一点法力值，便召唤一个1/1的触须。 
	{
		

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.OG_114a); 

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (ownplay)
			{
				if (p.mana > 0)
                {
				    int pos = p.ownMinions.Count;
                    int anz = Math.Min(7 - pos, p.mana);
					p.callKid(kid, pos, ownplay, false);
                    anz--;
                    for (int i = 0; i < anz; i++)
					{
						p.callKid(kid, pos, ownplay);
					}
					p.mana = 0;
				}				
			}
		}
	}
}