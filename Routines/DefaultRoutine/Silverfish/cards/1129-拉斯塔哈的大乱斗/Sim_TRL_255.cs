using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_TRL_255 : SimTemplate //* 狂奔怒吼 Stampeding Roar
//Summon a random Beast from your hand and give it <b>Rush</b>.
//随机从你的手牌中召唤一个野兽，并使其获得<b>突袭</b>。 
    {

        

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            Handmanager.Handcard c = null;
            int sum = 10000;
            foreach (Handmanager.Handcard hc in p.owncards)
            {
                if (hc.card.type == CardDB.cardtype.MOB)
                {
                    int s = hc.card.Health + hc.card.Attack + ((hc.card.tank) ? 1 : 0) + ((hc.card.Shield) ? 1 : 0);
                    if (s < sum)
                    {
                        c = hc;
                        sum = s;
                    }
                }
            }
            if (sum < 9999)
            {
                p.callKid(c.card, p.ownMinions.Count, true, false);
                p.removeCard(c);
                p.triggerCardsChanged(true);
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
    }
}