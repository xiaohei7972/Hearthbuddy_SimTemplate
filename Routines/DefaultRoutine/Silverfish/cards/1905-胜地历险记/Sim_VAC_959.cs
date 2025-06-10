using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：4 攻击力：4 生命值：5
	//Griftah, Trusted Vendor
	//诚信商家格里伏塔
	//[x]<b>Battlecry:</b> <b>Discover</b> anamazing Amulet to give toboth players. <i>(The enemy'sis a phony version!)</i>
	//<b>战吼：</b><b>发现</b>一款神奇的护符，赠予双方玩家。<i>（敌人的护符为伪劣版本！）</i>
	class Sim_VAC_959 : SimTemplate
	{
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            // 抽取一张牌
            p.drawACard(CardDB.cardIDEnum.None, own.own, true);
        }
    }
}
