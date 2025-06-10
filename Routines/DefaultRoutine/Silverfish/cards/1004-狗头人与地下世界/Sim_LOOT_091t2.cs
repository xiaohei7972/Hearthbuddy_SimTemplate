using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_091t2 : SimTemplate //* 大型法术珍珠 Greater Pearl Spellstone
//Summon a 6/6 Spirit with <b>Taunt</b>.
//召唤一个6/6并具有<b>嘲讽</b>的灵魂。 
	{
        

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.LOOT_091t2t);

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;

            p.callKid(kid, pos, ownplay, false);
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}