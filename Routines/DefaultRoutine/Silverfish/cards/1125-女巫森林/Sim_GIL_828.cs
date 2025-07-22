using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GIL_828 : SimTemplate //* 凶猛狂暴 Dire Frenzy
//Give a Beast +3/+3. Shuffle 3 copies into your deck with +3/+3.
//使一个野兽获得+3/+3。将它的三张复制洗入你的牌库，且这些复制都具有+3/+3。 
    {
        

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
			p.minionGetBuffed(target, 3, 3);
			
            if (ownplay)
            {
                p.ownDeckSize += 3;
            }
            else
            {
                p.enemyDeckSize += 3;
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_WITH_RACE, 20),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
    }
}