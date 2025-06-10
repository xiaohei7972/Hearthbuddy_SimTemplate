using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：2 攻击力：2 生命值：2
	//Rolling Stone
	//摇滚巨石
	//[x]<b>Rush</b><b>Battlecry:</b> If the last cardyou played costs (1),gain +1/+1.
	//<b>突袭</b>。<b>战吼：</b>如果你使用的上一张牌法力值消耗为（1）点，便获得+1/+1。
	class Sim_ETC_742 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 获取上次打出的牌的法力值消耗
            int lastCardCost = p.lastPlayedCardCost;

            // 判断上次打出的牌是否法力值消耗为1
            if (lastCardCost == 1)
            {
                // 增加随从的攻击力和生命值
                target.Angr += 1;
                target.Hp += 1;
            }
        }
    }
}
