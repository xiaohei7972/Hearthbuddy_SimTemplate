using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 潜行者 费用：4 攻击力：4 生命值：4
	//Narain Soothfancy
	//纳瑞安·柔想
	//<b>Battlecry:</b> Get two Fortunes that are copies of the top card of your deck.
	//<b>战吼：</b>获取两张预知命运。预知命运为你牌库顶的牌的复制。
	class Sim_VAC_420 : SimTemplate
	{

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            // 直接抽两张牌
            p.drawACard(CardDB.cardIDEnum.VAC_420t, own.own, true); // 抽第一张牌
            p.drawACard(CardDB.cardIDEnum.VAC_420t, own.own, true); // 抽第二张牌
        }
    }
}
