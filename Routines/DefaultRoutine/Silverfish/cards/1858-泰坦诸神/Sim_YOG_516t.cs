using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 中立 费用：0
	//Reign of Chaos
	//混沌统治
	//Take control of an enemy minion.
	//夺取一个敌方随从的控制权。
	class Sim_YOG_516t : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            if (target != null)
            {
                p.minionGetControlled(target, true, true, true); // 夺取一个敌方随从的控制权
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),  // 需要选择一个目标
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),    // 目标必须是随从
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET)      // 目标必须是敌方随从
            };
        }
    }
}
