using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GVG_010 : SimTemplate //* 维伦的恩泽 Velen's Chosen
//Give a minion +2/+4 and <b>Spell Damage +1</b>.
//使一个随从获得+2/+4和<b>法术伤害+1</b>。 
    {

        

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.minionGetBuffed(target, 2, 4);
            target.spellpower++;
            if (target.own) p.spellpower++;
            else p.enemyspellpower++;

        }



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
    }

}