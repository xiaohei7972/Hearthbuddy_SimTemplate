using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_093: SimTemplate //* 海象人渔夫 Tuskarr Fisherman
//<b>Battlecry:</b> Give a friendly minion <b>Spell Damage +1</b>.
//<b>战吼：</b>使一个友方随从获得<b>法术伤害+1</b>。 
    {
        

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (target != null)
            {
                target.spellpower++;
                if (target.own) p.spellpower++;
                else p.enemyspellpower++;
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