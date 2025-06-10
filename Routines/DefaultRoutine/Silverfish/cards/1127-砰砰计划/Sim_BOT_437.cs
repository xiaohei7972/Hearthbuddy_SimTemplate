using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BOT_437 : SimTemplate //* 地精的把戏 Goblin Prank
//Give a friendly minion +3/+3 and <b>Rush</b>. It_dies at end of turn.
//使一个友方随从获得+3/+3和<b>突袭</b>，该随从会在回合结束时死亡。 
	{
        

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            p.minionGetBuffed(target, 3, 3);
			p.minionGetRush(target);
            if (ownplay)
            {
                target.destroyOnOwnTurnEnd = true;
            }
            else
            {
                target.destroyOnEnemyTurnEnd = true;
            }
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}