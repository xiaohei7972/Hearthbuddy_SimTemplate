using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 圣骑士 费用：1
	//Fancy Packaging
	//光鲜包装
	//Give a minion with <b>Divine Shield</b> +2/+3.
	//使一个具有<b>圣盾</b>的随从获得+2/+3。
	class Sim_TOY_881 : SimTemplate
	{

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 检查目标随从是否具有圣盾
            if (target != null && target.divineshild)
            {
                // 给目标随从+2攻击力和+3生命值
                p.minionGetBuffed(target, 2, 3);
            }
        }

    }
}
