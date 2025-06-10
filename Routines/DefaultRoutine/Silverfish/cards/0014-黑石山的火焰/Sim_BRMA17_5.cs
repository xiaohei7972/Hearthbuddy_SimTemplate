using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BRMA17_5 : SimTemplate //* 白骨爪牙 Bone Minions
//<b>Hero Power</b>Summon two 2/1 Bone Constructs.
//<b>英雄技能</b>召唤两个2/1的白骨结构体。 
	{
		

		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.BRMA17_6);
		
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int place = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
            p.callKid(kid, place, ownplay, false);
            p.callKid(kid, place, ownplay);
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
            };
        }
	}
}