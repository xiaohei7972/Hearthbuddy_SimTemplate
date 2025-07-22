using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_054: SimTemplate //* 传播瘟疫 Spreading Plague
//Summon a 1/5 Scarab with <b>Taunt</b>. If your_opponent has more minions, cast this again.
//召唤一只1/5并具有<b>嘲讽</b>的甲虫。如果你的对手拥有的随从更多，则再次施放该法术。 
    {
        

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.ICC_832t4); 

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (ownplay)
            {
                do
                {
                    p.callKid(kid, p.ownMinions.Count, ownplay);
                }
                while (p.enemyMinions.Count > p.ownMinions.Count);
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