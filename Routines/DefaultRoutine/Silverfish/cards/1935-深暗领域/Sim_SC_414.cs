using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 战士 费用：8 攻击力：8 生命值：8
	//Thor
	//雷神
	//[x]<b>Battlecry:</b> Deal 5 damage.<i>(Transforms if you launcheda <b>Starship</b> this game.)</i>
	//<b>战吼：</b>造成5点伤害。<i>（如果你在本局对战中发射过<b>星舰</b>，则会变形。）</i>
	class Sim_SC_414 : SimTemplate
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
