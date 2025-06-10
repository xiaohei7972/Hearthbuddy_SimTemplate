using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//地标 圣骑士 费用：2
	//Great Hall
	//大厅
	//[x]{0}{1}
	//{0}{1}
	class Sim_REV_794 : SimTemplate
	{
		
		public override void useLocation(Playfield p, Minion triggerMinion, Minion target)
        {
            // 检查目标是否为有效随从
            if (target != null)
            {
                // 将目标随从的攻击力设置为3
                target.Angr = 3;
                
                // 将目标随从的生命值设置为3，并且最大生命值也设置为3
                target.Hp = 3;
                target.maxHp = 3;
            }
        }

        public override PlayReq[] GetUseAbilityReqs()
        {
            return new PlayReq[]
            {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要一个目标才能使用
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),  // 目标必须是一个随从
            };
        }
	}
}
