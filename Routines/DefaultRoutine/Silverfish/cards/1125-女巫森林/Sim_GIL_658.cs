using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GIL_658 : SimTemplate //* 碎枝 Splintergraft
//[x]<b>Battlecry:</b> Choose a friendlyminion. Add a 10/10 copy toyour hand that costs (10).
//<b>战吼：</b>选择一个友方随从。将它的一张10/10复制置入你的手牌，其法力值消耗为（10）点。 
    {
        

        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            if (target != null)
            {
                if (m.own)
                {
                    p.drawACard(target.handcard.card.nameEN, m.own, true);
                    int i = p.owncards.Count - 10;
                    p.owncards[i].addattack = 10 - p.owncards[i].card.Attack;
                    p.owncards[i].addHp = 10 - p.owncards[i].card.Health;
                    p.owncards[i].manacost = 10;
                }
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
            };
        }
    }
}