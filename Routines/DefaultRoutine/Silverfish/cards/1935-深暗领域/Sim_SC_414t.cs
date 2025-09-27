using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 战士 费用：8 攻击力：8 生命值：8
	//Thor, Explosive Payload
	//雷神（爆裂弹头）
	//[x]<b>Battlecry:</b> Deal 5 damage.__Repeat at a random enemy__for each <b>Starship</b> you'velaunched this game.@ <i>(@)</i>
	//<b>战吼：</b>造成5点伤害。在本局对战中你每发射过一艘<b>星舰</b>，对一个随机敌人重复一次。@<i>（重复@次）</i>
	class Sim_SC_414t : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            if (target != null)
            {
                p.minionGetDamageOrHeal(target, 5);
            }

        }
		public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),  // 需要选择一个目标
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),   // 目标必须是随从
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),    // 目标必须是敌方
            };
        }
	}
}
