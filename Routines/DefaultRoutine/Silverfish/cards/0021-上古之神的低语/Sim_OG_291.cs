using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_OG_291 : SimTemplate //* 暗影施法者 Shadowcaster
//<b>Battlecry:</b> Choose a friendly minion. Add a 1/1 copy to_your hand that costs_(1).
//<b>战吼：</b>选择一个友方随从，将它的一张1/1的复制置入你的手牌，其法力值消耗为（1）点。 
    {
        

        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            if (target != null)
            {
                if (m.own)
                {
                    p.drawACard(target.handcard.card.nameEN, m.own, true);
                    int i = p.owncards.Count - 1;
                    p.owncards[i].addattack = 1 - p.owncards[i].card.Attack;
                    p.owncards[i].addHp = 1 - p.owncards[i].card.Health;
                    p.owncards[i].manacost = 1;
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