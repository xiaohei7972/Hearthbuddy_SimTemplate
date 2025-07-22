using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_852: SimTemplate //* 塔达拉姆王子 Prince Taldaram
//<b>Battlecry:</b> If your deck has_no 3-Cost cards, transform into a 3/3 copy of a minion.
//<b>战吼：</b>如果你的牌库里没有法力值消耗为（3）的牌，则该随从变形成为一个随从的3/3的复制。 
    {
        

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (own.own && p.prozis.getDeckCardsForCost(3) == CardDB.cardIDEnum.None)
            {
                if (target != null)
                {
                    bool source = own.own;
                    own.setMinionToMinion(target);
                    own.own = source;
                    own.Angr = 3;
                    own.Hp = 3;
                    own.maxHp = 3;
                    own.handcard.card.sim_card.onAuraStarts(p, own);
                }
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
    }
}