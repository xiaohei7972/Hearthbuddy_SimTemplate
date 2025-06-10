using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//地标 中立 费用：7
	//Prison of Yogg-Saron
	//尤格-萨隆的监狱
	//[x]Choose a character.Cast 4 random spells<i>(targeting it if possible)</i>.
	//选择一个角色。随机施放4个法术<i>（尽可能以其为目标）</i>。
	class Sim_TTN_090 : SimTemplate
	{

        public override void useLocation(Playfield p, Minion triggerMinion, Minion target)
        {
            // 检查目标是否为有效角色（随从或英雄）
            if (target != null)
            {
                p.minionGetDamageOrHeal(target, 1);
                // 随机施放 4 个法术
                for (int i = 0; i < 4; i++)
                {
                }
            }
        }

        public override PlayReq[] GetUseAbilityReqs()
        {
            return new PlayReq[]
            {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要一个目标才能使用
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET), // 需要一个目标才能使用
            };
        }
    }
}
