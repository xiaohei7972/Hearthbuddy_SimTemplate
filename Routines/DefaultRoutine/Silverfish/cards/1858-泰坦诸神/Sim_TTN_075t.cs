using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Triton.Game.Mapping;

namespace HREngine.Bots
{
	//法术 法师 费用：0
	//Progenitor's Power
	//元尊之力
	//Deal @ damage.
	//造成@点伤害。
	class Sim_TTN_075t : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.minionGetDamageOrHeal(target, 5);
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
