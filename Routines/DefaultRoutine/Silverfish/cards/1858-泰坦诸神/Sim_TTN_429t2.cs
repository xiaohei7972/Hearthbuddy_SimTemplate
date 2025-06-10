using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 潜行者 费用：0
	//Strike from History
	//扫出历史
	//Choose two enemy minions. Remove them from the game.
	//选择两个敌方随从，将其移出对战。
	class Sim_TTN_429t2 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.RemoveMinionWithoutDeathrattle(target); // 移出战场 待完善
            p.drawACard(CardDB.cardIDEnum.None, true);
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),        // 需要选择目标
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),          // 目标必须是随从
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),           // 目标必须是敌方随从
            };
        }
    }
}
