using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 萨满祭司 费用：5 攻击力：5 生命值：5
	//Carress, Cabaret Star
	//歌唱明星卡瑞斯
	//<b>Battlecry:</b> Draw 2 cards.<b>Freeze</b> three random enemy minions.
	//<b>战吼：</b>抽两张牌。随机<b>冻结</b>三个敌方随从。
	class Sim_VAC_449t1 : SimTemplate
	{
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            // 仅实现抽两张牌的效果
            p.drawACard(CardDB.cardIDEnum.None, own.own);
            p.drawACard(CardDB.cardIDEnum.None, own.own);
        }
    }
}
