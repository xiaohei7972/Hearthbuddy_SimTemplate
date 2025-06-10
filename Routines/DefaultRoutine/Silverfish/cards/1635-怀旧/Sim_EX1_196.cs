using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_EX1_196 : SimTemplate //* 血色征服者 Scarlet Subjugator
	{
        //<b>Battlecry:</b> Give an enemy minion -2 Attack until your_next turn.
        //<b>战吼：</b>直到你的下个回合，使一个敌方随从获得-2攻击力。
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (target != null)
            {
                p.minionGetTempBuff(target, -2, 0);
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
            };
        }
    }
}
