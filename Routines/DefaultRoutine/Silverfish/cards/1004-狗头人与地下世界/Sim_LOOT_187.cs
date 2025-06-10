using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_187 : SimTemplate //* 暮光召唤 Twilight's Call
//Summon 1/1 copies of 2 friendly <b>Deathrattle</b> minionsthat died this game.
//召唤两个在本局对战中死亡，并具有<b>亡语</b>的友方随从的1/1复制。 
	{
		

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_029);

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int pos =(ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;

            p.callKid(kid, pos, ownplay, false);
            p.callKid(kid, pos, ownplay);
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_MINION_DIED_THIS_GAME),
            };
        }
	}
}