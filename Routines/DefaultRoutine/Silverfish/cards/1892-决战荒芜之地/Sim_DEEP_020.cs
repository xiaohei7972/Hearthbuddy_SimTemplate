using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 战士 费用：8 攻击力：2 生命值：4
	//Deepminer Brann
	//深岩矿工布莱恩
	//[x]<b>Battlecry:</b> If your deck startedwith no duplicates, your<b>Battlecries</b> trigger twice forthe rest of the game.
	//<b>战吼：</b>如果你的套牌里没有相同的牌，则在本局对战的剩余时间内，你的<b>战吼</b>会触发两次。
	class Sim_DEEP_020 : SimTemplate
	{
        public override void getBattlecryEffect(Playfield p, Minion ownMinion, Minion target, int choice)
        {
            // 设置玩家战吼效果触发两次的标志
            if (ownMinion.own)
            {
                p.ownBrannBronzebeard++;
            }
        }
    }
}
