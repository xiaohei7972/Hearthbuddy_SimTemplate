using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 萨满祭司 费用：5 攻击力：5 生命值：5
	//Carress, Cabaret Star
	//歌唱明星卡瑞斯
	//<b>Battlecry:</b> Draw 2 cards.Gain +2/+2 and <b>Taunt</b>.
	//<b>战吼：</b>抽两张牌。获得+2/+2和<b>嘲讽</b>。
	class Sim_VAC_449t2 : SimTemplate
	{

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            // 抽两张牌
            p.drawACard(CardDB.cardIDEnum.None, own.own);
            p.drawACard(CardDB.cardIDEnum.None, own.own);

            // 增加+2/+2
            p.minionGetBuffed(own, 2, 2);

            // 赋予嘲讽
            own.taunt = true;
        }
    }
}
