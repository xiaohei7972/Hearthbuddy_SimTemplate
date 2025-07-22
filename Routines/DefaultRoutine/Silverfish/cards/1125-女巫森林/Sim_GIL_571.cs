using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GIL_571 : SimTemplate //* 巫术时刻 Witching Hour
//Summon a random friendly Beast that died this game.
//随机召唤一个在本局对战中死亡的友方野兽。 
	{
		
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.ICC_835); 
		
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            if (p.ownMaxMana >= 8)
            {
                int pos	= ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
                CardDB.Card kid = CardDB.Instance.getCardDataFromID((p.OwnLastDiedMinion == CardDB.cardIDEnum.None) ? CardDB.cardIDEnum.EX1_345t : p.OwnLastDiedMinion); 
                p.callKid(kid, pos, ownplay, false);
            }
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
            };
        }
	}
}