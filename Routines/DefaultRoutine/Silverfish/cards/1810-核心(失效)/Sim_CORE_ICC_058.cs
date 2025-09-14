using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 萨满祭司 费用：2 攻击力：2 生命值：2
	//Brrrloc
	//冷冻鱼人
	//<b>Battlecry:</b> <b>Freeze</b> an_enemy.
	//<b>战吼：</b><b>冻结</b>一个敌人。
	class Sim_CORE_ICC_058 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (target != null) p.minionGetFrozen(target);
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
		
	}
}
